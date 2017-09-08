using UnityEngine;
using System.Collections;

public class LostMenu : MonoBehaviour {
    // Use this for initialization
    public int level;
    public void tryAgain(){
        Application.LoadLevel(level);
    }
    public void quit(){
        Application.Quit();
    }
}
