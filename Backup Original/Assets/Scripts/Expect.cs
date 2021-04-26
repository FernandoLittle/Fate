using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Expect : MonoBehaviour
{
    public Text AttackCA;
    public Text LVCA;
    public Text LevelCA;
    public Text AttackCE;
    public Text LVCE;
    public Text LevelCE;
    public int ManaA;
    public int ManaSpendA;
    public int OriginalManaSpendA;
    public int OriginalManaA;
    public int ManaE;
    public int ManaSpendE;
    public int OriginalManaSpendE;
    public int OriginalManaE;
    public int ScaleA;
    public int ScaleE;
    public int Win;
    //Ally Attack, Order=0; Enemy Attack, Order=1
    public int Order;
    public int AttackA;
    public int AttackE;
    public Combat Combat;
    public Animator FantasyDark;
    public O o;
    public List<int> AttackAE;
    public List <GameObject> AttackChange;
    public List<Text> AttackChangeT;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CalculusTextA()
    {
        LVCA.text = OriginalManaSpendA.ToString();
        LevelCA.text = OriginalManaA.ToString();
        AttackCA.text = (OriginalManaSpendA * ScaleA).ToString();
    }
    public void CalculusTextE()
    {
        LVCE.text = OriginalManaSpendE.ToString();
        LevelCE.text = OriginalManaE.ToString();
        AttackCE.text = (OriginalManaSpendE * ScaleE).ToString();
    }
    public void A()
    {

        if (ManaSpendA >= OriginalManaSpendA)
        {
            CalculusTextA();
            OriginalManaSpendA += 1;
            OriginalManaA -= 1;
            Invoke("A", 0.3f);
        }
        else
        {
            Invoke("B", 0.3f);
        }
    }
    public void B()
    {

        if (ManaSpendE >= OriginalManaSpendE)
        {
            CalculusTextE();
            OriginalManaSpendE += 1;
            OriginalManaE -= 1;
            Invoke("B", 0.3f);
        }
        else
        {
            
            FantasyDark.Play("Spectral3");
            Victory();
            Combat.Victory1();
        }
    }
    public void Victory()
    {
        AttackA = ManaSpendA * ScaleA;
        AttackE = ManaSpendE * ScaleE;
        AttackAE[0] = AttackA;
        AttackAE[1] = AttackE;
        Combat.AttackChangeEffects();
        FinalAttack();
        AttackA = AttackAE[0];
        AttackE = AttackAE[1];

        //+-Attack
        if (AttackA>AttackE)
        {
            Win = 0;
        }
        if (AttackA < AttackE)
        {
            Win = 1;
        }
        if (AttackA == AttackE)
        {
            if (o.AA.offline == true)
            {
                if (o.NexusE.id * o.NexusE.side > 0)
                {
                    Order = 1;
                }
                else
                {
                    Order = 0;
                }
                Win = Order;
            }
            else
            {
                if (o.AA.Atacante == true)
                {
                    Win = 1;
                }
                else
                {
                    Win = 0;
                }
                    
            }
            


        }
        Combat.Win = Win;
   
        Combat.Victory();
    }
    public void FinalAttack()
    {
        if (AttackA != AttackAE[0])
        {
            AttackChange[0].SetActive(true);
            AttackChangeT[2].text = AttackAE[0].ToString();
            if (AttackA > AttackAE[0])
            {
                AttackChangeT[0].text = ("("+ (AttackAE[0] - AttackA).ToString()+")");
            }
            if (AttackA < AttackAE[0])
            {
                AttackChangeT[0].text = ("(+" + (AttackAE[0] - AttackA).ToString() + ")");
            }
        }
        if (AttackE != AttackAE[1])
        {
            AttackChange[1].SetActive(true);
            AttackChangeT[5].text = AttackAE[1].ToString();
            if (AttackE > AttackAE[1])
            {
                AttackChangeT[3].text = ("(" + (AttackAE[1] - AttackE).ToString() + ")");
            }
            if (AttackE < AttackAE[1])
            {
                AttackChangeT[3].text = ("(+" + (AttackAE[1] - AttackE).ToString() + ")");
            }
        }
    }
    
}
