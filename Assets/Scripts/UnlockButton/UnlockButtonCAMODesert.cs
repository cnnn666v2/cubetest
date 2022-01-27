using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockButtonCAMODesert : MonoBehaviour
{
    public GameObject unlockBtn;
    float coins;
    public float cost = 200;
    int unlockedCDesert;

    void Update()
    {
        coins = PlayerPrefs.GetFloat("coins");
        unlockedCDesert = PlayerPrefs.GetInt("unlockedCDesert");

        //GREEN
        if (unlockedCDesert > 1)
        {
            unlockBtn.SetActive(true);
        }
        else
        {
            unlockBtn.SetActive(false);
        }
    }

    public void UnlockButton(GameObject unlockBtn)
    {
        if (coins >= cost)
        {
            unlockBtn.SetActive(true);
            PlayerPrefs.SetInt("unlockedCDesert", 2);
            Debug.Log("Shit2.5");
        }
        else
        {
            Debug.Log("Shit3.5");
        }
    }

    public void BuyColor(float cost)
    {
        if (coins >= cost)
        {
            coins -= cost;
            PlayerPrefs.SetFloat("coins", coins);
            Debug.Log("Shit2");
            PlayerPrefs.SetInt("unlockedCDesert", 2);
        }
        else
        {
            Debug.Log("Shit3");
        }
    }
}
