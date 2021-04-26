using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using Photon.Realtime;

public class Scripto : MonoBehaviourPunCallbacks
{
    public static Scripto Lyoko { get;  private set; }
    public int Room;
    public int BusyRoom;
    public bool InRoom;
    public int x;
    private Player playo;
    public int id;
    private void Awake()
    {
        if(Lyoko!=null && Lyoko != this)
        {
            gameObject.SetActive(false);
            return;
        }
        Lyoko = this;
        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {

        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("Um ABRAÇO ERMÃO");
    }

    public void Roon1()
    {

        PhotonNetwork.JoinRandomRoom();
        Debug.Log("Entrei!");

    }
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Roon2();
    }
    public void Roon2()
    {
        RoomOptions rp =
        new RoomOptions()
        {
            IsVisible = true,
            IsOpen = true,
            MaxPlayers = 2
        };

        
        PhotonNetwork.CreateRoom(null, rp);
        Debug.Log("Criei!");
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        if(PhotonNetwork.CurrentRoom.PlayerCount==2 && PhotonNetwork.IsMasterClient)
        {
            photonView.RPC("Ceninha", RpcTarget.All, "Pimba");
        }
    }




    public override void OnCreatedRoom()
    {
        Debug.Log("Pimba");
    }
    public override void OnJoinedRoom()
    {
        Debug.Log("Entrei");
    }
    [PunRPC]
    public void Ceninha(string a)
    {
        PhotonNetwork.LoadLevel(a);
        Debug.Log("LOAD");

    }
    
    public void C()
    {
        playo = PhotonNetwork.LocalPlayer;
        id = playo.ActorNumber;
        Debug.Log(id);
    }
    public void TESTATR()
    {
        if (PhotonNetwork.PlayerList[0].ActorNumber == PhotonNetwork.LocalPlayer.ActorNumber)
        {
            Debug.Log("MEU PAU TA FURRIOSO");
        }
        Debug.Log(PhotonNetwork.PlayerList[0]);
    }

}
