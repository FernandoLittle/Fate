using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasyRivalsIA : MonoBehaviour
{
    public List<int> SkillIDA;
    public List<int> SkillIDE;
    public int Selector;
    public int SelectorAlly; 
    public int SelectorMana;
    public int ManA;
    public int ManE;
    public Combat Combat;
    public D D;
    public Expect Expect;
    public F F;
    public A A;
    public Generic Generic;
    public List<int> TurnTemp;
    public int TotalManaA;
    public int TotalManaE;
    public int IdealManaA;
    public int IdealAttackA;
    public int IdealAttackE;
    public int IdealScaleA;
    public int IdealScaleE;
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < 8; x = x + 1)
        {
            TurnTemp.Add(0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IA()
    {
        if (D.Attacking == 0)
        {
            AttackS();
        }
        else
        {
            DefenseS();
        }
        if (Selector == 0)
        {
            F.x5 = SkillIDE[0];
            F.x6 = 0;
            F.x7 = 0;
            F.x8 = 0;
            Combat.ScaleCE.text = D.AttackS[SkillIDE[0]].scale.ToString();
            Expect.ScaleE = D.AttackS[SkillIDE[0]].scale;
            Combat.ScaleE = D.AttackS[SkillIDE[0]].scale;
        }
        if (Selector == 1)
        {
            F.x6 = SkillIDE[1];
            F.x5 = 0;
            F.x7 = 0;
            F.x8 = 0;
            Combat.ScaleCE.text = D.AttackQ[SkillIDE[1]].scale.ToString();
            Expect.ScaleE = D.AttackQ[SkillIDE[1]].scale;
            Combat.ScaleE = D.AttackQ[SkillIDE[1]].scale;
        }
        if (Selector == 2)
        {
            F.x7 = SkillIDE[2];
            F.x6 = 0;
            F.x5 = 0;
            F.x8 = 0;
            Combat.ScaleCE.text = D.Block[SkillIDE[2]].scale.ToString();
            Expect.ScaleE = D.Block[SkillIDE[2]].scale;
            Combat.ScaleE = D.Block[SkillIDE[2]].scale;

        }
        if (Selector == 3)
        {
            F.x8 = SkillIDE[3];
            F.x6 = 0;
            F.x7 = 0;
            F.x5 = 0;
            Combat.ScaleCE.text = D.Dodge[SkillIDE[3]].scale.ToString();
            Expect.ScaleE = D.Dodge[SkillIDE[3]].scale;
            Combat.ScaleE = D.Dodge[SkillIDE[3]].scale;
        }
        
        SelectMana();
        Combat.SkillIDE = Selector+1;
        Expect.OriginalManaE = ManE;
        Expect.ManaSpendE = SelectorMana;
        Expect.OriginalManaSpendE = 0;
       

    }
    public void AttackS()
    {
        //Enemy Selector
        TurnTemp[0] = D.AttackS[D.a11].IAturn - A.turn;
        TurnTemp[1] = D.AttackQ[D.a21].IAturn - A.turn;
        TurnTemp[0] = Generic.Module(TurnTemp[0]);
        TurnTemp[1] = Generic.Module(TurnTemp[1]);
        if (TurnTemp[0] < TurnTemp[1])
        {
            Selector = 0;
        }
        else
        {
            Selector = 1;
        }
        //Ally Selector
        TurnTemp[2] = D.Block[D.a3].IAturn - A.turn;
        TurnTemp[3] = D.Dodge[D.a4].IAturn - A.turn;
        TurnTemp[2] = Generic.Module(TurnTemp[2]);
        TurnTemp[3] = Generic.Module(TurnTemp[3]);
        if (TurnTemp[2] < TurnTemp[3])
        {
            SelectorAlly = 2;
        }
        else
        {
            SelectorAlly = 3;
        }

    }
    public void DefenseS()
    {
        //Enemy Selector
        TurnTemp[0] = D.Block[D.a31].IAturn - A.turn;
        TurnTemp[1] = D.Dodge[D.a41].IAturn - A.turn;
        TurnTemp[0] = Generic.Module(TurnTemp[0]);
        TurnTemp[1] = Generic.Module(TurnTemp[1]);
        if (TurnTemp[0] < TurnTemp[1])
        {
            Selector = 2;
        }
        else
        {
            Selector = 3;
        }
        //Ally Selector
        TurnTemp[2] = D.AttackS[D.a1].IAturn - A.turn;
        TurnTemp[3] = D.AttackQ[D.a2].IAturn - A.turn;
        TurnTemp[2] = Generic.Module(TurnTemp[2]);
        TurnTemp[3] = Generic.Module(TurnTemp[3]);
        if (TurnTemp[2] < TurnTemp[3])
        {
            SelectorAlly = 0;
        }
        else
        {
            SelectorAlly = 1;
        }
    }
    public void SelectMana()
    {
        SelectorMana = 0;
        if (A.turn < 5)
        {
            IdealManaA = Random.Range(0, 4);            
        }
        else if(A.turn <8)
        {
            IdealManaA = Random.Range(0, TotalManaA-2);            
        }
        else
        {
            IdealManaA = TotalManaA;            
        }
        IdealManaA = Generic.Smaller(IdealManaA, TotalManaA);
        if (SelectorAlly == 0)
        {
            IdealScaleA=D.AttackS[SkillIDA[0]].scale;
        }
        if (SelectorAlly == 1)
        {
            IdealScaleA = D.AttackQ[SkillIDA[1]].scale;
        }
        if (SelectorAlly == 2)
        {
            IdealScaleA = D.Block[SkillIDA[2]].scale;
        }
        if (SelectorAlly == 3)
        {
            IdealScaleA = D.Dodge[SkillIDA[3]].scale;
        }


        if (Selector == 0)
        {
            IdealScaleE = D.AttackS[SkillIDE[0]].scale;
        }
        if (Selector == 1)
        {
            IdealScaleE = D.AttackQ[SkillIDE[1]].scale;
        }
        if (Selector == 2)
        {
            IdealScaleE = D.Block[SkillIDE[2]].scale;
        }
        if (Selector == 3)
        {
            IdealScaleE = D.Dodge[SkillIDE[3]].scale;
        }

        IdealAttackA = IdealManaA * IdealScaleA;
        ManaUp();
        if (SelectorMana > TotalManaE)
        {
            SelectorMana = TotalManaE;
        }
        D.Zone[D.p2].ManaSpend = SelectorMana;


        D.LevelChange(SelectorMana * -1, false);
    }
    public void ManaUp()
    {
        IdealAttackE = SelectorMana * IdealScaleE;
        if (SelectorMana < TotalManaE)
        {
            if (IdealAttackE < IdealAttackA)
            {
                SelectorMana += 1;
                ManaUp();
            }
            if(IdealAttackE==IdealAttackA && D.Attacking == 1)
            {
                SelectorMana += 1;
                ManaUp();
            }
        }
    }
}
