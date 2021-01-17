using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Round : MonoBehaviour
{
    public A a;
    public int b;
    public Animator c;
    public Text turnT;
    public Text turnT1;
    public Text RoundT;
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
        b += 1;

        if (b % 2 == 0)
        {
            c.Play("Sword");

            
        }
        if (b % 2 == 1)
        {
            c.Play("Sword1");

        }
        turnT.text = a.turn.ToString();
        turnT1.text = (a.end-a.turn).ToString();
        RoundT.text = a.round.ToString();
    }
}
