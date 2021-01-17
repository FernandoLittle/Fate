using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class D : MonoBehaviour
{
    //public Dictionary<int, Action> AtaqueForte1= new Dictionary<int, Action>();
    //public Dictionary<int, Action> AtaqueRápido1 = new Dictionary<int, Action>();
    //public Dictionary<int, Action> Bloqueio1 = new Dictionary<int, Action>();
    //public Dictionary<int, Action> Esquiva1 = new Dictionary<int, Action>();
    public List<int> b;
    //probablilidade
    public List<int> AFp;
    public List<int> ARp;
    public List<int> Blp;
    public List<int> Esp;
    public Image AF;
    public Image AR;
    public Image Bl;
    public Image Es;
    public G AFx;
    public G ARx;
    public G Blx;
    public G Esx;
    public Image AF1;
    public Image AR1;
    public Image Bl1;
    public Image Es1;
    public G AF1x;
    public G AR1x;
    public G Bl1x;
    public G Es1x;
    public List<B> Zone;
    public List<Text> LifeT;
    public List<I> Guild;
    public List<Button> bt;
    public A a;
    //Remover
    public Card h;
    //Randomico
    public int h1;
    //Personagens
    public int Ally;
    public int Enemy;
    public List<Card> Chara;
    public Image AllyIm;
    public Image EnemyIm;

    public List<Action> AttackQ;
    public int a1;
    public int a11;

    public List<Action> AttackS;
    public int a2;
    public int a21;

    public List<Action> Dodge;
    public int a3;
    public int a31;

    public List<Action> Block;
    public int a4;
    public int a41;

    public GameObject Fight;
    public GameObject Cancel;
    //attack counter
    public int c;
    //defense counter
    public int c1;
    public GameObject C1;
    public GameObject C2;
    public GameObject Dark;
    public List<Animator> anime;
    public F f;
    //Ally and Enemy Scripts
    public List<L> L;
    public List<Text> at;
    public List<Sprite> s;
    public Image Rift;
    public Image Rift1;
    public int summ;

    public GameObject i1;
    public GameObject i2;
    public List<GameObject> Blue;

    public int p1;
    public int p2;
    public Izanami Izanami;
    public Tutorial Tuto;
    public GameObject Tuto1;
    public List<Animator> Typ;
    public Text ScaleSA;
    public Text ScaleQA;
    public Text ScaleBA;
    public Text ScaleEA;
    public Text ScaleSE;
    public Text ScaleQE;
    public Text ScaleBE;
    public Text ScaleEE;
    public int SkillId;
    public Combat Combat;
    public Text ScaleT;
    public List<GameObject> Fantasy;
    public FantasyRivalsIA FantasyRivalsIA;
    //Ally=1, Enenmy=0
    public int Attacking;
    public List<GameObject> Skills;
    public GameObject DisableO;
    public Sprite FantasyBack;
    public GameObject PowerMod;
    public GameObject PowerMod1;
    public Generic Generic;

    public List<RectTransform> Size;
    public List<RectTransform> SizeM;
    // Start is called before the first frame update
    private void OnEnable()
    {
        a.DisableA(false);
        DisableA(false);
        PowerMod.SetActive(false);
        PowerMod1.SetActive(false);
        Normalizator();
        a.Normalizator();
        if (Attacking == 1)
        {
            Skills[0].SetActive(true);
            Skills[1].SetActive(true);
            Skills[6].SetActive(true);
            Skills[7].SetActive(true);
            Skills[2].SetActive(false);
            Skills[3].SetActive(false);
            Skills[4].SetActive(false);
            Skills[5].SetActive(false);

            Blue[0].SetActive(true);
            Blue[1].SetActive(true);
            Blue[2].SetActive(false);
            Blue[3].SetActive(false);
        }
        if (Attacking == 0)
        {
            Skills[2].SetActive(true);
            Skills[3].SetActive(true);
            Skills[4].SetActive(true);
            Skills[5].SetActive(true);
            Skills[0].SetActive(false);
            Skills[1].SetActive(false);
            Skills[6].SetActive(false);
            Skills[7].SetActive(false);

            Blue[2].SetActive(true);
            Blue[3].SetActive(true);
            Blue[0].SetActive(false);
            Blue[1].SetActive(false);

        }
        Combat.LvA = 0;
        Combat.LvE = 0;

        if (Tuto.tf == 1)
        {
            if (Tuto.ax == 0)
            {
                Tuto1.SetActive(true);
                Tuto.C(1);
                Tuto.ax += 1;
            }
            if(Tuto.ax ==2)
            {
                Tuto1.SetActive(true);
                Tuto.C(5);
            }

        }



       /* for (int x = 0; x < Blue.Count; x = x + 1)
        {
            Blue[x].SetActive(true);
        }
       */
        Ally = PlayerPrefs.GetInt("A");
        Enemy = PlayerPrefs.GetInt("A1");
        Enemy *= -1;
        //summ = PlayerPrefs.GetInt("Rift");
        //Rift.sprite = s[summ];
        Rift1.sprite = FantasyBack;
        AllyIm.sprite = Chara[Ally].sprite;
        EnemyIm.sprite = Chara[Enemy].sprite;

        f.G();

        L[0].at[0] = Zone[p1].Lyoko[0];
        L[0].at[1] = Zone[p1].Lyoko[1];
        L[0].at[2] = Zone[p1].Lyoko[2];
        L[0].id = Generic.Module(Zone[p1].idcard1);


        L[0].at[5] = Zone[p1].Mana;
        Combat.LevelA= Zone[p1].Mana;
        FantasyRivalsIA.TotalManaA = Zone[p1].Mana;

        L[1].at[0] = Zone[p2].Lyoko[0];
        L[1].at[1] = Zone[p2].Lyoko[1];
        L[1].at[2] = Zone[p2].Lyoko[2];
        L[1].id = Generic.Module(Zone[p2].idcard1);


        L[1].at[5] = Zone[p2].Mana;
        Combat.LevelE = Zone[p2].Mana;
        FantasyRivalsIA.TotalManaE = Zone[p2].Mana;



        at[0].text = Zone[p1].Lyoko[0].ToString();
        at[1].text = Zone[p1].Lyoko[1].ToString();
        at[2].text = Zone[p1].Lyoko[2].ToString();
        at[3].text = Zone[p1].Mana.ToString();
        
        at[5].text = Zone[p2].Lyoko[0].ToString();
        at[6].text = Zone[p2].Lyoko[1].ToString();
        at[7].text = Zone[p2].Lyoko[2].ToString();
        at[8].text = Zone[p2].Mana.ToString();
        


        //Sorteio das habilidades
        h1 = Random.Range(0, Chara[Ally].AtaqueForte.Count);
        a1 = Chara[Ally].AtaqueForte[h1];

        h1 = Random.Range(0, Chara[Enemy].AtaqueForte.Count);
        a11 = Chara[Enemy].AtaqueForte[h1];


        h1 = Random.Range(0, Chara[Ally].AtaqueRápido.Count);
        a2 = Chara[Ally].AtaqueRápido[h1];

        h1 = Random.Range(0, Chara[Enemy].AtaqueRápido.Count);
        a21 = Chara[Enemy].AtaqueRápido[h1];



        h1 = Random.Range(0, Chara[Ally].Bloqueio.Count);
        a3 = Chara[Ally].Bloqueio[h1];

        h1 = Random.Range(0, Chara[Enemy].Bloqueio.Count);
        a31 = Chara[Enemy].Bloqueio[h1];



        h1 = Random.Range(0, Chara[Ally].Esquiva.Count);
        a4 = Chara[Ally].Esquiva[h1];

        h1 = Random.Range(0, Chara[Enemy].Esquiva.Count);
        a41 = Chara[Enemy].Esquiva[h1];

        //Heritage Skill ID IA
        FantasyRivalsIA.SkillIDA[0] = a1;
        FantasyRivalsIA.SkillIDA[1] = a2;
        FantasyRivalsIA.SkillIDA[2] = a3;
        FantasyRivalsIA.SkillIDA[3] = a4;
        FantasyRivalsIA.SkillIDE[0] = a11;
        FantasyRivalsIA.SkillIDE[1] = a21;
        FantasyRivalsIA.SkillIDE[2] = a31;
        FantasyRivalsIA.SkillIDE[3] = a41;


        //Sprites das habilidades
        AF.sprite = AttackS[a1].sprite;
        AFx.id = a1;
        //Scale heritage
        ScaleSA.text = AttackS[a1].scale.ToString();
        

        AR.sprite = AttackQ[a2].sprite;
        ARx.id = a2;
        ScaleQA.text = AttackQ[a2].scale.ToString();


        Bl.sprite = Block[a3].sprite;
        Blx.id = a3;
        ScaleBA.text = Block[a3].scale.ToString();

        Es.sprite = Dodge[a4].sprite;
        Esx.id = a4;
        ScaleEA.text = Dodge[a4].scale.ToString();

        AF1.sprite = AttackS[a11].sprite;
        AF1x.id = a11;
        ScaleSE.text = AttackS[a11].scale.ToString();


        AR1.sprite = AttackQ[a21].sprite;
        AR1x.id = a21;
        ScaleQE.text = AttackQ[a21].scale.ToString();

        Bl1.sprite = Block[a31].sprite;
        Bl1x.id = a31;
        ScaleBE.text = Block[a31].scale.ToString();

        Es1.sprite = Dodge[a41].sprite;
        Es1x.id = a41;
        ScaleEE.text = Dodge[a41].scale.ToString();

        for (int z = 0; z < h.AtaqueForte.Count; z = z + 1)
        {

            for (int x = 0; x < h.AtaqueForte[z]; x = x + 1)
            {
                AFp.Add(z);

            }
        }
        for (int z = 0; z < h.AtaqueRápido.Count; z = z + 1)
        {

            for (int x = 0; x < h.AtaqueRápido[z]; x = x + 1)
            {
                ARp.Add(z);

            }
        }
        for (int z = 0; z < h.Bloqueio.Count; z = z + 1)
        {

            for (int x = 0; x < h.Bloqueio[z]; x = x + 1)
            {
                Blp.Add(z);

            }
        }
        for (int z = 0; z < h.Esquiva.Count; z = z + 1)
        {

            for (int x = 0; x < h.Esquiva[z]; x = x + 1)
            {
                Esp.Add(z);

            }
        }


        /* Debug.Log(AtaqueForte1.Count);
         h1 = Random.Range(0, AFp.Count);
         AF.sprite = AtaqueForte1[AFp[h1]].sprite;
         h1 = Random.Range(0, ARp.Count);
         AR.sprite = AtaqueRápido1[ARp[h1]].sprite;
         h1 = Random.Range(0, Blp.Count);
         Bl.sprite = Bloqueio1[Blp[h1]].sprite;
         h1 = Random.Range(0, Esp.Count);
         Es.sprite = Esquiva1[Esp[h1]].sprite;*/
        c = 0;
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void A()
    {
        c = 1;
        A2();
    }
    public void A1()
    {
        c1 = 1;
        A2();

    }
    public void A2()
    {
        if (c == 1 && c1 == 1)
        {
            Fight.SetActive(true);
            Cancel.SetActive(true);
        }
        Fantasy[0].SetActive(true);
        Fantasy[1].SetActive(true);

    }
    public void B()
    {
        Izanami.A();
        PlayerPrefs.SetInt("A", 0);
        PlayerPrefs.SetInt("B", 0);
        //Hide Types
        /*for (int x = 0; x < Typ.Count; x = x + 1)
        {
            Typ[x].Play("Spec");
        }*/


        a.ChangeControl();
        for (int x = 1; x < 11; x = x + 1)
        {
            LifeT[x].text = Zone[x].Lyoko[0].ToString();
        }
        a.TurnUp();
        if (a.turn == a.end)
        {


            a.B();
        }
        // C1.SetActive(true);
        // C2.SetActive(false);
        anime[8].Play("draco");
        //anime[9].Play("draco");
        i1.SetActive(false);
        i2.SetActive(false);
        if (f.b1 == 0)
        {
            anime[0].Play("draco1");
        }
        if (f.b2 == 0)
        {
            anime[1].Play("draco1");

        }
        if (f.b3 == 0)
        {
            anime[2].Play("draco1");
        }
        if (f.b4 == 0)
        {
            anime[3].Play("draco1");
        }
        if (f.b5 == 0)
        {
            anime[4].Play("draco2");
        }
        if (f.b6 == 0)
        {
            anime[5].Play("draco2");
        }
        if (f.b7 == 0)
        {
            anime[6].Play("draco2");
        }
        if (f.b8 == 0)
        {
            anime[7].Play("draco2");
        }

        if (f.b1==1 && f.b7 == 1)
        {
            AFx.e = 1;
            Bl1x.e = 0;
            anime[0].Play("A1");
            anime[6].Play("B1e");
        }
        if (f.b1 == 1 && f.b8 == 1)
        {
            AFx.e = 0;
            Es1x.e = 1;
            anime[0].Play("A1");
            anime[7].Play("B2e");
        }
        if (f.b2 == 1 && f.b7 == 1)
        {
            ARx.e = 0;
            Bl1x.e = 1;
            anime[1].Play("A2");
            anime[6].Play("B1e");
        }
        if (f.b2 == 1 && f.b8 == 1)
        {
            ARx.e = 1;
            Es1x.e = 0;
            anime[1].Play("A2");
            anime[7].Play("B2e");
        }
        Fight.SetActive(false);
        Cancel.SetActive(false);
        //Dark.SetActive(true);
    }
    public void C()
    {
        c = 0;
        Fight.SetActive(false);
        Cancel.SetActive(false);
    }
    public void E()
    {


        if (f.b3 == 1 && f.b5 == 1)
        {
            Blx.e = 0;
            AF1x.e = 1;
            anime[2].Play("B1");
            anime[4].Play("A1x");
        }
        if (f.b4 == 1 && f.b5 == 1)
        {
            Esx.e = 1;
            AF1x.e = 0;
            anime[3].Play("B2");
            anime[4].Play("A1x");
        }
        if (f.b3 == 1 && f.b6 == 1)
        {
            AR1x.e = 0;
            Blx.e = 1;
            anime[2].Play("B1");
            anime[5].Play("A2x");
        }
        if (f.b4 == 1 && f.b6 == 1)
        {
            AR1x.e = 1;
            Esx.e = 0;
            anime[3].Play("B2");
            anime[5].Play("A2x");
        }
    }
    public void CardSelect()
    {
        if (SkillId == 1)
        {
            Combat.ScaleA = AttackS[a1].scale;
        }
        if (SkillId == 2)
        {
            Combat.ScaleA = AttackQ[a2].scale;
        }
        if (SkillId == 3)
        {
            Combat.ScaleA = Block[a3].scale;
        }
        if (SkillId == 4)
        {
            Combat.ScaleA = Dodge[a4].scale;
        }
        ScaleT.text = Combat.ScaleA.ToString();
        Combat.Calculus();
    }
    public void LevelChange(int module, bool ally)
    {
        if (ally == true)
        {
            Zone[p1].Mana += 1 * module;
        }
        if (ally == false)
        {
            Zone[p2].Mana += 1 * module;
        }

    }
    public void DisableA(bool x)
    {

        DisableO.SetActive(x);

    }
    public void Normalizator()
    {
        Debug.Log("HGHJJHK");
        anime[0].Play("Norma1");
        anime[1].Play("Norma2");
        anime[2].Play("Norma3");
        anime[3].Play("Norma4");
        anime[4].Play("Norma5");
        anime[5].Play("Norma6");
        anime[6].Play("Norma7");
        anime[7].Play("Norma8");

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
