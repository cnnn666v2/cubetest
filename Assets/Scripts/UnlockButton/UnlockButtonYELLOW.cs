using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockButtonYELLOW : MonoBehaviour
{
    public GameObject unlockBtn;
    float coins;
    public float cost = 200;
    int unlockedYellow;

    void Update()
    {
        coins = PlayerPrefs.GetFloat("coins");
        unlockedYellow = PlayerPrefs.GetInt("unlockedYellow");

        //GREEN
        if (unlockedYellow > 1)
        {
            unlockBtn.SetActive(true);
        }
        else
        {
            unlockBtn.SetActive(false);
        }
    }

    public void UnlockBtnYELLOW(GameObject unlockBtn)
    {
        if (coins >= cost)
        {
            unlockBtn.SetActive(true);
            PlayerPrefs.SetInt("unlockedYellow", 4);
            Debug.Log("Shit2.5");
        }
        else
        {
            Debug.Log("Shit3.5");
        }
    }

    public void BuyColorYELLOW(float cost)
    {
        if (coins >= cost)
        {
            coins -= cost;
            PlayerPrefs.SetFloat("coins", coins);
            Debug.Log("Shit2");
            PlayerPrefs.SetInt("unlockedYellow", 4);
        }
        else
        {
            Debug.Log("Shit3");
        }
    }
}
