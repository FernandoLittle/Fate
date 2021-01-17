using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy1 : MonoBehaviour
{
    public GameObject a;
    public GameObject a1;
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
        a1.SetActive(true);
        a.SetActive(false);
    }
    public void DestroyB()
    {
        a.SetActive(false);
    }
}
