using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControls : MonoBehaviour
{
    public static bool GameIsPaused;
    public Text buttonText;
    public Button resume;
    public Button pause;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    void PauseResumeGame()
    {
        if (GameIsPaused == false)
        {
            PauseGame();
        }
        else
        {
            ResumeGame();
        }
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
        GameIsPaused = false;
        resume.gameObject.SetActive(true);
        pause.gameObject.SetActive(false);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        GameIsPaused = true;
        resume.gameObject.SetActive(false);
        pause.gameObject.SetActive(true);
    }
    public void ExitGame()
    {
        Debug.Log("Exited the Game");
        Application.Quit();
    }

}
