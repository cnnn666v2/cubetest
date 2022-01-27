using UnityEngine;
using UnityEngine.UI;

public class ChangeFPS : MonoBehaviour
{

    public void FPS30()
    {
        Application.targetFrameRate = 30;
    }

    public void FPS60()
    {
        Application.targetFrameRate = 60;
    }

    public void FPS90()
    {
        Application.targetFrameRate = 90;
    }

    public void FPS120()
    {
        Application.targetFrameRate = 120;
    }

    public void FPS180()
    {
        Application.targetFrameRate = 180;
    }

    public void FPS240()
    {
        Application.targetFrameRate = 240;
    }
 
    public int avgFrameRate;
    public Text ShowFPS;

    public void Start()
    {
        QualitySettings.vSyncCount = 0;
        InvokeRepeating("GetFPS", 1, 1);
    }

    public void GetFPS()
    {
        float current = 60;
        current = Time.frameCount / Time.time;
        avgFrameRate = (int)current;
        ShowFPS.text = avgFrameRate.ToString() + " FPS";
    }

}
