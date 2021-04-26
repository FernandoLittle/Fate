using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Select : MonoBehaviour

{
    public int id;
    public List<int> idL;
    public List<int> idList0;
    public List<int> idList;
    public List<string> Descripts;
    public List<Sprite> sprites;
    public Image ChampionI;
    public Text Descript;
    public List<Sprite> Stats;
    public Image Stat;
    public List<Button> LBut;
    public int IntBut;
    public List<Ident> Idents;
    public List<GameObject> GO;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Selecto()
    {
        GO[0].SetActive(true);
        GO[1].SetActive(true);
        GO[2].SetActive(true);
        GO[3].SetActive(true);
        GO[4].SetActive(false);

        if (IntBut >= 3)
        {
            GO[4].SetActive(true);
            GO[3].SetActive(false);
            for (int x = 0; x < LBut.Count; x = x + 1)
            {
                if (Idents[x].S == true)
                {
                    LBut[x].enabled = true;
                }
                else
                {

                    LBut[x].enabled = false;
                }
            }
        }
        else
        {
            for (int x = 0; x < LBut.Count; x = x + 1)
            {

                LBut[x].enabled = true;

            }
        }
        Descript.text = Descripts[id];
        Stat.sprite = Stats[id];
        ChampionI.sprite = sprites[id];

    }
    public void Play()
    {

        PlayerPrefs.SetInt("Card1", idL[idList[0]]);
        PlayerPrefs.SetInt("Card2", idL[idList[1]]);
        PlayerPrefs.SetInt("Card3", idL[idList[2]]);
        PlayerPrefs.SetInt("Card4", idL[idList0[0]]);
        PlayerPrefs.SetInt("Card5", idL[idList0[1]]);
        PlayerPrefs.SetInt("Card6", idL[idList0[2]]);
        //SceneManager.LoadScene("Battle");

    }
}
