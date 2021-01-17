using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ident : MonoBehaviour
{
    public int id;
    public Select Select;
    public Animator anime;
    public bool S;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Sele()
    {
        S = !S;
        if (S == true)
        {
            anime.Play("Grow+");
            Select.idList.Add(id);
            Select.idList0.Remove(id);
            Select.IntBut += 1;
        }
        else
        {
            anime.Play("grow-");
            Select.idList.Remove(id);
            Select.idList0.Add(id);
            Select.IntBut -= 1;
        }
        Select.id = id;
        Select.Selecto();
    }

}
