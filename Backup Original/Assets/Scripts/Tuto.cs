using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuto : MonoBehaviour
{
    public int a;
    public Tutorial Tutor;
    public GameObject Tuto1;
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
            if (Tutor.tf == 1)
            {
                Tuto1.SetActive(true);
                Tutor.C(6);
            }
        }

    }
}
