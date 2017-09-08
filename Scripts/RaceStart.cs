using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class RaceStart : MonoBehaviour {
    // Use this for initialization
    public int startTime = 5;
    public Text timerCountdown;
    double time = 0;
    double countdown=0;
	void Start () {
        Time.timeScale = 0f;
        countdown = startTime;

    }

    // Update is called once per frame
    void Update(){
        time =System.Math.Round(Time.realtimeSinceStartup, 0);
        if (time> startTime){
            Time.timeScale = 1f;
            Destroy(gameObject);
        }
        else if (time == startTime){
            timerCountdown.color = Color.green;
            timerCountdown.text = "Go!";
        }
        else if (time < startTime){
            timerCountdown.text = System.Math.Round(countdown, 0).ToString();
            countdown = startTime - time;
        }
        
    }
}
