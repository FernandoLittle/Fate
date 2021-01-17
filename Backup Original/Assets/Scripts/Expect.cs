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
    public int LevelA;
    public int LvA;
    public int OriginalLvA;
    public int OriginalLevelA;
    public int LevelE;
    public int LvE;
    public int OriginalLvE;
    public int OriginalLevelE;
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
        LVCA.text = OriginalLvA.ToString();
        LevelCA.text = OriginalLevelA.ToString();
        AttackCA.text = (OriginalLvA * ScaleA).ToString();
    }
    public void CalculusTextE()
    {
        LVCE.text = OriginalLvE.ToString();
        LevelCE.text = OriginalLevelE.ToString();
        AttackCE.text = (OriginalLvE * ScaleE).ToString();
    }
    public void A()
    {

        if (LvA >= OriginalLvA)
        {
            CalculusTextA();
            OriginalLvA += 1;
            OriginalLevelA -= 1;
            Invoke("A", 0.3f);
        }
        else
        {
            Invoke("B", 0.3f);
        }
    }
    public void B()
    {

        if (LvE >= OriginalLvE)
        {
            CalculusTextE();
            OriginalLvE += 1;
            OriginalLevelE -= 1;
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
        AttackA = LvA * ScaleA;
        AttackE = LvE * ScaleE;
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
            if(o.NexusE.id * o.NexusE.side < 0)
            {
                Order = 1;
            }
            else
            {
                Order = 0;
            }
                
            

            Win = Order;
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
