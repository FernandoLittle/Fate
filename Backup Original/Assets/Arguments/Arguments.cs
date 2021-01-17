using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Arguments : MonoBehaviour
{
    public List<Sprite> Spritos;
    public GameObject b1;
    public GameObject b2;
    public Image Imago1;
    public Image Imago2;
    public int a;
    // Start is called before the first frame update
    void Start()
    {
        a = -1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void A()
    {
        a += 1;
        if (a == 1)
        {
            b2.SetActive(true);
        }


        if (a == 4)
        {
            b1.SetActive(false);
        }
        Imago1.sprite = Spritos[a];
        Imago2.sprite = Spritos[a];
    }
    public void B()
    {
        a -= 1;
        b1.SetActive(true);
        if (a == 0)
        {
            b2.SetActive(false);
        }
        Imago1.sprite = Spritos[a];
        Imago2.sprite = Spritos[a];
    }
}
