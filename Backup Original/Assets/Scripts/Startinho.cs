using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startinho : MonoBehaviour
{
    public List<GameObject> Strategy;
    public List<Animator> StrategyA;
    public Tutorial Tuto;
    public GameObject Tuto1;
    public A a;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void B()
    {
        Strategy[0].SetActive(true);
        Strategy[1].SetActive(true);
        Strategy[2].SetActive(true);
        StrategyA[0].Play("StrategyUp1");
        StrategyA[1].Play("StrategyUp1");
        StrategyA[2].Play("StrategyUp1");


    }
}
