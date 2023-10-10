using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClicksForMoney : MonoBehaviour
{
    [SerializeField] private int moneys;
    [SerializeField] private int getMoney;
    private Text txt;

    private void Start()
    {
        txt = GetComponent<Text>();
        moneys = PlayerPrefs.GetInt("moneys");
    }
    private void Update()
    {
        txt.text = "" + moneys;
    }
    public void Clicking()
    {
        moneys += getMoney;
        PlayerPrefs.SetInt("moneys", 0 + moneys);
    }
}
