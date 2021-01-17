using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Lista

{
    public List<Card> card;

}
[System.Serializable]
public class Lista2

{
    public List<Action> action;

}
[System.Serializable]
public class Listinha
{
    public List<Lista> deck;
}
[System.Serializable]
public class Listona
{
    public List<Lista2> ActionDeck;
}
[System.Serializable]
public class ListString
{
    public List<string> Speak;
}
