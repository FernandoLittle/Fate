using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class Calculus : MonoBehaviourPunCallbacks

{
    public int ChooseAlly;
    public int ChooseEnemy;
    public Calculus Calculu;
    public Text a;
    public Image AllyI;
    public Image EnemyI;
    public List<Sprite> sprito;
    public Animator AnimeA;
    public Animator AnimeE;
    public int ScoreA;
    public int ScoreE;
    public Text ScoreAlly;
    public Text ScoreEnemy;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [PunRPC]
    public void Choose(int a, int b)
    {
        if (a == 0)
        {
            ChooseAlly = b;
        }
        if (a == 1)
        {
            ChooseEnemy = b;
        }
        Debug.Log(a);
        Debug.Log(b);
        if(ChooseAlly!=0 && ChooseEnemy != 0)
        {
            if (PhotonNetwork.IsMasterClient)
            {
                if (ChooseAlly == 1)
                {
                    AllyI.sprite = sprito[0];
                    Calculu.photonView.RPC("SpritosE", RpcTarget.Others, 0);
                }
                if (ChooseAlly == 2)
                {
                    AllyI.sprite = sprito[1];
                    Calculu.photonView.RPC("SpritosE", RpcTarget.Others, 1);
                }
                if (ChooseAlly == 3)
                {
                    AllyI.sprite = sprito[2];
                    Calculu.photonView.RPC("SpritosE", RpcTarget.Others, 2);
                }
                if (ChooseEnemy == 1)
                {
                    EnemyI.sprite = sprito[0];
                    Calculu.photonView.RPC("SpritosA", RpcTarget.Others, 0);
                }
                if (ChooseEnemy == 2)
                {
                    EnemyI.sprite = sprito[1];
                    Calculu.photonView.RPC("SpritosA", RpcTarget.Others, 1);
                }
                if (ChooseEnemy == 3)
                {
                    EnemyI.sprite = sprito[2];
                    Calculu.photonView.RPC("SpritosA", RpcTarget.Others, 2);
                }



                if (ChooseAlly == ChooseEnemy)
                {
                    Draw();
                }
                if (ChooseAlly == 1 && ChooseEnemy == 2)
                {
                    Win();
                }
                if (ChooseAlly == 1 && ChooseEnemy == 3)
                {
                    Loose();
                }
                if (ChooseAlly == 2 && ChooseEnemy == 1)
                {
                    Loose();
                }
                if (ChooseAlly == 2 && ChooseEnemy == 3)
                {
                    Win();
                }
                if (ChooseAlly == 3 && ChooseEnemy == 1)
                {
                    Win();
                }
                if (ChooseAlly == 3 && ChooseEnemy == 2)
                {
                    Loose();
                }

            }
        }
    }
    public void Win()
    {
        AnimeA.Play("A1");
        AnimeE.Play("A4");
        Calculu.photonView.RPC("Playo", RpcTarget.Others, 1);
    }
    public void Loose()
    {
        AnimeA.Play("A2");
        AnimeE.Play("A3");
        Calculu.photonView.RPC("Playo", RpcTarget.Others, 2);
    }
    public void Draw()
    {
        AnimeA.Play("A2");
        AnimeE.Play("A4");
        Calculu.photonView.RPC("Playo", RpcTarget.Others, 3);
    }



    public void test1()
    {
        Calculu.photonView.RPC("test2", RpcTarget.MasterClient, "Pedra");
    }
    [PunRPC]
    public void test2(string b)
    {
        a.text = b;
    }
    [PunRPC]
    public void SpritosA(int a)
    {
        AllyI.sprite = sprito[a];
        
    }

    [PunRPC]
    public void SpritosE(int a)
    {
        EnemyI.sprite = sprito[a];
    }
    [PunRPC]
    public void Playo(int a)
    {
        if (a == 1)
        {
            AnimeE.Play("A3");
            AnimeA.Play("A2");
        }
        if (a == 2)
        {
            AnimeE.Play("A4");
            AnimeA.Play("A1");
        }
        if (a == 3)
        {
            AnimeA.Play("A2");
            AnimeE.Play("A4");
        }
    }
    public void Result()
    {
        if (ChooseAlly == ChooseEnemy)
        {
            Calculu.photonView.RPC("Resulto", RpcTarget.Others, 1);

        }
        if (ChooseAlly == 1 && ChooseEnemy == 2)
        {
            Calculu.photonView.RPC("Resulto", RpcTarget.Others, 2);
            ScoreA += 1;

        }
        if (ChooseAlly == 1 && ChooseEnemy == 3)
        {

            Calculu.photonView.RPC("Resulto", RpcTarget.Others, 3);
            ScoreE += 1;


        }
        if (ChooseAlly == 2 && ChooseEnemy == 1)
        {
            Calculu.photonView.RPC("Resulto", RpcTarget.Others, 3);
            ScoreE += 1;


        }
        if (ChooseAlly == 2 && ChooseEnemy == 3)
        {
            Calculu.photonView.RPC("Resulto", RpcTarget.Others, 2);
            ScoreA += 1;


        }
        if (ChooseAlly == 3 && ChooseEnemy == 1)
        {
            Calculu.photonView.RPC("Resulto", RpcTarget.Others, 2);
            ScoreA += 1;


        }
        if (ChooseAlly == 3 && ChooseEnemy == 2)
        {
            Calculu.photonView.RPC("Resulto", RpcTarget.Others, 3);
            ScoreE += 1;
        }
        ScoreAlly.text = ScoreA.ToString();
        ScoreEnemy.text = ScoreE.ToString();
    }
    [PunRPC]
    public void Resulto(int result)
    {
        if (result == 1)
        {

        }
        if (result == 2)
        {
            ScoreE += 1;
        }
        if (result == 3)
        {
            ScoreA += 1;

        }
        ScoreAlly.text = ScoreA.ToString();
        ScoreEnemy.text = ScoreE.ToString();
    }
}
