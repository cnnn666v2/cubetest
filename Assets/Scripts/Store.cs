using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Store : MonoBehaviour
{
    public GameObject preview;
    public Button[] previewButtons;
    //public Button[] unlockButtons;
    public float cost = 200;
    float coins;
    public Text ShowCoins;



    void Update() {
        coins = PlayerPrefs.GetFloat("coins");
        ShowCoins.text = coins.ToString();


        //preview = GameObject.Find("preview");
        //var cubeRenderer = preview.GetComponent<Renderer>();
        //cubeRenderer.material.SetColor("_Color", PlayerPrefs.GetString("selectedColor"));
    }

    public void ChangeMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    

    //DEBUG
    public void AddMoney() {
        coins += 500;
        PlayerPrefs.SetFloat("coins", coins);
        Debug.Log("Shit");
    }


    //MISC
    //int boolToInt(bool val)
    //{
        //if (val)
        //{
            //return 1;
        //}
        //else
        //{
            //return 0;
        //}
    //}

    //bool intToBool(int val)
    //{
        //if (val != 0)
        //{
            //return true;
        //}
        //else
        //{
            //return false;
        //}
    //}
}
