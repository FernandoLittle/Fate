using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class N : MonoBehaviour
{
    public I I;
    public Text T;
    public GameObject END;
    public GameObject End1;
    public GameObject End2;
    public GameObject End3;
    public int a;
    public Text Heart;
    public B Zone;
    public O o;
    public GameObject Cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void A()
    {
        if (a == 1)
        {
            if (I.life < 1)
            {
                Cam.SetActive(true);
                END.SetActive(true);
                End1.SetActive(true);
                End2.SetActive(false);
                End3.SetActive(true);
            }
        }
        if (a == 2)
        {
            Heart.text = Zone.Lyoko[0].ToString();
            //o.A();
            if (Zone.Lyoko[0] <= 0)
            {
                Zone.I();
            }

        }

        gameObject.SetActive(false);
    }
    public void B()
    {
        if (a == 1)
        {
            T.text = I.life.ToString();
        }
    }
}
