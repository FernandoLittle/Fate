using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Combat : MonoBehaviour
{
    public int AttackA;
    public int AttackE;
    public int LvA;
    public int LvE;
    public int ScaleA;
    public int ScaleE;
    public Text LvAT;
    public Text AttackAT;
    public int LevelA;
    public int LevelE;
    public Text LevelAT;
    public Text LevelET;
    public List<Animator> FightAN;
    public List<Animator> FightANT;
    public List<Animator> Draco1;
    public List<Animator> Draco2;
    public List<GameObject> Blue;
    public List<GameObject> FantasyRivals;
    public List<GameObject> Dark;
    public Text AttackCA;
    public Text ScaleCA;
    public Text LVCA;
    public Text AttackCE;
    public Text ScaleCE;
    public Text LVCE;
    public Expect Expect;
    public FantasyRivalsIA FantasyRivalsIA;
    public List<Animator> anime;
    public int SkillIDA;
    public int SkillIDE;
    public int Win;
    public D D;
    public F F;
    public int Attacking;
    public O o;
    public int x10;
    public int x20;
    public int x30;
    public int x40;
    public int y0;
    public int z0;
    public List<int> ScaleAE;
    public int k;
    public int k0;
    public A A;
    // Start is called before the first frame update
    void Start()
    {

        LevelAT.text = LevelA.ToString();
        LevelET.text = LevelE.ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LvUp()
    {
        if (LevelA > 0)
        {
            LevelA -= 1;
            LevelAT.text = LevelA.ToString();
            LvA += 1;
            Calculus();
            D.LevelChange(-1, true);
        }

    }
    public void LvDown()
    {
        if (LvA > 0)
        {
            LevelA += 1;
            LevelAT.text = LevelA.ToString();
            LvA -= 1;
            Calculus();
            D.LevelChange(1, true);
        }
    }
    public void Calculus()
    {
        LvAT.text = LvA.ToString();
        AttackAT.text = (LvA * ScaleA).ToString();
    }
    public void Fight()
    {
        D.Zone[D.p1].ManaSpend = LvA;
        D.DisableA(true);
        for (int x = 0; x < FightAN.Count; x = x + 1)
        {

            FightAN[x].Play("Spectral3");
        }
        for (int x = 0; x < FightANT.Count; x = x + 1)
        {

            FightANT[x].Play("SpectralText0");
        }



        for (int x = 0; x < Blue.Count; x = x + 1)
        {

            Blue[x].SetActive(false);
        }
        if (o.NexusE.id * o.NexusE.side < 0)
        {
            Attacking = 1;
        }
        else
        {
            Attacking = 0;
        }


        
        FantasyRivals[0].SetActive(true);
        FantasyRivals[1].SetActive(true);
        Dark[1].SetActive(true);
        Dark[0].SetActive(false);
        Expect.LvA = LvA;
        Expect.LevelA = LevelA;
        Expect.OriginalLvA = 0;
        Expect.OriginalLevelA = LvA + LevelA;
        Expect.ScaleA = ScaleA;
        Expect.ScaleE = ScaleE;
        FantasyRivalsIA.LevelE = LevelE;
        FantasyRivalsIA.LevelA = LevelA + LvA;
        FantasyRivalsIA.IA();



        ScaleAE[0] = ScaleA;
        ScaleAE[1] = ScaleE;

        ScaleChangeEffects();
        if (ScaleAE[0] > ScaleA)
        {
            ScaleCA.color = new Color(0, 0.9f, 0, 1);
        }
        if (ScaleAE[0] == ScaleA)
        {
            ScaleCA.color = new Color(1, 1, 1, 1);
        }
        if (ScaleAE[0] < ScaleA)
        {
            ScaleCA.color = new Color(0.9f, 0, 0, 1);
        }
        if (ScaleAE[1] > ScaleE)
        {
            ScaleCE.color = new Color(0, 0.9f, 0, 1);
        }
        if (ScaleAE[1] == ScaleE)
        {
            ScaleCE.color = new Color(1, 1, 1, 1);
        }
        if (ScaleAE[1] < ScaleE)
        {
            ScaleCE.color = new Color(0.9f, 0, 0, 1);
        }


        ScaleA = ScaleAE[0];
        ScaleE = ScaleAE[1];

        ScaleCA.text = ScaleA.ToString();
        ScaleCE.text = ScaleE.ToString();
        Expect.ScaleA = ScaleA;
        Expect.ScaleE = ScaleE;


        Anime();
        Expect.CalculusTextA();
        Expect.CalculusTextE();
        Expect.A();

    }
    public void Anime()
    {
        if (SkillIDA == 1)
        {
            anime[0].Play("A1FR");
            anime[1].Play("draco1");
        }
        if (SkillIDA == 2)
        {
            anime[0].Play("draco1");
            anime[1].Play("A2FR");
        }
        if (SkillIDA == 3)
        {
            anime[2].Play("B1FR");
            anime[3].Play("draco1");
        }
        if (SkillIDA == 4)
        {
            anime[2].Play("draco1");
            anime[3].Play("B2FR");
        }
        anime[4].Play("draco");


        if (SkillIDE == 1)
        {
            anime[5].Play("A1FRx");
            anime[6].Play("draco2");
        }
        if (SkillIDE == 2)
        {
            anime[5].Play("draco2");
            anime[6].Play("A2FRx");
        }
        if (SkillIDE == 3)
        {
            anime[7].Play("B1FRx");
            anime[8].Play("draco2");
        }
        if (SkillIDE == 4)
        {
            anime[7].Play("draco2");
            anime[8].Play("B2FRx");
        }
        anime[9].Play("dracox");
    }
    public void Victory()
    {

        if (Win == 0)
        {
            F.AllyWin = 1;
            F.EnemyWin = 0;
        }
        if (Win == 1)
        {
            F.EnemyWin = 1;
            F.AllyWin = 0;
        }
        F.PassiveEffects();
        F.A();
    }
    public void Victory1()
    {
        if (SkillIDE == 1)
        {
            anime[5].Play("A1FRx2");
            if (Win == 1)
            {
                anime[SkillIDA - 1].Play("B1FR2");
            }
            else
            {
                anime[SkillIDA - 1].Play("B2FR2");
            }

        }
        if (SkillIDE == 2)
        {
            anime[6].Play("A2FRx2");
            if (Win == 1)
            {
                anime[SkillIDA - 1].Play("B2FR2");
            }
            else
            {
                anime[SkillIDA - 1].Play("B1FR2");
            }
        }
        if (SkillIDE == 3)
        {
            anime[7].Play("B1FRx2");
            if (Win == 1)
            {
                anime[SkillIDA - 1].Play("A2FR2");
            }
            else
            {
                anime[SkillIDA - 1].Play("A1FR2");
            }
        }
        if (SkillIDE == 4)
        {
            anime[8].Play("B2FRx2");
            if (Win == 1)
            {
                anime[SkillIDA - 1].Play("A1FR2");
            }
            else
            {
                anime[SkillIDA - 1].Play("A2FR2");
            }
        }
    }
    public void AttackChangeEffects()
    {
        UpAttackEffects();
        DownAttackEffects();

    }
    public void ScaleChangeEffects()
    {
        UpLevelEffects();
        DownLevelEffects();

    }
    public void ExChange(int x)
    {
        k0 = k + Attacking;
        if (k0 > 1)
        {
            k0 = 0;
        }
        if ((Attacking + x) % 2 == 0)
        {
            x10 = F.x1;
            x20 = F.x2;
            x30 = F.x3;
            x40 = F.x4;
            y0 = F.y;
            z0 = F.z;
        }
        if ((Attacking + x) % 2 == 1)
        {
            x10 = F.x5;
            x20 = F.x6;
            x30 = F.x7;
            x40 = F.x8;
            y0 = F.z;
            z0 = F.y;
        }
    }
    public void UpLevelEffects()
    {
        for (int x = 0; x < 2; x = x + 1)
        {
            k = x;
            ExChange(x);

            if (x20 == 23)//LeeAR
            {
                if (A.round == 1)
                {
                    UpLevel(2);
                }
            }


            if (x30 == 19)//LeeB
            {
                if (A.round == 1)
                {
                    UpLevel(2);
                }
            }

            if (x10 == 27)//FioraAF
            {
                F.DuelistF(y0);
                if (F.duelist == true)
                {
                    UpLevel(1);
                }
            }

            if (x20 == 21)//KalistaAR
            {
                F.PactF(y0);
                if (F.pact > 1)
                {
                    UpLevel(1);
                }
                    
            }

        }
    }
    public void DownLevelEffects()
    {
        for (int x = 0; x < 2; x = x + 1)
        {
            k = x;
            ExChange(x);

  
            if (x10 == 25)//VladAF
            {
                DownLevel(2, 7);
            }


            if (x20 == 20)//Anivia AR
            {
 
                DownLevel(3, 6);
                
            }

            if (x30 == 17)//Anivia B
            {
                DownLevel(2, 4);
            }

            if (x20 == 22)//TeemoAR
            {
                if (F.Zone[y0].Code[11] == true)
                {


                    DownLevel(5, 5);
                    F.Zone[y0].Code[11] = false;
                }
            }
        }
    }


    public void UpAttackEffects()
    {

        for (int x = 0; x < 2; x = x + 1)
        {
            k = x;

            ExChange(x);

            if (x10 == 26)//LeeAF
            {
                if (A.round == 1)
                {
                    UpAttack(4);
                }
            }


            if (x20 == 22)//VladAR
            {
                UpAttack(8);
            }

            if (x40 == 20)//FioraE
            {
                F.DuelistF(y0);
                if (F.duelist == true)
                {
                    UpAttack(5);
                }
                
            }
            if (x20 == 24)//FioraAR
            {
                F.DuelistF(y0);
                if (F.duelist == true)
                {
                    UpAttack(6);
                }

            }

            if (x10 == 24)//KalistaAF
            {
                F.PactF(y0);
                if (F.pact > 1)
                {
                    UpAttack(6);
                }
            }

        }
    }
    public void DownAttackEffects()
    {
        for (int x = 0; x < 2; x = x + 1)
        {
            k = x;
  
            ExChange(x);

            if (x40 == 18)//VladE
            {
                DownAttack(10, 18);
            }


            if (x10 == 23)//Anivia AF
            {

                DownAttack(10, 20);

            }

            if (x40 == 16)//Anivia E
            {
                DownAttack(7, 13);
            }

            if (x10 == 22)//TeemoAF
            {
                if (F.Zone[y0].Code[11] == true)
                {
                    DownAttack(20, 23);
                    F.Zone[y0].Code[11] = false;
                }
            }

            if (x40 == 17)//KalistaE
            {
                F.PactF(y0);
                if (F.pact > 1)
                {
                    DownAttack(7, 20);
                }
            }


        }

    }




    public void CopyLevelEffects()
    {
        for (int x = 0; x < 2; x = x + 1)
        {
            k = x;

            ExChange(x);
            if (x30 == 18)//KalistaB
            {
                if (F.pact > 1)
                {
                    CopyLevel();
                }


            }

            


        }

    }









    //...............................................................................................................
    public void UpLevel(int up)
    {
        ScaleAE[k0] += up;
    }
    public void DownLevel(int down, int min)
    {
        if (k0 == 0)
        {
            ScaleAE[1] -= down;
            if (ScaleAE[1] < min)
            {
                ScaleAE[1] = min;
            }
        }
        if (k0 == 1)
        {
            ScaleAE[0] -= down;
            if (ScaleAE[0] < min)
            {
                ScaleAE[0] = min;
            }
        }
    }
    public void UpAttack(int up)
    {
        Expect.AttackAE[k0] += up;


    }
    public void DownAttack(int down, int min)
    {

        if (k0 == 0)
        {

            if (Expect.AttackAE[1] > min)
            {
                Expect.AttackAE[1] -= down;
                if (Expect.AttackAE[1] < min)
                {

                    Expect.AttackAE[1] = min;

                }
            }
        }
        if (k0 == 1)
        {

            if (Expect.AttackAE[0] > min)
            {
                Expect.AttackAE[0] -= down;
                if (Expect.AttackAE[0] < min)
                {
                    Expect.AttackAE[0] = min;
                }
            }
        }
    }
    public void CopyLevel()
    {
        if (k0 == 0)
        {
            ScaleAE[0] = ScaleAE[1];
        }
        if (k0 == 1)
        {
            ScaleAE[1] = ScaleAE[0];
        }
    }
}
