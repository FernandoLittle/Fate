using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
public class card : MonoBehaviourPunCallbacks
{
    public Calculus Calculus;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Pedra()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            Calculus.Choose(0, 1);
            
        }
        else
        {
            Calculus.photonView.RPC("Choose", RpcTarget.MasterClient,1,1);
        }
    }
    public void Tesoura()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            Calculus.Choose(0, 2);
        }
        else
        {
            Calculus.photonView.RPC("Choose", RpcTarget.MasterClient, 1, 2);
        }
    }
    public void Papel()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            Calculus.Choose(0, 3);

        }
        else
        {
            Calculus.photonView.RPC("Choose", RpcTarget.MasterClient, 1, 3);
        }

    }

}
