using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreviewIndexing : MonoBehaviour
{
    public GameObject Preview1; //= GameObject.Find("Preview1");
    public GameObject Preview2; //= GameObject.Find("Preview2");
    public GameObject Preview3; //= GameObject.Find("Preview3");
    public GameObject Preview4; //= GameObject.Find("Preview4");
    public GameObject Preview5; //= GameObject.Find("Preview5");
    public GameObject Preview6; //= GameObject.Find("Preview6");
    public GameObject Preview7;

    void Start()
    {
        Preview1.SetActive(true);
        Preview2.SetActive(false);
        Preview3.SetActive(false);
        Preview4.SetActive(false);
        Preview5.SetActive(false);
        Preview6.SetActive(false);
        Preview7.SetActive(false);
    }

    public void SwitchPreview(string switchPreview)
    {
        if (switchPreview == "preview1")
        {
            Preview1.SetActive(true);
            Preview2.SetActive(false);
            Preview3.SetActive(false);
            Preview4.SetActive(false);
            Preview5.SetActive(false);
            Preview6.SetActive(false);
            Preview7.SetActive(false);
        }
        else if (switchPreview == "preview2")
        {
            Preview1.SetActive(false);
            Preview2.SetActive(true);
            Preview3.SetActive(false);
            Preview4.SetActive(false);
            Preview5.SetActive(false);
            Preview6.SetActive(false);
            Preview7.SetActive(false);
        }
        else if (switchPreview == "preview3")
        {
            Preview1.SetActive(false);
            Preview2.SetActive(false);
            Preview3.SetActive(true);
            Preview4.SetActive(false);
            Preview5.SetActive(false);
            Preview6.SetActive(false);
            Preview7.SetActive(false);
        }
        else if (switchPreview == "preview4")
        {
            Preview1.SetActive(false);
            Preview2.SetActive(false);
            Preview3.SetActive(false);
            Preview4.SetActive(true);
            Preview5.SetActive(false);
            Preview6.SetActive(false);
            Preview7.SetActive(false);
        }
        else if (switchPreview == "preview5")
        {
            Preview1.SetActive(false);
            Preview2.SetActive(false);
            Preview3.SetActive(false);
            Preview4.SetActive(false);
            Preview5.SetActive(true);
            Preview6.SetActive(false);
            Preview7.SetActive(false);
        }
        else if (switchPreview == "preview6")
        {
            Preview1.SetActive(false);
            Preview2.SetActive(false);
            Preview3.SetActive(false);
            Preview4.SetActive(false);
            Preview5.SetActive(false);
            Preview6.SetActive(true);
            Preview7.SetActive(false);
        }

        else if (switchPreview == "preview7")
        {
            Preview1.SetActive(false);
            Preview2.SetActive(false);
            Preview3.SetActive(false);
            Preview4.SetActive(false);
            Preview5.SetActive(false);
            Preview6.SetActive(false);
            Preview7.SetActive(true);
        }
    }
}
