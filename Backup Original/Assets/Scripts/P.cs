using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P : MonoBehaviour
{
    public List<Sprite> a;
    public GameObject Joker;
    public Image JokerI;

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
        Joker.SetActive(true);
        JokerI.sprite = a[0];
    }
}
