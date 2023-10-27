using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClicksForMoney : MonoBehaviour
{
    [SerializeField] private int moneys;
    public int getMoney;
    private int clickAuto;
    private int getAutoClick;
    private Text txt;

    private void Start()
    {
        if (PlayerPrefs.GetInt("getMoney") == 0)
        {
            PlayerPrefs.SetInt("getMoney", 1);
        }
        txt = GetComponent<Text>();
    }
    private void FixedUpdate()
    {
        getMoney = PlayerPrefs.GetInt("getMoney");
        clickAuto = PlayerPrefs.GetInt("aC");
        moneys = PlayerPrefs.GetInt("moneys");
        txt.text = "" + moneys;
        getAutoClick += 1;
        if (getAutoClick >= 30)
        {
            moneys += clickAuto;
            getAutoClick = 0;
            PlayerPrefs.SetInt("moneys", 0 + moneys);
        }
    }
    public void Clicking()
    {
        moneys += getMoney;
        PlayerPrefs.SetInt("moneys", 0 + moneys);
    }
}
