using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class B : MonoBehaviour
{
    public int idcard1;
    public int idcard2;
    public int idzone1;
    public int idzone2;
    public int idzone3;
    public int select;
    //Zonas próximas
    public List <int> idzone0;
    public List<B> Zone;
    public List<Image> Zonesprite;
    public Image Zonesprite0;
    public Image Zonesprite1;
    public List<Button> b;
    public A a;
    public E e;
    public E e1;
    public E e2;
    public E e3;
    public GameObject Move;
    public GameObject Cancel;
    public GameObject Study;
    public GameObject Pass;
    public int up;
    //Atributos
    public List<int> Lyoko;
    //Contadores Permanentes
    public List<int> Lyoko1;
    //Atributos Base
    public List<int> Lyoko2;
    public F f;
    public Animator anime;
    public List<GameObject> flash;

    //Variáveis de Evolução
    public int idPersonagem;
    public int lv;
    public int lv1;


    //Zonas Próximas
    public List<int> zp;
    //Ilustração
    public GameObject il;
    public Image il1;
    //Lista de Status
    //Code[5]Cannot be targeted
    //Code[7]DrainLife
    //Code[6]Pact
    //Code[8]Spear
    //Code[11]Ambush1
    public List<bool> Code;
    
    //Counter[5]=Poison
    public List<int> Counter;
    public List <GameObject> Blue;
    public O O;
    // Ally=1 Enemy=-1
    public int side;
    public Sprite nada;
    public List<I> i;
    public List <GameObject> Damage;
    public List <Text> DamageT;
    public bool Spear;
    public D d;
    //Current Mana.
    public int Mana;
    //Original Mana
    public int Mana1;
    //Permanent Mana Bonus
    public int Mana2;
    public int ManaSpend;


    // Start is called before the first frame update
    void Start()
    {


        PlayerPrefs.SetInt("A", 0);
        PlayerPrefs.SetInt("B", 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void X()
    {
        a.Eye.SetActive(false);
        idcard2 = PlayerPrefs.GetInt("A");
        idzone2 = PlayerPrefs.GetInt("B");
        idzone3 = PlayerPrefs.GetInt("C");
        

        //Se selecionar card já selecionado
        if (idzone2 == idzone1)
        {
            PlayerPrefs.SetInt("A", 0);
            PlayerPrefs.SetInt("B", 0);
            for (int x = 1; x < 11; x = x + 1)
            {
                if (Zone[x].idcard1 <= 0 || Zone[x].Code[2]==true)
                {
                    b[x].enabled = false;
                }
                else
                {
                    b[x].enabled = true;
                }
            }
            Study.SetActive(false);
            Cancel.SetActive(false);
}
        //Se sem seleção
        if (idzone2 == 0)
        {
            anime.Play("a");
            select = 1;
            //Memoriza os atributos da zona
            A0();
            //Define quais zonas podem ser selecionadas
            if (idzone1 == 1)
            {
                b[7].enabled = true;
                b[6].enabled = true;
                b[2].enabled = true;
                b[5].enabled = true;


                b[1].enabled = false;
                b[3].enabled = false;
                b[4].enabled = false;
                b[8].enabled = false;
                b[9].enabled = false;
                b[10].enabled = false;

                Blue[7].SetActive(true);
                Blue[6].SetActive(true);
                Blue[2].SetActive(true);
                Blue[5].SetActive(true);

                Blue[1].SetActive(false);
                Blue[3].SetActive(false);
                Blue[4].SetActive(false);
                Blue[8].SetActive(false);
                Blue[9].SetActive(false);
                Blue[10].SetActive(false);



                    a.ib[0].enabled = true;
                    Blue[11].SetActive(true);
                
            }
            if (idzone1 == 2)
            {                
                b[6].enabled = true;
                b[1].enabled = true;
                b[5].enabled = true;                
                b[4].enabled = true;
                b[3].enabled = true;

                b[2].enabled = false;
                b[7].enabled = false;
                b[8].enabled = false;
                b[9].enabled = false;
                b[10].enabled = false;

                Blue[6].SetActive(true);
                Blue[1].SetActive(true);
                Blue[5].SetActive(true);
                Blue[4].SetActive(true);
                Blue[2].SetActive(true);

                Blue[2].SetActive(false);
                Blue[7].SetActive(false);
                Blue[8].SetActive(false);
                Blue[9].SetActive(false);
                Blue[10].SetActive(false);
                Blue[11].SetActive(true);


                    a.ib[0].enabled = true;
                    Blue[11].SetActive(true);
                
               

            }
            if (idzone1 == 3)
            {

                b[8].enabled = true;
                b[4].enabled = true;
                b[2].enabled = true;
                b[5].enabled = true;

                b[3].enabled = false;
                b[1].enabled = false;
                b[6].enabled = false;
                b[7].enabled = false;
                b[9].enabled = false;
                b[10].enabled = false;

                Blue[8].SetActive(true);
                Blue[4].SetActive(true);
                Blue[2].SetActive(true);
                Blue[5].SetActive(true);

                Blue[3].SetActive(false);
                Blue[1].SetActive(false);
                Blue[6].SetActive(false);
                Blue[7].SetActive(false);
                Blue[9].SetActive(false);
                Blue[10].SetActive(false);
                Blue[11].SetActive(true);

                    a.ib[0].enabled = true;
                    Blue[11].SetActive(true);
                

            }
            if (idzone1 == 4)
            {
                b[9].enabled = true;
                b[3].enabled = true;
                b[5].enabled = true;
                b[2].enabled = true;

                b[4].enabled = false;
                b[1].enabled = false;
                b[6].enabled = false;
                b[7].enabled = false;
                b[8].enabled = false;
                b[10].enabled = false;

                Blue[9].SetActive(true);
                Blue[3].SetActive(true);
                Blue[5].SetActive(true);
                Blue[2].SetActive(true);

                Blue[4].SetActive(false);
                Blue[1].SetActive(false);
                Blue[6].SetActive(false);
                Blue[7].SetActive(false);
                Blue[8].SetActive(false);
                Blue[10].SetActive(false);
                if (a.i[1].id * Zone[4].idcard1 < 0)
                {
                    a.ib[1].enabled = true;
                }
            }
            if (idzone1 == 5)
            {
                
                b[3].enabled = true;
                b[4].enabled = true;
                b[2].enabled = true;                
                b[1].enabled = true;
                b[6].enabled = true;

                b[5].enabled = false;
                b[7].enabled = false;
                b[8].enabled = false;
                b[9].enabled = false;
                b[10].enabled = false;

                Blue[3].SetActive(true);
                Blue[4].SetActive(true);
                Blue[2].SetActive(true);
                Blue[1].SetActive(true);
                Blue[6].SetActive(true);

                Blue[5].SetActive(false);
                Blue[7].SetActive(false);
                Blue[8].SetActive(false);
                Blue[9].SetActive(false);
                Blue[10].SetActive(false);


                if (a.i[1].id * Zone[5].idcard1 < 0)
                {
                    a.ib[1].enabled = true;
                }

            }
            if (idzone1 == 6)
            {
                b[10].enabled = true;
                b[1].enabled = true;
                b[5].enabled = true;
                b[2].enabled = true;

                b[3].enabled = false;
                b[4].enabled = false;
                b[6].enabled = false;
                b[7].enabled = false;
                b[8].enabled = false;
                b[9].enabled = false;

                Blue[10].SetActive(true);
                Blue[1].SetActive(true);
                Blue[5].SetActive(true);
                Blue[2].SetActive(true);

                Blue[3].SetActive(false);
                Blue[4].SetActive(false);
                Blue[6].SetActive(false);
                Blue[7].SetActive(false);
                Blue[8].SetActive(false);
                Blue[9].SetActive(false);
                if (a.i[1].id * Zone[6].idcard1 < 0)
                {
                    a.ib[1].enabled = true;
                }
            }
            if (idzone1 == 7)
            {
                b[1].enabled = true;
                b[2].enabled = true;

                b[3].enabled = false;
                b[4].enabled = false;
                b[5].enabled = false;
                b[6].enabled = false;
                b[7].enabled = false;
                b[8].enabled = false;
                b[9].enabled = false;
                b[10].enabled = false;


                Blue[1].SetActive(true);
                Blue[2].SetActive(true);

                Blue[3].SetActive(false);
                Blue[4].SetActive(false);
                Blue[5].SetActive(false);
                Blue[6].SetActive(false);
                Blue[7].SetActive(false);
                Blue[8].SetActive(false);
                Blue[9].SetActive(false);
                Blue[10].SetActive(false);
                Blue[11].SetActive(true);

                    a.ib[0].enabled = true;
                    Blue[11].SetActive(true);
                

            }
            if (idzone1 == 8)
            {
                b[2].enabled = true;
                b[3].enabled = true;

                b[1].enabled = false;
                b[4].enabled = false;
                b[5].enabled = false;
                b[6].enabled = false;
                b[7].enabled = false;
                b[8].enabled = false;
                b[9].enabled = false;
                b[10].enabled = false;


                Blue[2].SetActive(true);
                Blue[3].SetActive(true);

                Blue[1].SetActive(false);
                Blue[4].SetActive(false);
                Blue[5].SetActive(false);
                Blue[6].SetActive(false);
                Blue[7].SetActive(false);
                Blue[8].SetActive(false);
                Blue[9].SetActive(false);
                Blue[10].SetActive(false);
                Blue[11].SetActive(true);
   
                    a.ib[0].enabled = true;
                    Blue[11].SetActive(true);
                

            }
            if (idzone1 == 9)
            {
                b[4].enabled = true;
                b[5].enabled = true;

                b[1].enabled = false;
                b[2].enabled = false;
                b[3].enabled = false;
                b[6].enabled = false;
                b[7].enabled = false;
                b[8].enabled = false;
                b[9].enabled = false;
                b[10].enabled = false;

                Blue[4].SetActive(true);
                Blue[5].SetActive(true);

                Blue[1].SetActive(false);
                Blue[2].SetActive(false);
                Blue[3].SetActive(false);
                Blue[6].SetActive(false);
                Blue[7].SetActive(false);
                Blue[8].SetActive(false);
                Blue[9].SetActive(false);
                Blue[10].SetActive(false);
                if (a.i[1].id * Zone[9].idcard1 < 0)
                {
                    a.ib[1].enabled = true;
                }
            }
            if (idzone1 == 10)
            {
                b[5].enabled = true;
                b[6].enabled = true;

                b[1].enabled = false;
                b[2].enabled = false;
                b[3].enabled = false;
                b[4].enabled = false;
                b[7].enabled = false;
                b[8].enabled = false;
                b[9].enabled = false;
                b[10].enabled = false;

                Blue[5].SetActive(true);
                Blue[6].SetActive(true);

                Blue[1].SetActive(false);
                Blue[2].SetActive(false);
                Blue[3].SetActive(false);
                Blue[4].SetActive(false);
                Blue[7].SetActive(false);
                Blue[8].SetActive(false);
                Blue[9].SetActive(false);
                Blue[10].SetActive(false);
                if (a.i[1].id * Zone[10].idcard1 < 0)
                {
                    a.ib[1].enabled = true;
                }
            }
           

            for (int x = 1; x < Zone.Count; x = x + 1)
            {
                if (Zone[x].idcard1 > 0 && Zone[x].Code[2]==true)
                {
                    b[x].enabled = false;
                    Blue[x].SetActive(false);

                }
                if (Zone[x].idcard1 < 0 && Zone[x].Code[5]==true)
                {
                    b[x].enabled = false;
                    Blue[x].SetActive(false);

                }
            }

        }
        //Se outro card tiver sido selecionado
        if (idzone2 != 0 && idzone2 != idzone1)
        {
            if (idzone3 != idzone2 && idzone3!=0)
            {
                Zone[idzone3].anime.Play("b");
                b[idzone3].enabled = true;
                Blue[idzone3].SetActive(true);
                Zone[idzone3].select = 0;
            }
            PlayerPrefs.SetInt("C", idzone1);
            anime.Play("a");
            select = 1;
            b[idzone1].enabled = false;
            Blue[idzone1].SetActive(false);
            if (idcard1 * idcard2 >= 0)
            {

                A();
            }


            else
            {
                //Memoriza o id do aliado e do defensor
                f.y = idzone2;
                f.z = idzone1;
                f.card1 = idcard2;
                f.card2 = idcard1;

                a.Fight.SetActive(true);
                Move.SetActive(false);
                a.Cancel.SetActive(true);
                Study.SetActive(false);
                e2.idcard1 = idcard1;
                e2.idcard2 = idcard2;
                e2.idzone1 = idzone1;
                e2.idzone2 = idzone2;
                e2.Zonesprite0 = Zonesprite0;
            }
        }
    }


    public void A0() {
        
        PlayerPrefs.SetInt("A", idcard1);
        PlayerPrefs.SetInt("B", idzone1);
        e.Lyoko0.Clear();

        for (int x = 0; x < Lyoko.Count; x = x + 1)
        {
            e.Lyoko0.Add(Lyoko[x]);
        }


    }
    public void A()
    {
        e.Lyoko1.Clear();

        for (int x = 0; x < Lyoko.Count; x = x + 1)
        {
            e.Lyoko1.Add(Lyoko[x]);
        }


        e.idcard1 = idcard1;
        e.idcard2 = idcard2;
        e.idzone1 = idzone1;
        e.idzone2 = idzone2;
        e.Zonesprite0 = Zonesprite0;

        e1.idcard1 = idcard1;
        e1.idcard2 = idcard2;
        e1.idzone1 = idzone1;
        e1.idzone2 = idzone2;
        e1.Zonesprite0 = Zonesprite0;


        Study.SetActive(false);
        Move.SetActive(true);
        a.Fight.SetActive(false);
        Cancel.SetActive(true);
        /*troca de id/troca de sprite
        Zone[idzone2].idcard1 = idcard1;
            Zonesprite1.sprite = Zonesprite[idzone2].sprite;

            Zonesprite[idzone2].sprite = Zonesprite0.sprite;
            Zonesprite0.sprite = Zonesprite1.sprite;
            idcard1 = idcard2;
            PlayerPrefs.SetInt("A", 0);
            PlayerPrefs.SetInt("B", 0);

            for (int x = 1; x < 11; x = x + 1)
            {
                if (Zone[x].idcard1 == 0)
                {
                    b[x].enabled = false;
                }
                else
                {
                    b[x].enabled = true;
                }
            }
        */

    }
    public void C()
    {
        if(idPersonagem==0|| idPersonagem == 1|| idPersonagem == 4)
        {
            if (idzone2 == 0)
            {
                Study.SetActive(true);
                Cancel.SetActive(true);
                e3.idzone1 = idzone1;
            }
            
        }
    }
    public void D()
    {

        if(idcard1 != 0)
        {
            il.SetActive(true);
            il1.sprite = Zonesprite0.sprite;
        }
        
        if (idcard1 > 0)
        {
            a.EyeT[0].text = d.Chara[idcard1].Passive;
        }
        if (idcard1 < 0)
        {
            a.EyeT[0].text = d.Chara[idcard1*-1].Passive;
        }
        a.EyeT[1].text = Lyoko[0].ToString();
        a.EyeT[2].text = Lyoko[1].ToString();
        a.EyeT[3].text = Lyoko[2].ToString();
        a.EyeT[4].text = Mana.ToString();
        //a.EyeT[4].text = mov.ToString();
        //a.EyeT[5].text = act.ToString();


    }
    public void E()
    {
        il.SetActive(false);
    }
    public void F()
    {
        flash[0].SetActive(true);
        flash[1].SetActive(true);

    }
    public void G()
    {
        Debug.Log("Bla");
        O.B();
    }
    public void H()
    {
        Debug.Log("Ble");
        O.C();
    }
    public void I()
    {
        //Champion Death


        if (Code[9] == true)
        {
            Zonesprite0.sprite = a.Eggnivia;
            Code[10] = true;
            Code[9] = false;
            Blue[idzone1].SetActive(false);
            b[idzone1].enabled = false;
            a.LifeT[idzone1].text = 1.ToString();
            Lyoko[0] = 1;
            Lyoko[1] = 0;
            Lyoko[2] = 0;
            Mana = 0;

        }
        else
        {



            if (side == -1)
            {
                i[0].life -= Lyoko2[0];
                Damage[0].SetActive(true);
                DamageT[0].text = Lyoko2[0].ToString();
            }
            if (side == 1)
            {
                i[1].life -= Lyoko2[0];
                Damage[1].SetActive(true);
                DamageT[1].text = Lyoko2[0].ToString();

                //Split Strategy
                if (a.Strategy[0] == 3)
                {
                    //The strategy activates only once in the match
                    a.Strategy[0] = 0;
                    //Deals 8 damage to the enemy nexus
                    i[0].life -= 8;
                    //Ativa Q
                    a.SetEffectValue(6, 11, 8);
                    a.q.a.Add(6);
                    a.q.idzone1.Add(11);
                    a.q.Value.Add(8);
                }
            }


            idcard1 = 0;
            idPersonagem = 0;
            Zonesprite0.sprite = nada;
            Blue[idzone1].SetActive(false);
            a.MoldB[idzone1 - 1].SetActive(false);
            a.MoldR[idzone1 - 1].SetActive(false);
            b[idzone1].enabled = false;
            a.Heart[idzone1].SetActive(false);
            side = 0;
            for (int x = 0; x < Counter.Count; x = x + 1)
            {
                Counter[x] = 0;
            }
            for (int x = 0; x < Code.Count; x = x + 1)
            {
                Code[x] = false;
            }

        }

    }
}
