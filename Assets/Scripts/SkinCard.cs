using UnityEngine;

public class SkinCard : MonoBehaviour
{
    public GameObject skinToEquip;

    public void EquipSkin()
    {
        SkinLoader.skinToLoad = skinToEquip;
    }
}