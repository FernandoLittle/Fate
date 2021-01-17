using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class J : MonoBehaviour
{
    public List <Transform> a;
    public bool x;
    public bool y;
    public int idzone1;
    public Animator b;
    public List<GameObject> c;
    public List<Image> c1;
    public A d;
    public int d1;
    public List<B> Zone;
    public List<GameObject> Heart;
    public List<GameObject> Mold;
    public List<GameObject> MoldR;
    public Sprite BlueMold;
    public Sprite RedMold;
    public List <Image> MoldI;
    public List<GameObject> Dano;
    public List<Text> DanoT;
    public Q Q;
    public P P;
    public int id;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (y == false)
        {
            if (a[idzone1].transform.position.y - gameObject.transform.position.y < 0 )
            {

                transform.position = new Vector3(transform.position.x, transform.position.y - 2, transform.position.z);
                if (gameObject.transform.position.y - a[idzone1].transform.position.y < 2)
                {
                    transform.position = new Vector3(transform.position.x, a[idzone1].transform.position.y, transform.position.z);
                    y = true;
                    if (x == true)
                    {
                        b.Play("im1");
                    }

                }
            }
            else
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
                if (gameObject.transform.position.y - a[idzone1].transform.position.y > -2)
                {
                    transform.position = new Vector3(transform.position.x, a[idzone1].transform.position.y, transform.position.z);
                    y = true;
                    if (x == true)
                    {
                        b.Play("im1");
                    }

                }
            }
        }

        if (x == false)
        {
            if (a[idzone1].transform.position.x - gameObject.transform.position.x < 0)
            {
                transform.position = new Vector3(transform.position.x - 2, transform.position.y, transform.position.z);
                if (gameObject.transform.position.x - a[idzone1].transform.position.x < 2)
                {
                    transform.position = new Vector3(a[idzone1].transform.position.x, transform.position.y, transform.position.z);
                    x = true;
                    if (y == true)
                    {
                        b.Play("im1");
                    }
                }
            }
            else
            {
                transform.position = new Vector3(transform.position.x + 2, transform.position.y, transform.position.z);
                if (gameObject.transform.position.x - a[idzone1].transform.position.x > -2)
                {
                    transform.position = new Vector3(a[idzone1].transform.position.x, transform.position.y, transform.position.z);
                    x = true;
                    if (y == true)
                    {
                        b.Play("im1");
                    }
                }
            }
        }


    }
    public void A0()
    {
        c1[idzone1].enabled=false;
        Heart[idzone1].SetActive(false);
        Mold[idzone1].SetActive(false);
        MoldR[idzone1].SetActive(false);
        x = true;
        y = true;
    }
    public void A()
    {


        x = false;
        y = false;
    }
    public void B()
    {
        for (int x = 1; x < c1.Count; x = x+ 1)
        {
            if (Zone[x].idcard1 != 0)
            {
                Heart[x].SetActive(true);
            }
            else
            {
                Heart[x].SetActive(false);
            }
            if (Zone[x].side == 1)
            {
                MoldI[x].sprite = BlueMold;
                Mold[x].SetActive(true);
                MoldR[x].SetActive(false);
            }
            if (Zone[x].side == -1)
            {
                MoldI[x].sprite = RedMold;
                Mold[x].SetActive(true);
                MoldR[x].SetActive(false);
            }
            if (Zone[x].side == 0)
            {
                Mold[x].SetActive(false);
                MoldR[x].SetActive(false);
            }
            c1[x].enabled = true;
        }
        //Passive Teemo
        if (Zone[idzone1].Counter[3]>0)
        {
            d.SetEffectValue(11, idzone1, Zone[idzone1].Counter[3]);
            //Zone[idzone1].Lyoko[0] -= Zone[idzone1].Counter[3];
            //DanoT[idzone1].text = Zone[idzone1].Counter[3].ToString();
            //Q.DanoTA[idzone1].text = ("Life - ");
            //Dano[idzone1].SetActive(true);
            //P.A();
        }
        
        if (d.turn == d.end && d1 == 1)
        {
            d.B();
        }
        if (id == 2)
        {
            //Debug.Log("JKHK");
           d.Normalizator();
           Q.A();
        }



        gameObject.SetActive(false);
    }
}
