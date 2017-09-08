using UnityEngine;
using System.Collections;

public class WinMenu : MonoBehaviour
{

    // Use this for initialization
    public int level;
    public void NextRace(){
        Application.LoadLevel(level);
    }
    public void Quit() {
        Application.Quit();
    }
}
