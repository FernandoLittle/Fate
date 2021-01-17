using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName="New Card",menuName ="Card")]
public class Card : ScriptableObject
{
    public Sprite sprite;
    public Sprite sprite1;
    public int id;
    public int idPersonagem;
    public List<int> AtaqueForte;
    public List<int> AtaqueRápido;
    public List<int> Bloqueio;
    public List<int> Esquiva;
    public int Vida;
    public int Ataque;
    public int Defesa;
    public int act;
    public int mov;
    public int Level;
    public string Passive;
    public string Passivebr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
