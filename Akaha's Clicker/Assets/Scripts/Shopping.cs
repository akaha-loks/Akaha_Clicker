using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shopping : MonoBehaviour
{
    private int moneys;
    [SerializeField] private int[] improvses;
    public ClicksForMoney GetMoney;

    private void Start()
    {

        GetMoney.getMoney = PlayerPrefs.GetInt("getMoney");
    }
    private void Update()
    {
        moneys = PlayerPrefs.GetInt("moneys");
    }
    public void GetBuy()
    {
        if (PlayerPrefs.GetInt("moneys") >= improvses[0])
        {
            moneys -= improvses[0];
            GetMoney.getMoney += 1;
            PlayerPrefs.SetInt("moneys", 0 + moneys);
            PlayerPrefs.SetInt("getMoney", 0 + GetMoney.getMoney);
        }
    }
    public void GetBuy1()
    {
        if (PlayerPrefs.GetInt("moneys") >= improvses[1])
        {
            moneys -= improvses[1];
            GetMoney.getMoney += 2;
            PlayerPrefs.SetInt("moneys", 0 + moneys);
            PlayerPrefs.SetInt("getMoney", 0 + GetMoney.getMoney);
        }
    }
    public void GetBuy2()
    {
        if (PlayerPrefs.GetInt("moneys") >= improvses[2])
        {
            moneys -= improvses[2];
            GetMoney.getMoney += 3;
            PlayerPrefs.SetInt("moneys", 0 + moneys);
            PlayerPrefs.SetInt("getMoney", 0 + GetMoney.getMoney);
        }
    }
    public void GetBuy3()
    {
        if (PlayerPrefs.GetInt("moneys") >= improvses[3])
        {
            moneys -= improvses[3];
            GetMoney.getMoney += 4;
            PlayerPrefs.SetInt("moneys", 0 + moneys);
            PlayerPrefs.SetInt("getMoney", 0 + GetMoney.getMoney);
        }
    }
}