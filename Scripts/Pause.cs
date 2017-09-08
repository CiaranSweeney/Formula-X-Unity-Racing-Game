using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Pause : MonoBehaviour {

    // Use this for initialization
    public GameObject pauseMenu;
    public bool pressed = false;
	void Start () {
    }
	
	// Update is called once per frame
	void Update() {
        //clike p to pause the game
        if (Input.GetKeyDown("p") && pressed == false){
            Debug.Log("test");
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
            pressed = true;
        }
        else if (Input.GetKeyDown("p") && pressed == true){
            Time.timeScale = 1f;
            pauseMenu.SetActive(false);
            pressed = false;
        }
	}
}
