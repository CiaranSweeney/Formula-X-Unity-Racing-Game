using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Menu : MonoBehaviour
{
    public Button start;
    public Button exit;
    // Use this for initialization
    void Start()
    {
        /*startGame.GetComponent<Button>();
        exitGame.GetComponent<Button>();*/

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartLevel()
    {
        Application.LoadLevel(1);
    }

    public void ExitLevel()
    {
        Application.Quit();
    }
}
