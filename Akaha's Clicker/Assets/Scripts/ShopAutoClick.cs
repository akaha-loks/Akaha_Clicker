using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShopAutoClick : MonoBehaviour
{
    [SerializeField] private int[] autoClick;
    [SerializeField] private int[] autoClicks = { 1000, 2000, 5000, 8000 };
    public Text[] texts;
    private int moneys;
    private int autoClicking;

    private void Start()
    {
        if (PlayerPrefs.GetInt("aCShop") == 0)
        {
            PlayerPrefs.SetInt("aCShop", autoClicks[0]);
        }
        if (PlayerPrefs.GetInt("aCShop1") == 0)
        {
            PlayerPrefs.SetInt("aCShop1", autoClicks[1]);
        }
        if (PlayerPrefs.GetInt("aCShop2") == 0)
        {
            PlayerPrefs.SetInt("aCShop2", autoClicks[2]);
        }
        if (PlayerPrefs.GetInt("aCShop3") == 0)
        {
            PlayerPrefs.SetInt("aCShop3", autoClicks[3]);
        }
    }
    private void FixedUpdate()
    {
        moneys = PlayerPrefs.GetInt("moneys");
        autoClicking = PlayerPrefs.GetInt("aC");
        autoClicks[0] = PlayerPrefs.GetInt("aCShop");
        autoClicks[1] = PlayerPrefs.GetInt("aCShop1");
        autoClicks[2] = PlayerPrefs.GetInt("aCShop2");
        autoClicks[3] = PlayerPrefs.GetInt("aCShop3");
       
        texts[0].text = "јвто лик + 1 " + autoClicks[0] + "$";
        texts[1].text = "јвто лик + 2 " + autoClicks[1] + "$";
        texts[2].text = "јвто лик + 3 " + autoClicks[2] + "$";
        texts[3].text = "јвто лик + 4 " + autoClicks[3] + "$";
    }
    public void BuyAutoClick()
    {
        if (PlayerPrefs.GetInt("moneys") >= autoClicks[0])
        {
            moneys -= autoClicks[0];
            autoClicking += 1;
            PlayerPrefs.SetInt("moneys", 0 + moneys);
            PlayerPrefs.SetInt("aC", 0 + autoClicking);
            
            autoClick[0] = PlayerPrefs.GetInt("aCShop");           
            PlayerPrefs.SetInt("aCShop", autoClicks[0] + autoClick[0]);
            autoClick[1] = PlayerPrefs.GetInt("aCShop1");
            PlayerPrefs.SetInt("aCShop1", autoClicks[1] + autoClick[1]);
            autoClick[2] = PlayerPrefs.GetInt("aCShop2");
            PlayerPrefs.SetInt("aCShop2", autoClicks[2] + autoClick[2]);
            autoClick[3] = PlayerPrefs.GetInt("aCShop3");
            PlayerPrefs.SetInt("aCShop3", autoClicks[3] + autoClick[3]);
        }
    }
    public void BuyAutoClick1()
    {
        if (PlayerPrefs.GetInt("moneys") >= autoClicks[1])
        {
            moneys -= autoClicks[1];
            autoClicking += 2;
            PlayerPrefs.SetInt("moneys", 0 + moneys);
            PlayerPrefs.SetInt("aC", 0 + autoClicking);

            autoClick[1] = PlayerPrefs.GetInt("aCShop1");
            PlayerPrefs.SetInt("aCShop1", autoClicks[1] + autoClick[1]);
            autoClick[0] = PlayerPrefs.GetInt("aCShop");
            PlayerPrefs.SetInt("aCShop", autoClicks[0] + autoClick[0]);
            autoClick[2] = PlayerPrefs.GetInt("aCShop2");
            PlayerPrefs.SetInt("aCShop2", autoClicks[2] + autoClick[2]);
            autoClick[3] = PlayerPrefs.GetInt("aCShop3");
            PlayerPrefs.SetInt("aCShop3", autoClicks[3] + autoClick[3]);
        }
    }
    public void BuyAutoClick2()
    {
        if (PlayerPrefs.GetInt("moneys") >= autoClicks[2])
        {
            moneys -= autoClicks[2];
            autoClicking += 3;
            PlayerPrefs.SetInt("moneys", 0 + moneys);
            PlayerPrefs.SetInt("aC", 0 + autoClicking);

            autoClick[2] = PlayerPrefs.GetInt("aCShop2");
            PlayerPrefs.SetInt("aCShop2", autoClicks[2] + autoClick[2]);
            autoClick[0] = PlayerPrefs.GetInt("aCShop");
            PlayerPrefs.SetInt("aCShop", autoClicks[0] + autoClick[0]);
            autoClick[1] = PlayerPrefs.GetInt("aCShop1");
            PlayerPrefs.SetInt("aCShop1", autoClicks[1] + autoClick[1]);
            autoClick[3] = PlayerPrefs.GetInt("aCShop3");
            PlayerPrefs.SetInt("aCShop3", autoClicks[3] + autoClick[3]);
        }
    }
    public void BuyAutoClick3()
    {
        if (PlayerPrefs.GetInt("moneys") >= autoClicks[3])
        {
            moneys -= autoClicks[3];
            autoClicking += 4;
            PlayerPrefs.SetInt("moneys", 0 + moneys);
            PlayerPrefs.SetInt("aC", 0 + autoClicking);

            autoClick[3] = PlayerPrefs.GetInt("aCShop3");
            PlayerPrefs.SetInt("aCShop3", autoClicks[3] + autoClick[3]);
            autoClick[0] = PlayerPrefs.GetInt("aCShop");
            PlayerPrefs.SetInt("aCShop", autoClicks[0] + autoClick[0]);
            autoClick[1] = PlayerPrefs.GetInt("aCShop1");
            PlayerPrefs.SetInt("aCShop1", autoClicks[1] + autoClick[1]);
            autoClick[2] = PlayerPrefs.GetInt("aCShop2");
            PlayerPrefs.SetInt("aCShop2", autoClicks[2] + autoClick[2]);
        }
    }
}
