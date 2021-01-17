using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject Speak;
    public TutorialT T;
    public GameObject All;
    public int tf;
    public List<int> delete;
    public Animator background;
    public GameObject Scheme;
    public Animator Ignite;
    public Animator Ghost;
    public Animator Block;
    public Animator Flash;
    public Animator Arrow1;
    public Animator Arrow2;
    public Animator Arrow3;
    public Animator Arrow4;
    public Animator Attack;
    public Animator Defense;
    public Animator Life;
    public Animator Energy;
    public Animator Speed;
    public Animator Mana;
    public Animator Power;
    public Animator Scale;
    public Animator Equal;
    public Animator Mult;
    public GameObject Atr;
    public Tutorial t;
    public GameObject YesNo;
    public Tutorial Tbutton;
    public int ax;


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
        Speak.SetActive(true);
    }
    public void B()
    {


        if (T.Tutorial1.text.Length == T.TutorialEN[T.x].Speak[T.Textn].Length)
        {
            if (T.x == 3 && T.Textn == 5)
            {
                Atr.SetActive(false);


            }
            T.Tutorial1.text = "";
            T.Charn = 0;
            T.Textn += 1;
            //Spell Tutorial
            if (T.x == 3 && T.Textn == 1)
            {
                Atr.SetActive(true);                
                Defense.Play("ninja");
                Life.Play("ninja");
                Energy.Play("ninja");
                Speed.Play("ninja");

            }
            if (T.x == 3 && T.Textn == 2)
            {
                Attack.Play("Spectral1");
                Defense.Play("Spectral2");

            }
            if (T.x == 3 && T.Textn == 3)
            {
                Life.Play("Spectral2");
                Defense.Play("Spectral1");

            }
            if (T.x == 3 && T.Textn == 4)
            {
                Life.Play("Spectral1");
                Speed.Play("Spectral2");

            }
            if (T.x == 3 && T.Textn == 5)
            {
                Energy.Play("Spectral2");
                Speed.Play("Spectral1");

            }
            if (T.x == 1 && T.Textn == 1)
            {
                Scheme.SetActive(true);
                Power.Play("Spectral2");
            }
            if (T.x == 1 && T.Textn == 2)
            {
                /* Ghost.Play("Spectral1");
                 Block.Play("Spectral1");
                 Flash.Play("Spectral1");
                 Arrow1.Play("Spectral1");
                 Arrow2.Play("Spectral1");
                 Arrow3.Play("Spectral1");
                 Arrow4.Play("Spectral1");*/
                Power.Play("Spectral1");
                Scale.Play("Spectral2");
            }
            if (T.x == 1 && T.Textn == 3)
            {
                Scale.Play("Spectral1");
                Mana.Play("Spectral2");
                /*   Ignite.Play("Spectral1");
                   Ghost.Play("Spectral2");*/

            }
            if (T.x == 1 && T.Textn == 4)
            {
                Power.Play("Spectral2");
                Scale.Play("Spectral2");
                Equal.Play("SpectralText");
                Mult.Play("SpectralText");
                /* Ghost.Play("Spectral1");
                 Flash.Play("Spectral2");*/
            }
            if (T.x == 1 && T.Textn == 5)
            {
                Power.Play("Spectral1");
                Scale.Play("Spectral1");
                Equal.Play("SpectralText0");
                Mult.Play("SpectralText0");
                Mana.Play("Spectral1");
                /* Flash.Play("Spectral1");
                 Block.Play("Spectral2");*/
            }
            if (T.x == 1 && T.Textn == 6)
            {
                /*Block.Play("Spectral1");*/
            }
            if (T.x == 1 && T.Textn == 7)
            {
               /* Block.Play("Spectral2");
                Arrow2.Play("Spectral2");
                Ghost.Play("Spectral2");*/
            }
            if (T.x == 1 && T.Textn == 8)
            {
               /* Block.Play("Spectral1");
                Arrow2.Play("Spectral1");
                Arrow3.Play("Spectral2");
                Flash.Play("Spectral2");*/
            }
            if (T.x == 1 && T.Textn == 9)
            {
              /*  Arrow3.Play("Spectral1");
                Ghost.Play("Spectral1");
                Arrow4.Play("Spectral2");
                Ignite.Play("Spectral2");*/
            }
            if (T.x == 1 && T.Textn == 10)
            {
               /* Flash.Play("Spectral1");
                Arrow4.Play("Spectral1");
                Arrow1.Play("Spectral2");
                Block.Play("Spectral2");*/
            }
            if (T.x == 1 && T.Textn == 11)
            {
              /*  Arrow1.Play("Spectral1");
                Block.Play("Spectral1");
                Ignite.Play("Spectral1");*/
            }
            if (T.x == 1 && T.Textn == 12)
            {
                Scheme.SetActive(false);
            }
            if (T.Textn == T.TutorialEN[T.x].Speak.Count)
            {
                background.Play("Background2");
                All.SetActive(false);
            }
            else
            {
                T.b = true;
            }

        }
        else
        {
            T.b = false;
            T.Tutorial1.text = T.TutorialEN[T.x].Speak[T.Textn];
        }

    }
    public void C(int o)
    {
        for (int x = 0; x < delete.Count; x = x + 1)
        {
            if (delete[x] == o)
            {
                All.SetActive(false);
            }
        }
        delete.Add(o);
        T.x = o;
        T.b = true;
        T.Textn = 0;
        T.Charn = 0;
    }
    public void YES()
    {
        t.tf = 0;
        background.Play("Background2");
        All.SetActive(false);
    }
    public void NO()
    {
        Tbutton.B();
        YesNo.SetActive(false);
    }
}
