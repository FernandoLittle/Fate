using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Izanami : MonoBehaviour
{
    public List<AudioSource> ato;
    public List<AudioSource> ato2;
    public int a;
    public int b;
    public bool c;
    public int act;


    // Start is called before the  first frame update
    void Start()
    {
        a = 0;
        b = 1;
        ato[a].Play();
        ato2[a].Play();
        c = false;
        act = 0;
        //a[2].Play();
    }

    // Update is called once per frame
    void FixedUpdate()
    {




        
        if (!ato[a].isPlaying)
        {
            if (c == false||act!=2)
            {
                if (b == 0)
                {
                    act = 0;
                }
                if (b == 1||b==2||b==3||b==4||b==5)
                {
                    act = 1;
                }
                if (b == 6
                    )
                {
                    act = 3;
                }
                ato[b].Play();
                ato2[b].Play();
                a = b;
                b += 1;
                if (b == 6)
                {
                    b = 1;
                }

            }
            else
            {

                c = false;
                if (act == 2)
                {
                    ato[6].Play();
                    ato2[6].Play();
                    act = 3;
                    a = 6;
                    b = 0;
                }
            }
        }
    }
    public void A()
    {
        c = true;
        act += 1;
    }
}
