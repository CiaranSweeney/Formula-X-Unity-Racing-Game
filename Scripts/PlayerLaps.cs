using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerLaps : MonoBehaviour {

    // Use this for initialization
    public Laps playerLaps;
    public Text display;
    public float maxLaps;
    public float currentlap=1;
    public SpeedBoost speedboost;
    public LapTime lapTime;
    // Update is called once per frame
    void Update () {
        display.text = "Lap :" + playerLaps.lap.ToString() + "/" + maxLaps.ToString();
        if(currentlap< playerLaps.lap) {
            currentlap = playerLaps.lap;
            //reset the speedboost
            speedboost.resetBoost();
            lapTime.timeReset();
        }
    }
}
