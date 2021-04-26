using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Fly : MonoBehaviourPunCallbacks
{
    public List<Transform> a;
    
    public static Fly Lyoko1 { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        if (Lyoko1 != null && Lyoko1 != this)
        {
            gameObject.SetActive(false);
            return;
        }
        Lyoko1 = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("a"))
        {
            Lyoko1.photonView.RPC("Move1", RpcTarget.All);
        }
        if (Input.GetKey("w"))
        {
            Lyoko1.photonView.RPC("Move2", RpcTarget.All);
        }
        if (Input.GetKey("d"))
        {
            Lyoko1.photonView.RPC("Move3", RpcTarget.All);
        }
        if (Input.GetKey("s"))
        {
            Lyoko1.photonView.RPC("Move4", RpcTarget.All);
        }
    }
    [PunRPC]
    public void Move1()
    {
        if (Scripto.Lyoko.x == 0)
        {
            Scripto.Lyoko.C();
            a[0].transform.position = new Vector3(a[0].transform.position.x - 2, a[0].transform.position.y, 0);
            Debug.Log("x");
        }
        else
        {
            Scripto.Lyoko.C();
            a[1].transform.position = new Vector3(a[1].transform.position.x - 2, a[1].transform.position.y, 0);
            Debug.Log("x");
        }

    }
    [PunRPC]
    public void Move2()
    {
        if (Scripto.Lyoko.x == 0)
        {
            a[0].transform.position = new Vector3(a[0].transform.position.x, a[0].transform.position.y + 2, 0);
            Scripto.Lyoko.TESTATR();
            Debug.Log("x");
        }
        else
        {
            a[1].transform.position = new Vector3(a[1].transform.position.x, a[1].transform.position.y + 2, 0);
            Debug.Log("x");
        }

    }
    [PunRPC]
    public void Move3()
    {
        if (Scripto.Lyoko.x == 0)
        {
            a[0].transform.position = new Vector3(a[0].transform.position.x + 2, a[0].transform.position.y, 0);
            Debug.Log("x");
        }
        else
        {
            a[1].transform.position = new Vector3(a[1].transform.position.x + 2, a[1].transform.position.y, 0);
            Debug.Log("x");
        }

    }
    [PunRPC]
    public void Move4()
    {
        if (Scripto.Lyoko.x == 0)
        {
            a[0].transform.position = new Vector3(a[0].transform.position.x, a[0].transform.position.y - 2, 0);
            Debug.Log("x");
        }
        else
        {
            a[1].transform.position = new Vector3(a[1].transform.position.x, a[1].transform.position.y - 2, 0);
            Debug.Log("x");
        }

    }
}
