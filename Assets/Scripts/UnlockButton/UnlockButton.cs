using UnityEngine;
using UnityEngine.UI;

public class UnlockButton : MonoBehaviour
{
    public GameObject unlockBtn;
    float coins;
    public float cost = 200;
    int unlockedRed;

    void Update()
    {
        coins = PlayerPrefs.GetFloat("coins");
        unlockedRed = PlayerPrefs.GetInt("unlockedRed");

        //RED
        if (unlockedRed > 1)
        {
            unlockBtn.SetActive(true);
        }
        else
        {
            unlockBtn.SetActive(false);
        }

    }

    // ==BUY==
    //Red
    public void BuyColorRED(float cost)
    {
        if (coins >= cost)
        {
            coins -= 250;
            PlayerPrefs.SetFloat("coins", coins);
            Debug.Log("Shit2");
        }
        else
        {
            Debug.Log("Shit3");
        }
    }

    public void UnlockBtnRED(GameObject unlockBtn)
    {
        if (coins >= cost)
        {
            unlockBtn.SetActive(true);
            PlayerPrefs.SetInt("unlockedRed", 2);
            Debug.Log("Shit2.5");
        }
        else
        {
            Debug.Log("Shit3.5");
        }
    }

}