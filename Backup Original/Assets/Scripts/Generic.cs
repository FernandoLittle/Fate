using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Generic : MonoBehaviour
{
    public List<GameObject> b;
    public float a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public int Module(int a)
    {
        if (a < 0)
        {
            return a * -1;
        }
        else
        {
            return a;
        }
        
    }
    public int Smaller(int a, int b)
    {
        if (a > b)
        {
            return b;
        }
        else
        {
            return a;
        }
    }
   
}
