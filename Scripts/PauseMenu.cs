using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

    // Use this for initialization
    public GameObject pauseMenu;
    public Pause pause;
    public int level;
    //This is the pause menu
    public void Resume(){
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        pause.pressed = false;
    }
    public void RestartLevel(){
        Application.LoadLevel(level);
    }
    public void Quit(){
        Application.Quit();
    }
}
