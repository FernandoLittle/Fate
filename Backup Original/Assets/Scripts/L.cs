using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L : MonoBehaviour
{
    public GameObject Self;
    public GameObject Eye;
    public Image Eye1;
    public GameObject Eye2;
    public Image Zonesprite0;
    public List<int> at;
    public List<Text> at1;
    public D D;
    public Text text0;
    public int id;
    public int a;
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
        

        //Self.SetActive(false);
    }
    public void B()
    {
        Eye.SetActive(true);
        Eye2.SetActive(true);
        Eye1.sprite = Zonesprite0.sprite;
        text0.text = D.Chara[id].Passive;
        for (int x = 0; x < at.Count; x = x + 1)
        {
            at1[x].text = at[x].ToString();

        }
    }
    public void C()
    {
        Eye.SetActive(false);
        
    }
}
