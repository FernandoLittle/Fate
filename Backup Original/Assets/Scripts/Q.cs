using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q : MonoBehaviour
{
    public List<int> a;
    public int b;
    public List<GameObject> Dano;
    public List<Text> DanoT;
    public List<GameObject> Up;
    public List<Text> UpT;
    public List<Text> UPTA;
    public List<Text> DanoTA;
    public List<int> idzone1;
    public GameObject Joker;
    public Image JokerI;
    public List<Sprite> c;
    public int e;
    public O o;
    public bool IA;
    public List<int> Value;
    public List<B> Zone;
    public E move;
    public GameObject Disable;
    public A AA;
    // Start of turn effects

    public void A()
    {
        if (a.Count > b)
        {
            AA.DisableA(true);
            //The "a" list has the effects id. The "idzone" list has the target of the effects. A lista "Value" possui o valor do modificador.

            if (a[b] == 0)
            {
                DanoT[idzone1[b]].text = Value[b].ToString();
                Dano[idzone1[b]].SetActive(true);
                DanoTA[idzone1[b]].text = ("Life - ");
                Joker.SetActive(false);
                Joker.SetActive(true);
                JokerI.sprite = c[0];
                Zone[idzone1[b]].Lyoko[0] -= Value[b];
            }
            if (a[b] == 1)
            {
                UpT[idzone1[b]].text = Value[b].ToString();
                UPTA[idzone1[b]].text = ("Attack + ");
                Up[idzone1[b]].SetActive(true);
                Joker.SetActive(false);
                Joker.SetActive(true);
                JokerI.sprite = c[1];
            }
            if (a[b] == 2)
            {
                DanoT[idzone1[b]].text = Value[b].ToString();
                Dano[idzone1[b]].SetActive(true);
                DanoTA[idzone1[b]].text = ("Life - ");
                Joker.SetActive(false);
                Joker.SetActive(true);
                JokerI.sprite = c[2];
            }
            if (a[b] == 3)
            {
                UpT[idzone1[b]].text = Value[b].ToString();
                Up[idzone1[b]].SetActive(true);
                UPTA[idzone1[b]].text = ("Life + ");
                Joker.SetActive(false);
                Joker.SetActive(true);
                JokerI.sprite = c[2];
            }
            if (a[b] == 4)
            {

                DanoT[idzone1[b]].text = Value[b].ToString();
                Dano[idzone1[b]].SetActive(true);
                DanoTA[idzone1[b]].text = ("Mana - ");
                Joker.SetActive(false);
                Joker.SetActive(true);
                JokerI.sprite = c[0];
            }
            if (a[b] == 5)
            {
                UpT[idzone1[b]].text = Value[b].ToString();
                Up[idzone1[b]].SetActive(true);
                UPTA[idzone1[b]].text = ("Defense + ");
                Joker.SetActive(false);
                Joker.SetActive(true);
                JokerI.sprite = c[3];
            }
            if (a[b] == 6)
            {
                DanoT[idzone1[b]].text = Value[b].ToString();
                Dano[idzone1[b]].SetActive(true);
                DanoTA[idzone1[b]].text = ("Life - ");
                Joker.SetActive(false);
                Joker.SetActive(true);
                JokerI.sprite = c[4];
            }
            if (a[b] == 7)
            {
                UpT[idzone1[b]].text = Value[b].ToString();
                Up[idzone1[b]].SetActive(true);
                UPTA[idzone1[b]].text = ("Life + ");
                Joker.SetActive(false);
                Joker.SetActive(true);
                JokerI.sprite = c[5];
            }
            if (a[b] == 8)
            {
                DanoT[idzone1[b]].text = Value[b].ToString();
                Dano[idzone1[b]].SetActive(true);
                DanoTA[idzone1[b]].text = ("Life - ");
                Joker.SetActive(false);
                Joker.SetActive(true);
                JokerI.sprite = c[7];
                AA.i[0].life -= Value[b];
            }
            if (a[b] == 9)//LeeAR
            {
                DanoT[idzone1[b]].text = Value[b].ToString();
                Dano[idzone1[b]].SetActive(true);
                DanoTA[idzone1[b]].text = ("Life - ");
                Joker.SetActive(false);
                Joker.SetActive(true);
                JokerI.sprite = c[7];
                AA.i[1].life -= Value[b];
            }
            if (a[b] == 10)//LeeAR
            {
                DanoT[idzone1[b]].text = Value[b].ToString();
                Dano[idzone1[b]].SetActive(true);
                DanoTA[idzone1[b]].text = ("Life - ");
                Joker.SetActive(false);
                Joker.SetActive(true);
                JokerI.sprite = c[6];
                AA.i[1].life -= Value[b];
            }
            //TeemoPassive
            if (a[b] == 11)
            {
                DanoT[idzone1[b]].text = Value[b].ToString();
                Dano[idzone1[b]].SetActive(true);
                DanoTA[idzone1[b]].text = ("Life - ");
                Joker.SetActive(false);
                Joker.SetActive(true);
                JokerI.sprite = c[8];
                Zone[idzone1[b]].Lyoko[0] -= Value[b];
            }
            b += 1;
        }
        else
        {
            a.Clear();
            idzone1.Clear();
            Value.Clear();
            move.IAbool = false;
            o.A();
            b = 0;
            if (IA == true)
            {
                o.a *= -1;

                IA = false;
            }
            Joker.SetActive(false);
            if (AA.offline == true)
            {
                if (o.NexusE.id * o.NexusE.side >= 0)
                {
                    AA.DisableA(false);
                }
            }
            else
            {
                if (AA.Atacante == true)
                {
                    AA.DisableA(false);
                }
            }

            
        }
        
    }
}
