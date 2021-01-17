using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class K : MonoBehaviour
{
    public List <GameObject> a;
    public List<B> b;
    public A c;
    public int x;
    public List<Animator> d;
    public List<GameObject> all;
    public GameObject i1;
    public GameObject i2;
    public O o;
    public int e;
    public List<B> Zone;
    public int f;
    public Q q;
    public D DD;

    //Tutorial background
    public int g;
    public Image Rift;
    public Sprite Rift1;
    public Tutorial Tuto;
    public GameObject Tuto1;
    public int tutorial;
    public int t;
    public List<GameObject> FantasyObjects;
    public GameObject FantasyDark;
    public GameObject Eye;
    public Round Round;
    public List<RectTransform> Size;
    public List<RectTransform> SizeM;
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
        for (int x = 1; x < 11; x = x + 1)
        {
            b[x].anime.Play("Normal");
        }
            a[0].SetActive(true);
        a[1].SetActive(true);
        a[2].SetActive(false);
        a[3].SetActive(false);

    }
    public void B()
    {
        
        if (f == 1)
        {
            Round.A();
            for (int x = 1; x < 11; x = x + 1)
            {
                if (Zone[x].Lyoko[0] <= 0)
                {
                    Zone[x].I();
                }


            }
        }
        if (e == 1)
        {
            if (q.a.Count == 0)
            {
                G();

            }
            else
            {
                q.IA = true;
                q.A();
                q.e = e;
            }
        }


      

        a[0].SetActive(false);
        a[1].SetActive(false);
       
    }
    public void C()
    {
        for (int x = 1; x < 11; x = x + 1)
        {
            b[x].anime.Play("Normal");
        }

    }
    public void D()
    {

        
        a[0].SetActive(true);
        a[1].SetActive(true);
        a[2].SetActive(false);
    }
    public void D1()
    {
        Eye.SetActive(false);
        FantasyDark.SetActive(false);
        for (int x = 0; x < FantasyObjects.Count; x = x + 1)
        {
            FantasyObjects[x].SetActive(false);
        }
        for (int x = 0; x < all.Count; x = x + 1)
        {
            all[x].SetActive(true);
        }
        for (int x = 0; x < d.Count; x = x + 1)
        {
            d[x].Play("Normal");
        }
        i1.SetActive(true);
        i2.SetActive(true);
    }
    public void E()
    {
        c.x1 = x;
        c.C();
    }
    public void F()
    {
        gameObject.SetActive(false);
    }
    public void G()
    {


    }
    public void H()
    {
        if (g == 1)
        {
            Rift.sprite = Rift1;
        }
    }
    //Tutorial
    public void I()
    {

        o.A();
        /*
        if (o.a == 1)
        {

            if (Tuto.tf == 1)
            {


                if (tutorial == 4)
                {
                 
                    Tuto1.SetActive(true);
                    Tuto.C(4);
                    tutorial = 0;
                }

                else
                {


                    if (t > 0)
                    {
                        Tuto1.SetActive(true);
                        Tuto.C(3);
                        t = -10;
                    }
                    if (t == 0)
                    {
                        Tuto1.SetActive(true);
                        Tuto.C(7);
                        t += 1;
                    }


                }




            }
        }
        */
    }
    public void Normalizator()
    {
        c.Normalizator();
        Size[0].transform.localPosition = new Vector3(-258.7f, 377, 0);
        Size[1].transform.localPosition = new Vector3(-177.4f, 377.4f, 0);
        Size[2].transform.localPosition = new Vector3(-258.8f, 68, 0);
        Size[3].transform.localPosition = new Vector3(-177.6f, 67.5f, 0);
        Size[4].transform.localPosition = new Vector3(235.4f, 401, 0);
        Size[5].transform.localPosition = new Vector3(316.1f, 401, 0);
        Size[6].transform.localPosition = new Vector3(235.2f, 90.6f, 0);
        Size[7].transform.localPosition = new Vector3(316.4f, 90.6f, 0);
        for (int x = 0; x < 8; x = x + 1)
        {
            Size[x].sizeDelta = new Vector2(63.7f, 92.9f);
            Size[x].localScale = new Vector3(1, 1, 1);
            Size[x].transform.rotation = new Quaternion(0, 0, 0, 0);
            SizeM[x].sizeDelta = new Vector2(63.7f, 92.9f);
            SizeM[x].localScale = new Vector3(1, 1.05f, 1);
        }
    }
}
