using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Investing : MonoBehaviour
{
    [SerializeField] private int[] invest;
    [SerializeField] private int[] invests = {200, 500, 800, 1500};
    public Text[] texts;
    private int result;
    private int moneys;

    private void Start()
    {
        if (PlayerPrefs.GetInt("inv") == 0)
        {
            PlayerPrefs.SetInt("inv", invests[0]);
        }
        if (PlayerPrefs.GetInt("inv1") == 0)
        {
            PlayerPrefs.SetInt("inv1", invests[1]);
        }
        if (PlayerPrefs.GetInt("inv2") == 0)
        {
            PlayerPrefs.SetInt("inv2", invests[2]);
        }
        if (PlayerPrefs.GetInt("inv3") == 0)
        {
            PlayerPrefs.SetInt("inv3", invests[3]);
        }
    }
    private void FixedUpdate()
    {
        moneys = PlayerPrefs.GetInt("moneys");

        invests[0] = PlayerPrefs.GetInt("inv");
        invests[1] = PlayerPrefs.GetInt("inv1");
        invests[2] = PlayerPrefs.GetInt("inv2");
        invests[3] = PlayerPrefs.GetInt("inv3");

        



        texts[0].text = "Инвестировать в Shoro " + invests[0] + "$";
        texts[1].text = "Инвестировать в Fanta " + invests[1] + "$";
        texts[2].text = "Инвестировать в Pepsi " + invests[2] + "$";
        texts[3].text = "Инвестировать в Coca-Cola " + invests[3] + "$";
    }
    public void GetInvest()
    {
        if (PlayerPrefs.GetInt("moneys") >= invests[0] && invests[0] !> 1)
        {
            result = Random.Range(0, 100);
            if (result >= 50)
            {
                moneys += invests[0];
                PlayerPrefs.SetInt("moneys", 0 + moneys);

                invests[0] = PlayerPrefs.GetInt("inv");
                PlayerPrefs.SetInt("inv", invests[0] + invest[0]);
            }
            if (result < 50)
            {
                moneys -= invests[0];
                PlayerPrefs.SetInt("moneys", 0 + moneys);
                
                invests[0] = PlayerPrefs.GetInt("inv");
                PlayerPrefs.SetInt("inv", invests[0] - invest[0]);
            }
        }
    }
    public void GetInvest1()
    {
        if (PlayerPrefs.GetInt("moneys") >= invests[1] && invests[1] !> 1)
        {
            result = Random.Range(0, 100);
            if (result >= 50)
            {
                moneys += invests[1];
                PlayerPrefs.SetInt("moneys", 0 + moneys);

                invests[1] = PlayerPrefs.GetInt("inv1");
                PlayerPrefs.SetInt("inv1", invests[1] + invest[1]);
            }
            if (result < 50)
            {
                moneys -= invests[1];
                PlayerPrefs.SetInt("moneys", 0 + moneys);

                invests[1] = PlayerPrefs.GetInt("inv1");
                PlayerPrefs.SetInt("inv1", invests[1] - invest[1]);
            }
        }
    }
    public void GetInvest2()
    {
        if (PlayerPrefs.GetInt("moneys") >= invests[2] && invests[2] !> 1)
        {
            result = Random.Range(0, 100);
            if (result >= 50)
            {
                moneys += invests[2];
                PlayerPrefs.SetInt("moneys", 0 + moneys);

                invests[2] = PlayerPrefs.GetInt("inv2");
                PlayerPrefs.SetInt("inv2", invests[2] + invest[2]);
            }
            if (result < 50)
            {
                moneys -= invests[2];
                PlayerPrefs.SetInt("moneys", 0 + moneys);

                invests[2] = PlayerPrefs.GetInt("inv2");
                PlayerPrefs.SetInt("inv2", invests[2] - invest[2]);
            }
        }
    }
    public void GetInvest3()
    {
        if (PlayerPrefs.GetInt("moneys") >= invests[3] && invests[3] !> 1)
        {
            result = Random.Range(0, 100);
            if (result >= 50)
            {
                moneys += invests[3];
                PlayerPrefs.SetInt("moneys", 0 + moneys);

                invests[3] = PlayerPrefs.GetInt("inv3");
                PlayerPrefs.SetInt("inv3", invests[3] + invest[3]);
            }
            if (result < 50)
            {
                moneys -= invests[3];
                PlayerPrefs.SetInt("moneys", 0 + moneys);

                invests[3] = PlayerPrefs.GetInt("inv3");
                PlayerPrefs.SetInt("inv3", invests[3] - invest[3]);
            }
        }
    }

}
