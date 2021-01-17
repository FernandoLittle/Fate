using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class F : MonoBehaviour
{
    public List<B> Zone;
    //Aliado
    public int y;
    public int y0;
    //Inimigo
    public int z;
    public int z0;
    public GameObject Dark;
    //Inimigos próximos
    //public List <int> z1;

    //Id Efeito
    public int x1;
    public int x2;
    public int x3;
    public int x4;
    public int x5;
    public int x6;
    public int x7;
    public int x8;

    public int x10;
    public int x20;
    public int x30;
    public int x40;
    public int x50;
    public int x60;
    public int x70;
    public int x80;


    // Tipo da habilidade
    public int b1;
    public int b2;
    public int b3;
    public int b4;
    public int b5;
    public int b6;
    public int b7;
    public int b8;

    public int b10;
    public int b20;
    public int b30;
    public int b40;
    public int b50;
    public int b60;
    public int b70;
    public int b80;


    //Se inimigo for o atacante = 1
    public int Attacking;

    //Dano
    public int Damage;

    //Caos;
    public int Caos;

    //Identificador de Aliados
    public int e = 1;
    public int e1 = -1;
    public int e0;

    //Vida
    public List<int> c1;
    //Ataque
    public List<int> c2;
    //Defesa
    public List<int> c3;
    //Velocidade

    //Energia
    public List<int> c5;
    //Animações
    public List<int> c6;

    //Sprites
    public List<int> c8;
    //Aliado\Inimigo
    public List<int> c9;
    //Valor
    public List<int> c10;
    //Tipo da Carta
    public List<int> c11;
    //Alvo do Efeito
    public List<int> c12;

    public D D;
    public int k;
    public Image Eye;
    public GameObject Eye1;
    public Text Eye2;
    public List<GameObject> anime;
    public List<GameObject> anime1;
    public List<Text> AllyT;
    public List<Text> EnemyT;
    public List<Text> Value;
    public List<Text> Value1;
    public int target;
    //Temp
    public int sla;
    public List<int> al;
    //Negate
    public int Vlad;
    public int Devil;

    public GameObject i1;
    public GameObject i2;
    public List<Animator> t;
    public List<GameObject> t1;
    public List<GameObject> Stun;
    public Q q;
    public int anivia;
    public int card1;
    public int card2;
    public int card10;
    public int card20;
    public int Win;
    public int AllyWin;
    public int EnemyWin;
    public A a;
    public O o;
    public bool duelist;
    public int pact;



    public void PassiveEffects()

    {
        if (o.NexusE.id * o.NexusE.side < 0)
        {
            Attacking = 1;
        }
        else
        {
            Attacking = 0;
        }

        k = 0;



        for (int x = 0; x < 2; x = x + 1)
        {
            ExChange(x);
            if (x40 == 15)//TeemoE
            {
                if (Zone[y0].Code[11] == true)
                {
                    UpAttribute(2, 2, false);
                }
            }
            if (x40 == 19)//LeeE
            {
                if (a.round == 1)
                {
                    UpAttribute(1, 2, false);
                }
            }
            if (x30 == 20) //FioraB
            {
                DuelistF(y0);
                if (duelist == true)
                {
                    UpAttribute(1, 2, false);
                }
            }
        }
    }
    public void A()

    {
        if (o.NexusE.id * o.NexusE.side < 0)
        {
            Attacking = 1;
        }
        else
        {
            Attacking = 0;
        }

        k = 0;

        //Lista de fases/ Fase 1: Efeitos que não podem ser negados/ Fase 2: Efeitos de negação/ Fase 3: Efeitos que não variam em função de um atributo/ Fase 4 Efeitos que variam em função de um atributo/

        for (int x = 0; x < 2; x = x + 1)
        {

            ExChange(x);



            //Ataques Fortes Ally
            if (x10 == 1)
            {


                Damage = 10 - Zone[z0].Lyoko[2];
                if (Damage > 0)
                {
                    Zone[z0].Lyoko[0] -= Damage;
                    Zone[z0].Code[4] = true;
                }
                if ((b30 == 1 && b60 == 1) || (b40 == 1 && b50 == 1))
                {
                    Zone[y0].Lyoko[0] += 1;
                    Zone[y0].Lyoko[1] += 1;
                    Zone[y0].Lyoko[2] += 1;
                    Zone[y0].Lyoko1[0] += 1;
                    Zone[y0].Lyoko1[1] += 1;
                    Zone[y0].Lyoko1[2] += 1;
                }


            }
            if (x10 == 2)
            {


                Zone[y0].Lyoko[0] += 2;

                Damage = 2;
                c6.Add(2);
                target = 1;
                X1();
                /*c1.Add(Zone[y0].Lyoko[0]);
                c2.Add(Zone[y0].Lyoko[1]);
                c3.Add(Zone[y0].Lyoko[2]);
                c4.Add(Zone[y0].mov);
                c5.Add(Zone[y0].act);
                c6.Add(2);
                c7.Add(3);
                c8.Add(2);
                c9.Add(e0);
                c10.Add(2);
                c11.Add(1);
                c12.Add(e0);
                */

                if (Win == 1)
                {

                    Damage = 7 - Zone[z0].Lyoko[2];
                    if (Damage > 0)
                    {
                        Zone[z0].Lyoko[0] -= Damage;
                        Zone[z0].Code[4] = true;
                    }
                    else
                    {
                        Damage = 0;
                    }
                    c1.Add(Zone[z0].Lyoko[0]);
                    c2.Add(Zone[z0].Lyoko[1]);
                    c3.Add(Zone[z0].Lyoko[2]);
                    c5.Add(Zone[z0].Mana);
                    c6.Add(1);
                    c8.Add(2);
                    c9.Add(e0);
                    c10.Add(Damage);
                    c11.Add(1);
                    c12.Add(e0 * -1);
                }


            }
            if (x10 == 3)
            {



                if (Zone[y0].Lyoko[1] > Zone[z0].Lyoko[1])
                {
                    x50 = 0;
                    x60 = 0;
                }







                Damage = Zone[y0].Lyoko[1] - Zone[z0].Lyoko[2];
                if (Damage > 0)
                {
                    Zone[z0].Lyoko[0] -= Damage;
                    Zone[z0].Code[4] = true;
                }


            }

            if (x10 == 4)
            {

                x70 = 0;




                Zone[z0].Lyoko[2] = 0;




                Damage = Zone[y0].Lyoko[1] - Zone[z0].Lyoko[2];
                if (Damage > 0)
                {
                    Zone[z0].Lyoko[0] -= Damage;
                    Zone[z0].Code[4] = true;
                }


            }
            if (x10 == 5)
            {

                Zone[y0].Lyoko[0] += 1;
                Zone[y0].Lyoko[1] += 1;
                Zone[y0].Lyoko[2] += 1;
                Zone[y0].Lyoko1[0] += 1;
                Zone[y0].Lyoko1[1] += 1;
                Zone[y0].Lyoko1[2] += 1;
                b10 = 0;

            }
            if (x10 == 6)
            {


                Damage = 0;
                for (int w = 0; w < Zone.Count; w = w + 1)
                {
                    if (Zone[w].idcard1 * e0 > 0)
                    {
                        Damage += Zone[w].Lyoko[1];
                        Zone[w].Lyoko[1] = 0;
                    }
                }
                Damage -= Zone[z0].Lyoko[2];
                if (Damage > 0)
                {
                    Zone[z0].Lyoko[0] -= Damage;
                    Zone[z0].Code[4] = true;
                }


            }
            if (x10 == 7)
            {


                Caos = Random.Range(3, 6);
                Damage = Zone[y0].Lyoko[1] + Caos - Zone[z0].Lyoko[2];
                if (Damage > 0)
                {
                    Zone[z0].Lyoko[0] -= Damage;
                    Zone[z0].Code[4] = true;
                }



            }
            if (x10 == 8)
            {

                Damage = Zone[y0].Lyoko[1] + Zone[y0].Lyoko[2] - Zone[z0].Lyoko[2];
                if (Damage > 0)
                {
                    Zone[z0].Lyoko[0] -= Damage;
                    Zone[z0].Code[4] = true;
                }


            }
            if (x10 == 9)
            {


                if (Zone[y0].Lyoko[1] > Zone[z0].Lyoko[1])
                {
                    x50 = 0;
                    x60 = 0;
                }






                Damage = Zone[y0].Lyoko[1] - Zone[z0].Lyoko[2];
                if (Damage > 0)
                {
                    Zone[z0].Lyoko[0] -= Damage;
                    Zone[z0].Code[4] = true;
                }


                //Evolui para mago mestre
            }
            if (x10 == 10)
            {

                Zone[y0].Lyoko[1] += 4;



                if (b80 == 0)
                {
                    Damage = Zone[y0].Lyoko[1] - Zone[z0].Lyoko[2];
                    if (Damage > 0)
                    {
                        Zone[z0].Lyoko[0] -= Damage;
                        Zone[z0].Code[4] = true;
                    }
                }

            }
            if (x10 == 18)
            {

                if (Win == 1)
                {
                    Caos = Random.Range(3, 6);
                    Damage = Zone[y0].Lyoko[1] + Caos - Zone[z0].Lyoko[2];
                    if (Damage > 0)
                    {
                        Zone[z0].Lyoko[0] -= Damage;
                        Zone[z0].Code[4] = true;
                    }
                }


            }
            if (x10 == 20)
            {

                if (x + Attacking % 2 == 0)
                {
                    for (int w = 1; w < Zone.Count; w = w + 1)
                    {
                        if (Zone[w].idPersonagem == 3 && Zone[w].idcard1 > 0)
                        {
                            Zone[w].lv1 += 1;
                            Zone[w].up = 1;
                        }
                    }
                }
                if (x + Attacking % 2 == 1)
                {
                    for (int w = 1; w < Zone.Count; w = w + 1)
                    {
                        if (Zone[w].idPersonagem == 4 && Zone[w].idcard1 < 0)
                        {
                            Zone[w].up = 1;
                        }
                    }
                }

                //Aumenta o nível do Pilkim

            }
            if (x10 == 21)
            {
                //Elimina um inimigo do jogo no final de cada turno

            }

            //LoL
            if (x10 == 22)//TeemoAF
            {

                if (Win == 1)
                {
                    Attack();
                    Zone[z0].Counter[5] += 1;
                }



            }
            if (x10 == 23)//AniviaAF
            {

                {
                    if (Win == 1)
                    {


                        for (int w = 1; w < Zone.Count; w = w + 1)
                        {

                            if (Zone[w].idcard1 * card10 /* * e0 */ < 0)
                            {
                                a.SetEffectValue(0, w, 2);

                                Zone[w].Code[4] = true;

                                a.SetEffectValue(4, w, 1);
                            }
                        }



                    }
                }
            }
            if (x10 == 24)//KalistaAF
            {


                if (Win == 1)
                {
                    Attack();
                    DamageAttribute(1, 2, true);
                }



            }

            if (x10 == 25)//VladAF
            {

                if (Win == 1)
                {
                    if (Zone[y0].Counter[2] == 0)
                    {
                        Zone[y0].Counter[2] += 1;
                    }


                }



            }
            if (x10 == 26)//LeeAF
            {


                if (Win == 1)
                {
                    Attack();
                    Attack();
                }



            }
            if (x10 == 27)//FioraAF
            {


                if (Win == 1)
                {
                    if (Zone[y0].ManaSpend == 4)
                    {
                        TrueDamage(8);
                    }
                    else
                    {
                        TrueDamage(4);
                    }

                    /* Damage = Zone[y0].Lyoko[1] + 2 * Zone[z0].Counter[1] - Zone[z0].Lyoko[2];
                     if (Damage > 0)
                     {
                         if (Zone[z0].Counter[1] > 3)
                         {
                             Damage *= 2;
                         }
                         Zone[z0].Lyoko[0] -= Damage;
                         Zone[z0].Code[4] = true;
                         c6.Add(1);
                         d1 = -1;
                         X1();
                         if (Zone[z0].Counter[1] > 3)
                         {
                             Zone[y0].Lyoko[0] += Damage;
                             if (Zone[y0].Lyoko[0] > Zone[y0].Lyoko1[0] + Zone[y0].Lyoko2[0])
                             {
                                 Zone[y0].Lyoko[0] = Zone[y0].Lyoko1[0] + Zone[y0].Lyoko2[0];
                             }
                             c6.Add(6);
                             d1 = 1;
                             X1();
                         }
                         Zone[z0].Counter[1] += 1;


                     }
                     else
                     {
                         Damage = 0;
                     }*/

                }



            }
            //Ataques Rápidos Ally

            if (x20 == 1)
            {


                Zone[y0].Lyoko[0] -= 2;
                Zone[y0].Code[4] = true;


                if (Win == 1)
                {
                    {
                        Damage = Zone[y0].Lyoko[1] * 2 - Zone[z0].Lyoko[2];
                        if (Damage > 0)
                        {
                            Zone[z0].Lyoko[0] -= Damage;
                            Zone[z0].Code[4] = true;

                        }
                        else
                        {
                            Damage = 0;
                        }

                    }
                }


            }
            if (x20 == 2)
            {
                //Transforma em Nehant

            }
            if (x20 == 3)
            {

                Zone[y0].Lyoko[1] += 3;
                Zone[y0].Lyoko1[1] += 3;
                b20 = 0;

            }

            if (x20 == 4)
            {

                Zone[y0].Lyoko[0] += 1;
                Zone[y0].Lyoko[1] += 1;
                Zone[y0].Lyoko[2] += 1;
                Zone[y0].Lyoko1[0] += 1;
                Zone[y0].Lyoko1[1] += 1;
                Zone[y0].Lyoko1[2] += 1;
                if (Zone[y0].Lyoko[0] < (Zone[y0].Lyoko2[0] + Zone[y0].Lyoko1[0]))
                {
                    Zone[y0].Lyoko[0] += 3;
                    if (Zone[y0].Lyoko[0] > (Zone[y0].Lyoko2[0] + Zone[y0].Lyoko1[0]))
                    {
                        Zone[y0].Lyoko[0] = Zone[y0].Lyoko2[0] + Zone[y0].Lyoko1[0];
                    }
                }
                //Move oponente




                Damage = Zone[y0].Lyoko[1] - Zone[z0].Lyoko[2];
                if (Damage > 0)
                {
                    Zone[z0].Lyoko[0] -= Damage;
                    Zone[z0].Code[4] = true;
                }


            }
            if (x20 == 5)
            {
                //Dobra os efeitos passivos de Nehant
            }
            if (x20 == 6)
            {

                if (Win == 1)
                {
                    {
                        Damage = Zone[y0].Lyoko[1] * 2 - Zone[z0].Lyoko[2];
                        if (Damage > 0)
                        {
                            Zone[z0].Lyoko[0] -= Damage;
                            Zone[z0].Code[4] = true;
                        }

                    }
                }


            }

            if (x20 == 7)
            {

                if (Win == 1)
                {
                    {
                        Damage = 4 - Zone[z0].Lyoko[2];

                        if (Damage > 0)
                        {
                            Zone[z0].Lyoko[0] -= Damage * 3;
                            Zone[z0].Code[4] = true;
                        }

                    }
                }


            }
            if (x20 == 8)
            {

                if (Win == 1)
                {
                    {
                        Zone[y0].Code[2] = true;
                        Zone[z0].Code[2] = true;
                        Zone[z0].Code[3] = true;
                        //Causa 2 de dano puro no fim de cada turno. Pilkim e o inimigo não podem se mover ou atacar até o fim do round. 
                    }
                }


            }
            if (x20 == 9)
            {

                for (int w = 1; w < Zone.Count; w = w + 1)
                {
                    if (Zone[w].idcard1 * e0 < 0)
                    {
                        for (int w1 = 0; w1 < Zone[y0].idzone0.Count; w1 = w1 + 1)
                        {
                            if (Zone[y0].idzone0[w1] == Zone[w].idzone1)
                            {
                                Zone[w].Lyoko[0] -= 2;
                                Zone[w].Code[4] = true;
                            }
                        }
                    }
                }

                if (Win == 1)
                {


                    Zone[z0].Lyoko[0] -= 2;
                    Zone[z0].Code[4] = true;

                    //Atinge todos os inimigos próximos.

                }


            }

            if (x20 == 10)
            {
                if (Win == 1)
                {

                    if (x + Attacking % 2 == 0)
                    {
                        for (int w = 1; w < Zone.Count; w = w + 1)
                        {
                            if (Zone[w].idPersonagem == 3 && Zone[w].idcard1 > 0)
                            {
                                Zone[w].lv1 += 1;
                            }
                        }
                    }
                    if (x + Attacking % 2 == 1)
                    {
                        for (int w = 1; w < Zone.Count; w = w + 1)
                        {
                            if (Zone[w].idPersonagem == 3 && Zone[w].idcard1 < 0)
                            {
                                Zone[w].lv1 += 1;
                            }
                        }
                    }
                    // Aumenta o nível do Come-Pedras

                }


            }
            if (x20 == 17)
            {

                if (Win == 1)
                {
                    {
                        Zone[z0].Lyoko[0] -= 4;
                        Zone[z0].Code[4] = true;
                    }
                }


            }
            if (x20 == 18)
            {

                if (Win == 1)
                {

                    Damage = 7 - Zone[z0].Lyoko[2];

                    if (Damage > 0)
                    {
                        Zone[z0].Lyoko[0] -= Damage;
                        Zone[z0].Code[4] = true;
                        Zone[y0].Code[1] = true;
                        //Oponente toma dano na primeira vez que se move
                    }


                }

            }
            if (x20 == 19)//TeemoAF
            {


                if (Win == 1)
                {

                    Attack();
                    DamageAttribute(1, 1, false);
                }


            }
            if (x20 == 20)//Anivia AF
            {
                if (Win == 1)
                {

                    if (Zone[z0].Mana == 0)
                    {
                        NormalDamage((Zone[y0].Lyoko[1] - Zone[z0].Lyoko[2]) * 2);
                    }
                    else
                    {
                        Attack();
                    }


                }

            }
            if (x20 == 21)//KalistaAR
            {

                {
                    if (Win == 1)
                    {
                        if (Zone[y0].Mana == 0)
                        {
                            NormalDamage(10);
                        }
                        else
                        {
                            NormalDamage(8);
                        }


                    }
                }
            }
            if (x20 == 22)//VladAR
            {


                if (Win == 1)
                {

                    Attack();
                    UpAttribute(2, 1, true);

                }

            }
            if (x20 == 23)//LeeAR
            {
                if (Win == 1)
                {


                    if (Zone[y0].side == 1)
                    {

                        a.SetEffectValue(8, 11, Zone[y0].Lyoko[1]);

                    }

                    if (Zone[y0].side == -1)
                    {

                        a.SetEffectValue(9, 12, Zone[y0].Lyoko[1]);


                    }
                    Attack();

                }

            }
            if (x20 == 24)//FioraAR
            {


                if (Win == 1)
                {
                    Attack();
                    Attack();


                }



            }


            //Bloqueios Ally
            if (x30 == 2)
            {

                Zone[y0].Lyoko1[2] += 3;
                Zone[y0].Lyoko[2] += 3;
                Damage = 3;
                c6.Add(7);
                target = 1;
                X3();

            }

            if (x30 == 3)
            {

                Zone[y0].Lyoko[2] += 3;
                Zone[y0].Lyoko[1] -= 3;
                c6.Add(7);
                target = 1;
                X3();
                c6.Add(3);
                target = 1;
                X3();


            }

            if (x30 == 4)
            {


            }
            if (x30 == 5)
            {

            }
            if (x30 == 6)
            {

            }

            if (x30 == 12)
            {

            }

            if (x30 == 15)
            {

            }

            if (x30 == 16)
            {

            }

            if (x30 == 17)//AniviaB
            {
                Zone[y0].Code[5] = true;
            }
            if (x30 == 18)//KalistaB
            {

                if (Win == 1)
                {
                    for (int w = 1; w < Zone.Count; w = w + 1)
                    {
                        if (Zone[w].Code[6] == true && (Zone[y0].side * Zone[w].side > 0))
                        {
                            NormalDamage(Zone[w].Lyoko[1]);
                        }

                    }

                }


            }

            if (x30 == 19)//LeeB
            {

                Zone[y0].Code[7] = true;


            }

            if (x30 == 20)//Fiora
            {


                if (Win == 1)
                {

                    TrueDamage(1);
                    if (Zone[y0].Mana == 0)
                    {
                        DamageMana(3);
                    }
                    else
                    {
                        DamageMana(1);
                    }
                }



            }




            //Esquivas Ally
            if (x40 == 1)
            {


                if (Win == 1)
                {
                    {
                        // Invoca um boneco que morre no inicio do combate
                    }
                }

            }
            if (x40 == 2)
            {

                if (Win == 1)
                {
                    {
                        // Se move no fim do combate
                    }
                }

            }
            if (x40 == 3)
            {

                Zone[y0].Lyoko[0] += 2;
                Zone[y0].Lyoko[1] += 2;
                Zone[y0].Lyoko[2] += 2;


            }
            if (x40 == 4)
            {

                if (Win == 1)
                {
                    {
                        Zone[z0].Lyoko[1] -= 4;
                        if (Zone[z0].Lyoko[1] == 0)
                        {
                            Zone[z0].Lyoko[1] = 0;
                        }
                    }
                }

            }
            if (x40 == 5)
            {

                if (Win == 1)
                {
                    {
                        Zone[y0].up = 1;
                        Zone[y0].Code[0] = true;
                        //Ganha um nivel caso não sofra dano até o fim do round
                    }
                }

            }

            if (x40 == 11)
            {

                Zone[y0].Lyoko[0] += 6;
                Zone[y0].Lyoko1[0] += 6;

            }

            if (x40 == 12)
            {
                if (Win == 1)
                {
                    {
                        if ((b1 == 1 && b8 == 0) || (b2 == 1 && b7 == 0))
                        {
                            Zone[z0].Lyoko[0] -= 4;
                            Zone[z0].Code[4] = true;
                        }
                    }
                }

            }
            if (x40 == 13)
            {

                Zone[y0].Lyoko[1] += 1;
                Zone[y0].Lyoko[2] += 1;
                Zone[y0].Lyoko[3] += 1;

            }
            if (x40 == 14)
            {

                if (Win == 1)
                {
                    Zone[y0].up = 1;
                    Zone[y0].Code[0] = true;
                    //Sobe de nível se não tomar dano até o fim do round
                }

            }
            if (x40 == 15)//TeemoD
            {

                if (Win == 1)
                {
                    UpAttribute(2, 1, false);
                }

            }
            if (x40 == 16)//AniviaD
            {


                if (Win == 1)
                {
                    NormalDamage(5);
                    DamageMana(1);

                }

            }
            if (x40 == 17)//KalistaD
            {

                if (Win == 1)
                {
                    NormalDamage(5);

                }

            }

            if (x40 == 18)//VladD
            {

                TrueDamageAlly(1);
                if (Win == 1)
                {
                    TrueDamage(3);

                }


            }

            if (x40 == 19)//LeeD
            {



                if (Win == 1)
                {

                    al.Clear();
                    for (int w = 1; w < Zone.Count; w = w + 1)
                    {
                        if (Zone[w].idcard1 * card10 > 0 && (Zone[w].idcard1 != 25 || Zone[w].idcard1 != -25))
                        {
                            al.Add(w);

                        }
                    }
                    sla = Random.Range(0, al.Count);
                    sla = al[sla];
                    Zone[sla].Lyoko[2] += 2;
                    a.SetEffectValue(5, sla, 2);
                }

            }
            if (x40 == 20)
            {


                if (Win == 1)
                {
                    TrueDamage(2);
                }




            }



            //ExChange(x);
            /*if ((Attacking + x) % 2 == 0)
            {
                x1 = x10;
                x2 = x20;
                x3 = x30;
                x4 = x40;
                x5 = x50;
                x6 = x60;
                x7 = x70;
                x8 = x80;

                b1 = b10;
                b2 = b20;
                b3 = b30;
                b4 = b40;
                b5 = b50;
                b6 = b60;
                b7 = b70;
                b8 = b80;

                y = y0;
                z = z0;
                card1 = card10;
                card2 = card20;
            }
            if ((Attacking + x) % 2 == 1)
            {
                x5 = x10;
                x6 = x20;
                x7 = x30;
                x8 = x40;
                x1 = x50;
                x2 = x60;
                x3 = x70;
                x4 = x80;

                b5 = b10;
                b6 = b20;
                b7 = b30;
                b8 = b40;
                b1 = b50;
                b2 = b60;
                b3 = b70;
                b4 = b80;

                z = y0;
                y = z0;
                card2 = card10;
                card1 = card20;
            

            }
            */
        }
        //Efeitos De Fim de combate
        Vlad = 0;
        Devil = 0;
        for (int x = 1; x < 11; x = x + 1)
        {
            //Se você tomou dano
            if (Zone[x].Code[4] == true)
            {
                Zone[x].Code[0] = false;
                Zone[x].Code[4] = false;
            }
        }
        D.B();
    }

    public void B()
    {
        i1.SetActive(true);
        i2.SetActive(true);
        if (k + 1 <= c1.Count)
        {
            Eye1.SetActive(true);
            if (c11[k] == 1)
            {
                Eye.sprite = D.AttackS[c8[k]].sprite;
                Eye2.text = D.AttackS[c8[k]].Texto0;

            }
            if (c11[k] == 2)
            {
                Eye.sprite = D.AttackQ[c8[k]].sprite;
                Eye2.text = D.AttackQ[c8[k]].Texto0;

            }
            if (c11[k] == 3)
            {
                Eye.sprite = D.Block[c8[k]].sprite;
                Eye2.text = D.Block[c8[k]].Texto0;

            }
            if (c11[k] == 4)
            {
                Eye.sprite = D.Dodge[c8[k]].sprite;
                Eye2.text = D.Dodge[c8[k]].Texto0;


            }
            if (c9[k] == 1)
            {
                anime[c6[k]].SetActive(true);
                if (c10[k] > 0)
                {
                    Value[c6[k]].text = c10[k].ToString();
                }
            }
            if (c9[k] == -1)
            {
                anime1[c6[k]].SetActive(true);
                if (c10[k] > 0)
                {
                    Value1[c6[k]].text = c10[k].ToString();
                }
            }
        }
        else
        {
            c1.Clear();
            c2.Clear();
            c3.Clear();

            c5.Clear();
            c6.Clear();
            c8.Clear();
            c9.Clear();
            c10.Clear();
            c11.Clear();
            c12.Clear();

            k = 0;
            Dark.SetActive(true);
        }
    }
    public void C()
    {
        if (c12[k] == 1)
        {
            AllyT[0].text = c1[k].ToString();
            AllyT[1].text = c2[k].ToString();
            AllyT[2].text = c3[k].ToString();

            AllyT[4].text = c5[k].ToString();
        }
        if (c12[k] == -1)
        {
            EnemyT[0].text = c1[k].ToString();
            EnemyT[1].text = c2[k].ToString();
            EnemyT[2].text = c3[k].ToString();

            EnemyT[4].text = c5[k].ToString();
        }
        k += 1;
        B();
    }
    public void X1()
    {
        if (target == 1)
        {
            c1.Add(Zone[y0].Lyoko[0]);
            c2.Add(Zone[y0].Lyoko[1]);
            c3.Add(Zone[y0].Lyoko[2]);

            c5.Add(Zone[y0].Mana);
        }
        if (target == -1)
        {
            c1.Add(Zone[z0].Lyoko[0]);
            c2.Add(Zone[z0].Lyoko[1]);
            c3.Add(Zone[z0].Lyoko[2]);

            c5.Add(Zone[z0].Mana);
        }

        c8.Add(x10);
        c9.Add(e0);
        c10.Add(Damage);
        c11.Add(1);
        c12.Add(e0 * target);

    }
    public void X2()
    {
        if (target == 1)
        {
            c1.Add(Zone[y0].Lyoko[0]);
            c2.Add(Zone[y0].Lyoko[1]);
            c3.Add(Zone[y0].Lyoko[2]);

            c5.Add(Zone[y0].Mana);
        }
        if (target == -1)
        {
            c1.Add(Zone[z0].Lyoko[0]);
            c2.Add(Zone[z0].Lyoko[1]);
            c3.Add(Zone[z0].Lyoko[2]);

            c5.Add(Zone[z0].Mana);
        }

        c8.Add(x20);
        c9.Add(e0);
        c10.Add(Damage);
        c11.Add(2);
        c12.Add(e0 * target);

    }
    public void X3()
    {
        if (target == 1)
        {
            c1.Add(Zone[y0].Lyoko[0]);
            c2.Add(Zone[y0].Lyoko[1]);
            c3.Add(Zone[y0].Lyoko[2]);

            c5.Add(Zone[y0].Mana);
        }
        if (target == -1)
        {
            c1.Add(Zone[z0].Lyoko[0]);
            c2.Add(Zone[z0].Lyoko[1]);
            c3.Add(Zone[z0].Lyoko[2]);

            c5.Add(Zone[z0].Mana);
        }

        c8.Add(x30);
        c9.Add(e0);
        c10.Add(Damage);
        c11.Add(3);
        c12.Add(e0 * target);

    }
    public void X4()
    {
        if (target == 1)
        {
            c1.Add(Zone[y0].Lyoko[0]);
            c2.Add(Zone[y0].Lyoko[1]);
            c3.Add(Zone[y0].Lyoko[2]);

            c5.Add(Zone[y0].Mana);
        }
        if (target == -1)
        {
            c1.Add(Zone[z0].Lyoko[0]);
            c2.Add(Zone[z0].Lyoko[1]);
            c3.Add(Zone[z0].Lyoko[2]);

            c5.Add(Zone[z0].Mana);
        }

        c8.Add(x40);
        c9.Add(e0);
        c10.Add(Damage);
        c11.Add(4);
        c12.Add(e0 * target);

    }
    public void E()
    {
        t1[0].SetActive(true);
        t1[1].SetActive(true);
        t[0].Play("draca");
        t[1].Play("draca");
    }
    public void G()
    {
        D.p1 = y;
        D.p2 = z;
    }
    public void ExChange(int x)
    {
        if ((Attacking + x) % 2 == 0)
        {
            x10 = x1;
            x20 = x2;
            x30 = x3;
            x40 = x4;
            x50 = x5;
            x60 = x6;
            x70 = x7;
            x80 = x8;

            /*b10 = b1;
            b20 = b2;
            b30 = b3;
            b40 = b4;
            b50 = b5;
            b60 = b6;
            b70 = b7;
            b80 = b8;
            */

            y0 = y;
            z0 = z;
            card10 = card1;
            card20 = card2;
            e0 = e;
            Win = AllyWin;
        }
        if ((Attacking + x) % 2 == 1)
        {
            x10 = x5;
            x20 = x6;
            x30 = x7;
            x40 = x8;
            x50 = x1;
            x60 = x2;
            x70 = x3;
            x80 = x4;

            /*b10 = b5;
            b20 = b6;
            b30 = b7;
            b40 = b8;
            b50 = b1;
            b60 = b2;
            b70 = b3;
            b80 = b4;
            */
            y0 = z;
            z0 = y;
            card10 = card2;
            card20 = card1;
            e0 = e1;
            Win = EnemyWin;
        }
    }


    public void Attack()
    {
        Damage = Zone[y0].Lyoko[1] - Zone[z0].Lyoko[2];
        if (Damage > 0)
        {
            Zone[z0].Lyoko[0] -= Damage;
            Zone[z0].Code[4] = true;

            c6.Add(1);
            target = -1;
            X();
            DrainLife();
        }
        else
        {
            Damage = 0;
        }

    }
    public void AttackTrue()
    {
        Damage = Zone[y0].Lyoko[1];

        if (Damage > 0)
        {
            Zone[z0].Lyoko[0] -= Damage;
            Zone[z0].Code[4] = true;

            c6.Add(1);
            target = -1;
            X1();
            DrainLife();
        }
        else
        {
            Damage = 0;
        }

    }

    public void DrainLife()
    {
        if (Zone[y0].Code[7] == true)
        {
            Zone[y0].Lyoko[0] += Damage;
            if (Zone[y0].Lyoko[0] > Zone[y0].Lyoko1[0] + Zone[y0].Lyoko2[0])
            {
                Zone[y0].Lyoko[0] = Zone[y0].Lyoko1[0] + Zone[y0].Lyoko2[0];
            }
            c6.Add(6);
            target = 1;
            X();
        }
    }
    public void TrueDamage(int a)
    {
        Damage = a;

        if (Damage > 0)
        {
            Zone[z0].Lyoko[0] -= Damage;
            Zone[z0].Code[4] = true;

            c6.Add(1);
            target = -1;
            X();
            DrainLife();
        }
        else
        {
            Damage = 0;
        }
    }
    public void TrueDamageAlly(int a)
    {
        Damage = a;

        if (Damage > 0)
        {
            Zone[y0].Lyoko[0] -= Damage;
            Zone[y0].Code[4] = true;

            c6.Add(11);
            target = 1;
            X();
        }
        else
        {
            Damage = 0;
        }
    }

    public void NormalDamage(int a)
    {
        Damage = a - Zone[z0].Lyoko[2];

        if (Damage > 0)
        {
            Zone[z0].Lyoko[0] -= Damage;
            Zone[z0].Code[4] = true;

            c6.Add(1);
            target = -1;
            X();
            DrainLife();
        }
        else
        {
            Damage = 0;
        }
    }
    public void UpAttribute(int a, int attribute, bool permanent)
    {
        Damage = a;
        if (Damage > 0)
        {
            Zone[y0].Lyoko[attribute] += Damage;
            if (permanent == true)
            {
                Zone[y0].Lyoko1[attribute] += Damage;
            }
            if (attribute == 0)
            {
                c6.Add(6);
            }
            if (attribute == 1)
            {
                c6.Add(8);
            }
            if (attribute == 2)
            {
                c6.Add(7);
            }

            target = 1;
            X();
        }
        else
        {
            Damage = 0;
        }
    }
    public void DamageAttribute(int a, int attribute, bool permanent)
    {
        Damage = a;
        if (permanent == true)
        {
            Zone[z0].Lyoko1[attribute] -= Damage;
        }
        if (Damage > Zone[z0].Lyoko[attribute])
        {
            Damage = Zone[z0].Lyoko[attribute];
        }
        if (Damage > 0)
        {
            Zone[z0].Lyoko[attribute] -= Damage;

            if (attribute == 0)
            {
                c6.Add(1);
            }
            if (attribute == 1)
            {
                c6.Add(3);
            }
            if (attribute == 2)
            {
                c6.Add(2);
            }

            target = -1;
            X();
        }
        else
        {
            Damage = 0;
        }
    }
    public void DamageMana(int a)
    {
        Damage = a;
        if (Damage > Zone[z0].Mana)
        {
            Damage = Zone[z0].Mana;
        }
        if (Damage > 0)
        {
            Zone[z0].Mana -= Damage;


            c6.Add(5);


            target = -1;
            X();
        }
        else
        {
            Damage = 0;
        }
    }
    public void DuelistF(int a)
    {
        duelist = true;
        for (int x = 0; x < Zone[a].idzone0.Count; x = x + 1)
        {
            if (Zone[Zone[a].idzone0[x]].idcard1*Zone[a].idcard1 > 0)
            {
                duelist = false;
            }

        }
    }
    public void PactF(int a)
    {
        pact = 0;
        for (int x = 1; x < 11; x = x + 1)
        {
            if(Zone[x].Code[6]==true && Zone[x].idcard1 * Zone[a].idcard1 > 0)
            {
                pact += 1;
            }
        }
    }
    public void X()
    {
        if (x10 > 0)
        {
            X1();
        }
        else if (x20 > 0)
        {
            X2();
        }
        else if (x30 > 0)
        {
            X3();
        }
        else if (x40 > 0)
        {
            X4();
        }
    }
}
