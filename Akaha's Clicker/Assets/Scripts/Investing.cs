using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Investing : MonoBehaviour
{
    [SerializeField] private int[] invest;
    private int result;
    private int moneys;
    private int investing;

    private void FixedUpdate()
    {
        moneys = PlayerPrefs.GetInt("moneys");
    }
    public void GetInvest()
    {
        if (PlayerPrefs.GetInt("moneys") >= invest[0])
        {
            result = Random.Range(0, 100);
            investing = Random.Range(0, 200);
            if (result >= 90)
            {
                moneys += moneys;
                PlayerPrefs.SetInt("moneys", 0 + moneys);
            }
            if (result < 90)
            {
                moneys -= moneys + invest[0] + investing;
                PlayerPrefs.SetInt("moneys", 0 + moneys);
            }
        }
    }
    public void GetInvest1()
    {
        if (PlayerPrefs.GetInt("moneys") >= invest[1])
        {
            result = Random.Range(0, 100);
            investing = Random.Range(0, 500);
            if (result >= 70)
            {
                moneys += moneys;
                PlayerPrefs.SetInt("moneys", 0 + moneys);
            }
            if (result < 70)
            {
                moneys -= moneys + invest[1] + investing;
                PlayerPrefs.SetInt("moneys", 0 + moneys);
            }
        }
    }
    public void GetInvest2()
    {
        if (PlayerPrefs.GetInt("moneys") >= invest[2])
        {
            result = Random.Range(0, 100);
            investing = Random.Range(0, 800);
            if (result >= 50)
            {
                moneys += moneys;
                PlayerPrefs.SetInt("moneys", 0 + moneys);
            }
            if (result < 50)
            {
                moneys -= moneys + invest[2] + investing;
                PlayerPrefs.SetInt("moneys", 0 + moneys);
            }
        }
    }
    public void GetInvest3()
    {
        if (PlayerPrefs.GetInt("moneys") >= invest[3])
        {
            result = Random.Range(0, 100);
            investing = Random.Range(0, 1500);
            if (result >= 30)
            {
                moneys += moneys;
                PlayerPrefs.SetInt("moneys", 0 + moneys);
            }
            if (result < 30)
            {
                moneys -= moneys + invest[3] + investing;
                PlayerPrefs.SetInt("moneys", 0 + moneys);
            }
        }
    }

}
