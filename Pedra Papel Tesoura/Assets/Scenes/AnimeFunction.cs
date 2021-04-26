using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimeFunction : MonoBehaviour
{
    public Calculus Calculus;
    public Transform AllyT;
    public int id;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Result()
    {
        Calculus.Result();
        ActiveFalse();
    }
    public void ActiveFalse()
    {
        if (id == 0)
        {
            AllyT.transform.localPosition = new Vector3(-383, 25, 0);
            AllyT.transform.rotation.Set(0, 0, 0, 0);
        }
        if (id == 1)
        {
            AllyT.transform.localPosition = new Vector3(380, 25, 0);
            AllyT.transform.rotation.Set(0, 0, 0, 0);
        }
        gameObject.SetActive(false);
        gameObject.SetActive(true);

    }
}
