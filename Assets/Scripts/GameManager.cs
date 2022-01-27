using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 2f;

    public GameObject completeLevelUI;
    //public GameObject pauseMenu;
    public string nextLevel = "Level02";
    public int levelToUnlock = 2;
    public GameObject player;
    bool isDyingAllowed = true;

    public SceneFader sceneFader;

    public void Start()
    {
        isDyingAllowed = true;
        completeLevelUI.SetActive(false);
    }

    //void Update()
    //{
        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
            //Time.timeScale = 1;
           // pauseMenu.SetActive(true);
        //}
    //}

    //public void Resume()
    //{
        //Time.timeScale = 1;
        //pauseMenu.SetActive(false);
    //}

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        PlayerPrefs.SetInt("levelReached", levelToUnlock);
        sceneFader.FadeTo(nextLevel);
    }

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        if (isDyingAllowed)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void QuitMenu()
    {
        isDyingAllowed = false;
        Time.timeScale = 1f;
        sceneFader.FadeTo("MainMenu");
    }

}
