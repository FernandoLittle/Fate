using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
public class Connector : MonoBehaviourPunCallbacks
{
    public static Connector Connect;
    public Text testito;
    public Text testito2;
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Connect = this;
    }
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        
        
    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("Conectado");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Find1()
    {
        PhotonNetwork.JoinRandomRoom();
    }
    public override void OnCreatedRoom()
    {
        testito2.text = ("Create");
        testito.text = PhotonNetwork.CurrentRoom.Name;
        Debug.Log(PhotonNetwork.CurrentRoom.Name);
    }
    public override void OnJoinedRoom()
    {
        //testito2.text = ("Join");
        testito.text = PhotonNetwork.CurrentRoom.Name;
        Debug.Log(PhotonNetwork.CurrentRoom.Name);
    }
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        RoomOptions RO = new RoomOptions()
        {
            MaxPlayers = 2,
            IsOpen = true,
            IsVisible = true
        };
        PhotonNetwork.CreateRoom(null, RO);
        Debug.Log("JoinFailed");
        //test
        //PhotonNetwork.LoadLevel("Main");
    }
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        testito2.text = ("Enter");
        testito.text = PhotonNetwork.CurrentRoom.Name;
        Debug.Log(PhotonNetwork.CurrentRoom.Name);
        Debug.Log(PhotonNetwork.CurrentRoom.PlayerCount);
        if (PhotonNetwork.CurrentRoom.PlayerCount == 2 /*&& PhotonNetwork.IsMasterClient*/)
        {
            Debug.Log("Sucess");
            Connect.photonView.RPC("LevelL", RpcTarget.All);
        }
    }
    [PunRPC]
    public void LevelL()
    {
        Debug.Log("Load");
        PhotonNetwork.LoadLevel("Battle");
    }
    public void LeftRoon()
    {
        Debug.Log("Leave");
        PhotonNetwork.LeaveRoom();
    }

}
