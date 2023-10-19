using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shopping : MonoBehaviour
{
    private int moneys;
    [SerializeField] private int[] improvses;
    [SerializeField] private int[] improvesess = {200, 400, 700, 1000};
    public Text[] texts;
    public ClicksForMoney GetMoney;

    private void Start()
    {

        GetMoney.getMoney = PlayerPrefs.GetInt("getMoney");
        if (PlayerPrefs.GetInt("imprShop") == 0)
        {
            PlayerPrefs.SetInt("imprShop", improvesess[0]);
        }
        if (PlayerPrefs.GetInt("imprShop1") == 0)
        {
            PlayerPrefs.SetInt("imprShop1", improvesess[1]);
        }
        if (PlayerPrefs.GetInt("imprShop2") == 0)
        {
            PlayerPrefs.SetInt("imprShop2", improvesess[2]);
        }
        if (PlayerPrefs.GetInt("imprShop3") == 0)
        {
            PlayerPrefs.SetInt("imprShop3", improvesess[3]);
        }
    }
    private void FixedUpdate()
    {
        moneys = PlayerPrefs.GetInt("moneys");

        improvesess[0] = PlayerPrefs.GetInt("imprShop");
        improvesess[1] = PlayerPrefs.GetInt("imprShop1");
        improvesess[2] = PlayerPrefs.GetInt("imprShop2");
        improvesess[3] = PlayerPrefs.GetInt("imprShop3");

        texts[0].text = "Улучшение + 1 " + improvesess[0] + "$";
        texts[1].text = "Улучшение + 2 " + improvesess[1] + "$";
        texts[2].text = "Улучшение + 3 " + improvesess[2] + "$";
        texts[3].text = "Улучшение + 4 " + improvesess[3] + "$";
    }
    public void GetBuy()
    {
        if (PlayerPrefs.GetInt("moneys") >= improvesess[0])
        {
            moneys -= improvesess[0];
            GetMoney.getMoney += 1;
            PlayerPrefs.SetInt("moneys", 0 + moneys);
            PlayerPrefs.SetInt("getMoney", 0 + GetMoney.getMoney);

            improvses[0] = PlayerPrefs.GetInt("imprShop");
            PlayerPrefs.SetInt("imprShop", improvesess[0] + improvses[0]);
            improvses[1] = PlayerPrefs.GetInt("imprShop1");
            PlayerPrefs.SetInt("imprShop1", improvesess[1] + improvses[1]);
            improvses[2] = PlayerPrefs.GetInt("imprShop2");
            PlayerPrefs.SetInt("imprShop2", improvesess[2] + improvses[2]);
            improvses[3] = PlayerPrefs.GetInt("imprShop3");
            PlayerPrefs.SetInt("imprShop3", improvesess[3] + improvses[3]);
        }
    }
    public void GetBuy1()
    {
        if (PlayerPrefs.GetInt("moneys") >= improvesess[1])
        {
            moneys -= improvesess[1];
            GetMoney.getMoney += 2;
            PlayerPrefs.SetInt("moneys", 0 + moneys);
            PlayerPrefs.SetInt("getMoney", 0 + GetMoney.getMoney);

            improvses[1] = PlayerPrefs.GetInt("imprShop1");
            PlayerPrefs.SetInt("imprShop1", improvesess[1] + improvses[1]);
            improvses[0] = PlayerPrefs.GetInt("imprShop");
            PlayerPrefs.SetInt("imprShop", improvesess[0] + improvses[0]);
            improvses[2] = PlayerPrefs.GetInt("imprShop2");
            PlayerPrefs.SetInt("imprShop2", improvesess[2] + improvses[2]);
            improvses[3] = PlayerPrefs.GetInt("imprShop3");
            PlayerPrefs.SetInt("imprShop3", improvesess[3] + improvses[3]);
        }
    }
    public void GetBuy2()
    {
        if (PlayerPrefs.GetInt("moneys") >= improvesess[2])
        {
            moneys -= improvesess[2];
            GetMoney.getMoney += 3;
            PlayerPrefs.SetInt("moneys", 0 + moneys);
            PlayerPrefs.SetInt("getMoney", 0 + GetMoney.getMoney);

            improvses[2] = PlayerPrefs.GetInt("imprShop2");
            PlayerPrefs.SetInt("imprShop2", improvesess[2] + improvses[2]);
            improvses[0] = PlayerPrefs.GetInt("imprShop");
            PlayerPrefs.SetInt("imprShop", improvesess[0] + improvses[0]);
            improvses[1] = PlayerPrefs.GetInt("imprShop1");
            PlayerPrefs.SetInt("imprShop1", improvesess[1] + improvses[1]);
            improvses[3] = PlayerPrefs.GetInt("imprShop3");
            PlayerPrefs.SetInt("imprShop3", improvesess[3] + improvses[3]);
        }
    }
    public void GetBuy3()
    {
        if (PlayerPrefs.GetInt("moneys") >= improvesess[3])
        {
            moneys -= improvesess[3];
            GetMoney.getMoney += 4;
            PlayerPrefs.SetInt("moneys", 0 + moneys);
            PlayerPrefs.SetInt("getMoney", 0 + GetMoney.getMoney);

            improvses[3] = PlayerPrefs.GetInt("imprShop3");
            PlayerPrefs.SetInt("imprShop3", improvesess[3] + improvses[3]);
            improvses[0] = PlayerPrefs.GetInt("imprShop");
            PlayerPrefs.SetInt("imprShop", improvesess[0] + improvses[0]);
            improvses[1] = PlayerPrefs.GetInt("imprShop1");
            PlayerPrefs.SetInt("imprShop1", improvesess[1] + improvses[1]);
            improvses[2] = PlayerPrefs.GetInt("imprShop2");
            PlayerPrefs.SetInt("imprShop2", improvesess[2] + improvses[2]);
        }
    }
}