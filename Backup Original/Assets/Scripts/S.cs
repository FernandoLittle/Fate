using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S : MonoBehaviour
{
    public int id;
    public A a;
    public GameObject Estrategia;
    public List<Animator> StrategyA;
    public Animator StrategyAn;
    public Tutorial Tuto;
    public GameObject Tuto1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void A1()
    {
        a.Strategy[0] = id;
        if (id == 1)
        {
            StrategyA[1].Play("StrategyDown");
            StrategyA[0].Play("StrategyUp");
            StrategyA[2].Play("StrategyDown");
        }
        if (id == 2)
        {
            StrategyA[0].Play("StrategyDown");
            StrategyA[1].Play("StrategyUp");
            StrategyA[2].Play("StrategyDown");
        }
        if (id == 3)
        {
            StrategyA[0].Play("StrategyDown");
            StrategyA[2].Play("StrategyUp");
            StrategyA[1].Play("StrategyDown");
        }

    }
    public void B()
    {
        StrategyAn.Play("Black");
    }
    public void C()
    {
        if (Tuto.tf == 1)
        {
            Tuto1.SetActive(true);
            Tuto.C(0);
        }
    }
}
