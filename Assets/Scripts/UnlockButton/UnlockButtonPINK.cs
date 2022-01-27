using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockButtonPINK : MonoBehaviour
{
    public GameObject unlockBtn;
    float coins;
    public float cost = 200;
    int unlockedPink;

    void Update()
    {
        coins = PlayerPrefs.GetFloat("coins");
        unlockedPink = PlayerPrefs.GetInt("unlockedPink");

        //GREEN
        if (unlockedPink > 1)
        {
            unlockBtn.SetActive(true);
        }
        else
        {
            unlockBtn.SetActive(false);
        }
    }

    public void UnlockBtnPINK(GameObject unlockBtn)
    {
        if (coins >= cost)
        {
            unlockBtn.SetActive(true);
            PlayerPrefs.SetInt("unlockedPink", 2);
            Debug.Log("Shit2.5");
        }
        else
        {
            Debug.Log("Shit3.5");
        }
    }

    public void BuyColorPINK(float cost)
    {
        if (coins >= cost)
        {
            coins -= cost;
            PlayerPrefs.SetFloat("coins", coins);
            Debug.Log("Shit2");
            PlayerPrefs.SetInt("unlockedPink", 2);
        }
        else
        {
            Debug.Log("Shit3");
        }
    }
}
