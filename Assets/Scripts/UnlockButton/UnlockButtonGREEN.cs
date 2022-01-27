using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockButtonGREEN : MonoBehaviour
{
    public GameObject unlockBtn;
    float coins;
    public float cost = 200;
    int unlockedGreen;

    void Update()
    {
        coins = PlayerPrefs.GetFloat("coins");
        unlockedGreen = PlayerPrefs.GetInt("unlockedGreen");

        //GREEN
        if (unlockedGreen > 1)
        {
            unlockBtn.SetActive(true);
        }
        else
        {
            unlockBtn.SetActive(false);
        }
    }

    public void UnlockBtnGREEN(GameObject unlockBtn)
    {
        if (coins >= cost)
        {
            unlockBtn.SetActive(true);
            PlayerPrefs.SetInt("unlockedGreen", 2);
            Debug.Log("Shit2.5");
        }
        else
        {
            Debug.Log("Shit3.5");
        }
    }

    public void BuyColorGREEN(float cost)
    {
        if (coins >= cost)
        {
            coins -= 500;
            PlayerPrefs.SetFloat("coins", coins);
            Debug.Log("Shit2");
        }
        else
        {
            Debug.Log("Shit3");
        }
    }
}
