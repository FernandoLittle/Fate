using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class E : MonoBehaviour
{
    public List<B> Zone;
    public A a;
    public int idcard1;
    public int idcard2;
    public int idzone1;
    public int idzone2;
    public List<Image> Zonesprite;
    public Image Zonesprite0;
    public Image Zonesprite1;
    public List<Button> b;
    public List<I> Guild;
    public List<Button> Guildb;
    public GameObject Fight;
    public GameObject Move;
    public GameObject Cancel;
    public GameObject Study;
    public GameObject Pass;
    public List<int> Lyoko0;
    public List<int> Lyoko1;
    public List<int> Lyoko2;
    public GameObject C1;
    public GameObject C2;
    public List<Transform> p;
    public GameObject im11;
    public GameObject im21;
    public Image im12;
    public Image im22;
    public Transform im13;
    public Transform im23;
    public GameObject Mold1;
    public GameObject Mold2;
    public int lv;
    public int up;
    public int mov;
    public int act;
    public int idPersonagem;
    public List<J> j;
    public List<bool> Code;
    public List<int> Counter;
    public List<int> Lyoko11;
    public List<GameObject> Blue;
    public List<GameObject> MoldB;
    public List<GameObject> MoldR;
    public O o;
    public Izanami Izanami;
    public bool EnemyV;
    public int side;
    public Sprite BlueMold;
    public Sprite RedMold;
    public Image MoldX;
    public Image MoldY;
    public int Damage;
    public List<GameObject> DamageAN;
    public List<Text> DamageT;
    public List<GameObject> Stun;
    public  int turn;
    public bool IAbool;
    public Q q;

    public Tutorial Tuto;
    public GameObject Tuto1;
    public D d;
    public int Level;
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
        

        d.Attacking = 1;

        


            Izanami.A();
          

            PlayerPrefs.SetInt("A1", idcard1);
            PlayerPrefs.SetInt("Rift", idzone1);
            



            
            if (idcard1 > 0)
            {
                Zone[idzone2].anime.Play("Z" + idzone2 + "Enemy");
                Zone[idzone1].anime.Play("Z" + idzone1 + "Ally");
            }
            if (idcard1 < 0)
            {
                Zone[idzone2].anime.Play("Z" + idzone2 + "Ally");
                Zone[idzone1].anime.Play("Z" + idzone1 + "Enemy");
            }

            PlayerPrefs.SetInt("C", 0);

        
       
        for (int x = 1; x < 11; x = x + 1)
        {
            b[x].enabled = false;
            Blue[x].SetActive(false);
        }

        Cancel.SetActive(false);
        //C2.SetActive(true);
        //C1.SetActive(false);
        Fight.SetActive(false);
    }

    //mov
    public void B()
    {
        Debug.Log("HM");

        Zone[idzone2].anime.Play("Normal");
        Zone[idzone1].anime.Play("Normal");
        Zone[idzone2].select = 0;
        Zone[idzone1].select = 0;
        im11.SetActive(true);
        im21.SetActive(true);
        im12.sprite = Zonesprite[idzone1].sprite;
        im22.sprite = Zonesprite[idzone2].sprite;
        im13.transform.position = new Vector3(p[idzone1].transform.position.x, p[idzone1].transform.position.y, p[idzone1].transform.position.z);
        im23.transform.position = new Vector3(p[idzone2].transform.position.x, p[idzone2].transform.position.y, p[idzone2].transform.position.z);
        if (Zone[idzone1].side == 1)
        {
            MoldX.sprite = BlueMold;
        }
        if (Zone[idzone2].side == 1)
        {
            MoldY.sprite = BlueMold;
        }
        if (Zone[idzone1].side == -1)
        {
            MoldX.sprite = RedMold;
        }
        if (Zone[idzone2].side == -1)
        {
            MoldY.sprite = RedMold;
        }
        if (Zone[idzone2].idcard1 == 0)
        {
            Mold2.SetActive(false);
        }
        else
        {
            Mold2.SetActive(true);
        }
        if (Zone[idzone1].idcard1 == 0)
        {
            Mold1.SetActive(false);
        }
        else
        {
            Mold1.SetActive(true);
        }
        j[0].idzone1 = idzone2;

        j[1].idzone1 = idzone1;

        Zone[idzone1].Lyoko.Clear();
        for (int x = 0; x < Lyoko0.Count; x = x + 1)
        {
            Zone[idzone1].Lyoko.Add(Lyoko0[x]);
        }


        Zone[idzone2].Lyoko.Clear();
        for (int x = 0; x < Lyoko1.Count; x = x + 1)
        {
            Zone[idzone2].Lyoko.Add(Lyoko1[x]);
        }


        idPersonagem = Zone[idzone2].idPersonagem;
        Zone[idzone2].idPersonagem = Zone[idzone1].idPersonagem;
        Zone[idzone1].idPersonagem = idPersonagem;
        Zone[idzone2].idcard1 = idcard1;
        Zone[idzone1].idcard1 = idcard2;
        Zonesprite1.sprite = Zonesprite[idzone2].sprite;

        Zonesprite[idzone2].sprite = Zonesprite0.sprite;
        Zonesprite0.sprite = Zonesprite1.sprite;
        PlayerPrefs.SetInt("A", 0);
        PlayerPrefs.SetInt("B", 0);

        for (int x = 0; x < Code.Count; x = x + 1)
        {
            Code[x] = Zone[idzone1].Code[x];
            Zone[idzone1].Code[x] = Zone[idzone2].Code[x];
            Zone[idzone2].Code[x] = Code[x];
        }

        Lyoko2.Clear();
        for (int x = 0; x < Zone[idzone1].Lyoko2.Count; x = x + 1)
        {
            Lyoko2.Add(Zone[idzone1].Lyoko2[x]);
        }
        Zone[idzone1].Lyoko2.Clear();
        for (int x = 0; x < Zone[idzone2].Lyoko2.Count; x = x + 1)
        {
            Zone[idzone1].Lyoko2.Add(Zone[idzone2].Lyoko2[x]);
        }
        Zone[idzone2].Lyoko2.Clear();
        for (int x = 0; x < Lyoko2.Count; x = x + 1)
        {
            Zone[idzone2].Lyoko2.Add(Lyoko2[x]);
        }




        Lyoko11.Clear();
        for (int x = 0; x < Zone[idzone1].Lyoko1.Count; x = x + 1)
        {
            Lyoko11.Add(Zone[idzone1].Lyoko1[x]);
        }
        Zone[idzone1].Lyoko1.Clear();
        for (int x = 0; x < Zone[idzone2].Lyoko1.Count; x = x + 1)
        {
            Zone[idzone1].Lyoko1.Add(Zone[idzone2].Lyoko1[x]);
        }
        Zone[idzone2].Lyoko1.Clear();
        for (int x = 0; x < Lyoko11.Count; x = x + 1)
        {
            Zone[idzone2].Lyoko1.Add(Lyoko11[x]);
        }

        for (int x = 0; x < Counter.Count; x = x + 1)
        {
            Counter[x] = Zone[idzone1].Counter[x];
            Zone[idzone1].Counter[x] = Zone[idzone2].Counter[x];
            Zone[idzone2].Counter[x] = Counter[x];
        }
        lv = Zone[idzone1].lv;
        Zone[idzone1].lv = Zone[idzone2].lv;
        Zone[idzone2].lv = lv;

        up = Zone[idzone1].up;
        Zone[idzone1].up = Zone[idzone2].up;
        Zone[idzone2].up = up;



        Exchange();



        side = Zone[idzone1].side;
        Zone[idzone1].side = Zone[idzone2].side;
        Zone[idzone2].side = side;
        /*for (int x = 1; x < 11; x = x + 1)
        {
            Zone[x].idcard1 *= -1;
        }
        Guild[0].id *= -1;
        Guild[1].id *= -1;
        */
        for (int x = 1; x < 11; x = x + 1)
        {
            if (Zone[x].select == 1)
            {
                Zone[x].anime.Play("b");
                Zone[x].select = 0;

            }
            if (Zone[x].idcard1 <= 0 )
            {
                b[x].enabled = false;
                Blue[x].SetActive(false);
            }
            else
            {
                b[x].enabled = true;
                Blue[x].SetActive(true);
            }
        }
        Guildb[0].enabled = false;
        Guildb[1].enabled = false;
       // a.E();
       /* if (a.turn == a.end)
        {


            a.B();
        }
       */
        a.LifeT[idzone1].text = Zone[idzone1].Lyoko[0].ToString();
        a.LifeT[idzone2].text = Zone[idzone2].Lyoko[0].ToString();

        if (Zone[idzone1].idcard1 > 0)
        {
            MoldB[idzone1].SetActive(true);
            MoldR[idzone1].SetActive(false);
        }
        if (Zone[idzone1].idcard1 < 0)
        {
            MoldB[idzone1].SetActive(false);
            MoldR[idzone1].SetActive(true);
        }
        if (Zone[idzone1].idcard1 == 0)
        {
            MoldB[idzone1].SetActive(false);
            MoldR[idzone1].SetActive(false);
        }


        if (Zone[idzone2].idcard1 > 0)
        {
            MoldB[idzone2].SetActive(true);
            MoldR[idzone2].SetActive(false);
        }
        if (Zone[idzone2].idcard1 < 0)
        {
            MoldB[idzone2].SetActive(false);
            MoldR[idzone2].SetActive(true);
        }
        if (Zone[idzone2].idcard1 == 0)
        {
            MoldB[idzone2].SetActive(false);
            MoldR[idzone2].SetActive(false);
        }
        Zone[idzone1].Code[11] = false;
        Zone[idzone2].Code[11] = false;

        //Teemo Passive
        /*if (Zone[idzone1].Counter[3] > 0)
        {
            Zone[idzone1].Lyoko[0] -= Zone[idzone1].Counter[3];

        }
        if (Zone[idzone2].Counter[3] > 0)
        {
            Zone[idzone2].Lyoko[0] -= Zone[idzone2].Counter[3];

        }*/

        if (Zone[idzone1].Code[8] == true)
        {

            if (Zone[idzone2].idcard1 != 0)
            {
                Zone[idzone1].Code[8] = false;
                Zone[idzone2].Code[6] = true;
                IAbool = true;
                a.SetEffectValue(1, idzone2, 2);
                Zone[idzone2].Lyoko[1] += 2;
                Zone[idzone2].Lyoko2[1] += 2;
                Zone[idzone1].Code[6] = true;
                a.SetEffectValue(1, idzone1, 2);
                
                Zone[idzone1].Lyoko[1] += 2;
                Zone[idzone1].Lyoko2[1] += 2;
            }

            q.IA = true;
            //a.Normalizator();
            //q.A();
            //StartCoroutine("IA");
        }
       /* if (IAbool == false)
        {
            o.A();
        }
       */
        
        PlayerPrefs.SetInt("C", 0);
        j[1].idzone1 = idzone1;
        Cancel.SetActive(false);
        Move.SetActive(false);
    }
    public void C()
    {
        PlayerPrefs.SetInt("A", 0);
        PlayerPrefs.SetInt("B", 0);
        for (int x = 1; x < 11; x = x + 1)
        {
            if (Zone[x].select == 1)
            {
                Zone[x].anime.Play("b");
                Zone[x].select = 0;

            }
            if (Zone[x].idcard1 <= 0)
            {
                b[x].enabled = false;
                Blue[x].SetActive(false);
            }
            else
            {
                b[x].enabled = true;
                Blue[x].SetActive(true);
            }
        }
        Guildb[0].enabled = false;
        Guildb[1].enabled = false;
        Study.SetActive(false);
        Fight.SetActive(false);
        Move.SetActive(false);
        Cancel.SetActive(false);
    }
    public void D()
    {
        PlayerPrefs.SetInt("A", 0);
        PlayerPrefs.SetInt("B", 0);
        if (Zone[idzone1].idPersonagem == 0)
        {
            Zone[idzone1].lv = 1;
            Zone[idzone1].up = 1;
            Zone[idzone1].idPersonagem = 1;
        }
        if (Zone[idzone1].idPersonagem == 1 || Zone[idzone1].idPersonagem == 4)
        {
            Zone[idzone1].lv = 1;
            Zone[idzone1].up = 1;
        }
        //Zone[idzone1].act -= 1;
      //  a.ChangeControl();
        for (int x = 1; x < 11; x = x + 1)
        {
            if (Zone[x].select == 1)
            {
                Zone[x].anime.Play("b");
                Zone[x].select = 0;

            }
            if (Zone[x].idcard1 <= 0 )
            {
                b[x].enabled = false;
                Blue[x].SetActive(false);
            }
            else
            {
                b[x].enabled = true;
                Blue[x].SetActive(true);
            }
        }
        Guildb[0].enabled = false;
        Guildb[1].enabled = false;
        a.TurnUp();
        if (a.turn == a.end)
        {
            a.B();
        }
        Pass.SetActive(false);
        Cancel.SetActive(false);
        gameObject.SetActive(false);
    }
    public void F()
    {
        PlayerPrefs.SetInt("A", 0);
        PlayerPrefs.SetInt("B", 0);
        for (int x = 1; x < 11; x = x + 1)
        {
            if (Zone[x].select == 1)
            {
                Zone[x].anime.Play("b");
                Zone[x].select = 0;

            }
        }
       // a.ChangeControl();

        for (int x = 1; x < 11; x = x + 1)
        {
            if (Zone[x].idcard1 <= 0 )
            {
                b[x].enabled = false;
                Blue[x].SetActive(false);
            }
            else
            {
                b[x].enabled = true;
                Blue[x].SetActive(true);
            }
        }
        Guildb[0].enabled = false;
        Guildb[1].enabled = false;
        a.TurnUp();
        if (a.turn == a.end)
        {
            a.B();
        }

        
        Cancel.SetActive(false);
        Study.SetActive(false);
        Move.SetActive(false);
        Fight.SetActive(false);

    }
    //Fim do turno
    public void G()
    {
        for (int x = 1; x < 11; x = x + 1)
        {
            //Se você tomou dano



                if (Zone[x].Code[3] == true)
                {
                    Zone[x].Lyoko[0] -= 2;

                }
                if (Zone[x].Counter[2] > 0)
                {
                    Zone[x].Counter[2] += 1;

                }

        }
    }
    public void Exchange()
    {
        Level = Zone[idzone1].Mana;
        Zone[idzone1].Mana = Zone[idzone2].Mana;
        Zone[idzone2].Mana= Level;
    }

    IEnumerator IA()
    {
        yield return new WaitForSeconds(1.5f);
        a.Normalizator();
        q.A();
    }
}
