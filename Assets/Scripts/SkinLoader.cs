using UnityEngine;

public class SkinLoader : MonoBehaviour
{
    public GameObject defaultSkin;
    public static GameObject skinToLoad;

    public void Awake()
    {
        if(skinToLoad != null)
        {
            Destroy(defaultSkin);
            Instantiate(skinToLoad, transform);
        }
    }
}
