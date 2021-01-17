using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TutorialT : MonoBehaviour
{
    public Text Tutorial1;
    //public List<string> TutorialEN;
    public List<ListString> TutorialBR;

    public List <ListString> TutorialEN;
    public int x;
    public int a;
    public int Language;
    public int Textn;
    public int Charn;
    public bool b;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (b == true)
        {


            a += 1;

            //Tutorial2.ToCharArray();
            if (a % 1 == 0)
            {
                if (Language == 0)
                {
                    Tutorial1.text += TutorialEN[x].Speak[Textn][Charn];
                    Charn += 1;
                    if (Charn >= TutorialEN[x].Speak[Textn].Length)
                    {
                        b = false;
                        
                    }
                    
                }

            }
        }
    }

}
