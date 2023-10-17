using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopAutoClick : MonoBehaviour
{
    [SerializeField] private int[] autoClick;
    private int moneys;
    private int autoClicking;

    private void Update()
    {
        moneys = PlayerPrefs.GetInt("moneys");
        autoClicking = PlayerPrefs.GetInt("aC");
    }
    public void BuyAutoClick()
    {
        if (PlayerPrefs.GetInt("moneys") >= autoClick[0])
        {
            moneys -= autoClick[0];
            autoClicking += 1;
            PlayerPrefs.SetInt("moneys", 0 + moneys);
            PlayerPrefs.SetInt("aC", 0 + autoClicking);
        }
    }
    public void BuyAutoClick1()
    {
        if (PlayerPrefs.GetInt("moneys") >= autoClick[1])
        {
            moneys -= autoClick[1];
            autoClicking += 2;
            PlayerPrefs.SetInt("moneys", 0 + moneys);
            PlayerPrefs.SetInt("aC", 0 + autoClicking);
        }
    }
    public void BuyAutoClick2()
    {
        if (PlayerPrefs.GetInt("moneys") >= autoClick[2])
        {
            moneys -= autoClick[2];
            autoClicking += 3;
            PlayerPrefs.SetInt("moneys", 0 + moneys);
            PlayerPrefs.SetInt("aC", 0 + autoClicking);
        }
    }
    public void BuyAutoClick3()
    {
        if (PlayerPrefs.GetInt("moneys") >= autoClick[3])
        {
            moneys -= autoClick[3];
            autoClicking += 4;
            PlayerPrefs.SetInt("moneys", 0 + moneys);
            PlayerPrefs.SetInt("aC", 0 + autoClicking);
        }
    }
}
