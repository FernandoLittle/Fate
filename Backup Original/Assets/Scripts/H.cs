using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H : MonoBehaviour
{
    //Inteligência Artificial
    public List<G> a;
    public int b;
    public int c;
    public F f;
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
        b = Random.Range(0, 2);
        c = Random.Range(0,2);
        if (b == 0)
        {
            f.b5 = 1;
            f.b6 = 0;
        }
        if (b == 1)
        {
            f.b6 = 1;
            f.b5 = 0;
        }

        if (c== 0)
        {
            f.b7 = 1;
            f.b8 = 0;
        }

        if (c == 1)
        {
            f.b8 = 1;
            f.b7 = 0;
        }

        if (b == 0)
        {
            f.x5 = a[0].id;
            f.x6 = 0;
        }
        if (b == 1)
        {
            f.x6 = a[1].id;
            f.x5 = 0;
        }
        if (c == 0)
        {
            f.x7 = a[2].id;
            f.x8 = 0;
        }
        if (c == 1)
        {
            f.x7 =0;
            f.x8 = a[3].id;
        }
    }
}
