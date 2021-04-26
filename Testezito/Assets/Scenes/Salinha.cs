using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class Salinha : MonoBehaviour
{
    public Text a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LetsPlay()
    {

        Scripto.Lyoko.Roon1();
        Debug.Log(a.text);
    }
    public void LetsPlay2()
    {
        //Scripto.Lyoko.Salinha2(a.text);
        Debug.Log(a.text);
    }
    public void LetsPlay3()
    {
        Scripto.Lyoko.x = 1;
        Scripto.Lyoko.photonView.RPC("Ceninha", RpcTarget.All,"Pimba");

    }
}
