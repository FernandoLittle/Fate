using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Dio : MonoBehaviourPunCallbacks
{
    public static Dio Brando;
    public RoomOptions RO;
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Brando = this;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("Conectado");
    }
    public void Find1()
    {
        PhotonNetwork.JoinRandomRoom();
    }
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        RoomOptions RO = new RoomOptions()
        {
        MaxPlayers = 2,
        IsOpen = true,
        IsVisible=true
        };
        PhotonNetwork.CreateRoom(null, RO);
        Debug.Log("HU");
        //test
        //PhotonNetwork.LoadLevel("Main");
    }
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log("BlendWeights");
        if(PhotonNetwork.CurrentRoom.PlayerCount==2 && PhotonNetwork.IsMasterClient)
        {
            Debug.Log("Bla");
            Brando.photonView.RPC("LevelL", RpcTarget.All);
        }
    }
    [PunRPC]
    public void LevelL()
    {
        PhotonNetwork.LoadLevel("Main");
    }
}
