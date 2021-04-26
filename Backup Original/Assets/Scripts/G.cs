using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class G : MonoBehaviour
{
    public int id;
    public F f;
    public GameObject il;
    public Image il1;
    public GameObject il2;
    public Image Zonesprite0;
    public D d;
    public int id1;
    public Text t0;

    public List<GameObject> t;
    public Animator anime;
    public int e;
    public GameObject h;
    public Image Fantasy;
    public Combat Combat;
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
        f.x1 = id;
        f.x2 = 0;
        f.x3 = 0;
        f.x4 = 0;
        f.b1 = 1;
        f.b2 = 0;
        f.b3 = 0;
        f.b4 = 0;
        d.SkillId = 1;
        d.CardSelect();
        Fantasy.sprite = Zonesprite0.sprite;
        Combat.SkillIDA= id1;
    }
    public void B()
    {
        f.x2 = id;
        f.x1 = 0;
        f.x3 = 0;
        f.x4 = 0;

        f.b2 = 1;
        f.b1 = 0;
        f.b3 = 0;
        f.b4 = 0;
        d.SkillId = 2;
        d.CardSelect();
        Fantasy.sprite = Zonesprite0.sprite;
        Combat.SkillIDA = id1;

    }
    public void C()
    {
        f.x3 = id;
        f.x4 = 0;
        f.x1 = 0;
        f.x2 = 0;
        f.b1 = 0;
        f.b2 = 0;
        f.b3 = 1;
        f.b4 = 0;
        d.SkillId = 3;
        d.CardSelect();
        Fantasy.sprite = Zonesprite0.sprite;
        Combat.SkillIDA = id1;
    }
    public void D()
    {
        f.x4 = id;
        f.x3 = 0;
        f.x1 = 0;
        f.x2 = 0;
        f.b2 = 0;
        f.b1 = 0;
        f.b4 = 1;
        f.b3 = 0;
        d.SkillId = 4;
        d.CardSelect();
        Fantasy.sprite = Zonesprite0.sprite;
        Combat.SkillIDA = id1;
    }
    public void E()
    {

        Debug.Log("PA");
            il.SetActive(true);
            il1.sprite = Zonesprite0.sprite;
        il2.SetActive(false);
        if (id1 == 1)
        {
            t0.text = d.AttackS[id].Texto0;

        }
        if (id1 == 2)
        {
            t0.text = d.AttackQ[id].Texto0;

        }
        if (id1 == 3)
        {
            t0.text = d.Block[id].Texto0;

        }
        if (id1 == 4)
        {
            t0.text = d.Dodge[id].Texto0;

        }

        t[0].SetActive(true);
        t[1].SetActive(false);
        t[2].SetActive(false);
        t[3].SetActive(false);
        t[4].SetActive(false);



    }
    public void F()
    {
        il.SetActive(false);
    }
    public void A1()
    {
        if (e == 1)
        {
            anime.Play("A1B");
        }
        if (e == 0)
        {
            anime.Play("A1E");
        }
    }
    public void A2()
    {
        if (e == 0)
        {
            anime.Play("A2B");
        }
        if (e == 1)
        {
            anime.Play("A2E");
        }
    }
    public void A3()
    {
        if (e == 0)
        {
            anime.Play("B1Fx");
        }
        if (e == 1)
        {
            anime.Play("B1Rx");
        }
    }
    public void A4()
    {
        if (e == 0)
        {
            anime.Play("B2Rx");
        }
        if (e == 1)
        {
            anime.Play("B2Fx");
        }
    }
    public void A5()
    {
        if (e == 0)
        {
            anime.Play("A1Ex");
        }
        if (e == 1)
        {
            anime.Play("A1Bx");
        }
    }
    public void A6()
    {
        if (e == 0)
        {
            anime.Play("A2Bx");
        }
        if (e == 1)
        {
            anime.Play("A2Ex");
        }
    }
    public void A7()
    {
        if (e == 0)
        {
            anime.Play("B1F");
        }
        if (e == 1)
        {
            anime.Play("B1R");
        }
    }
    public void A8()
    {
        if (e == 0)
        {
            anime.Play("B2R");
        }
        if (e == 1)
        {
            anime.Play("B2F");
        }
    }
    public void A9()
    {
        d.E();
    }
    public void H()
    {
        h.SetActive(false);
    }
    public void I()
    {
        f.B();
    }
    public void I1()
    {
        f.E();
    }
    public void Anime1()
    {
        if (Combat.Win == 0)
        {
            anime.Play("A1B");
        }
        else
        {
            anime.Play("A1E");
        }
    }
    public void Anime2()
    {
        if (Combat.Win == 0)
        {
            anime.Play("A2E");
        }
        else
        {
            anime.Play("A2B");
        }
    }
    public void Anime3()
    {
        if (Combat.Win == 0)
        {
            anime.Play("B1Rx");
        }
        else
        {
            anime.Play("B1Fx");
        }
    }
    public void Anime4()
    {
        if (Combat.Win == 0)
        {
            anime.Play("B2Fx");
        }
        else
        {
            anime.Play("B2Rx");
        }
    }
    public void Anime5()
    {
        if (Combat.Win == 0)
        {
            anime.Play("A1Ex");
        }
        else
        {
            anime.Play("A1Bx");
        }
    }
    public void Anime6()
    {
        if (Combat.Win == 0)
        {
            anime.Play("A2Bx");
        }
        else
        {
            anime.Play("A2Ex");
        }

    }
    public void Anime7()
    {
        if (Combat.Win == 0)
        {
            anime.Play("B1F");
        }
        else
        {
            anime.Play("B1R");
        }
    }
    public void Anime8()
    {
        if (Combat.Win == 0)
        {
            anime.Play("B2R");
        }
        else
        {
            anime.Play("B2F");
        }
    }
}
