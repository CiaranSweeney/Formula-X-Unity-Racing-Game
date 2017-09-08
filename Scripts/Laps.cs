using UnityEngine;
using System.Collections;
//using UnityEngine.UI;

public class Laps : MonoBehaviour {

    // Use this for initialization
    public float lap = 0f;
    //public LapTime laptime;
    public Position pos;
    float x = 0;
    void Start () {

    }
	// Update is called once per frame
	void Update () {
        if (pos.passed[1] == true && x == 0){
            lap++;
            x++;
        }
        if (pos.allPassed== true) { 
            //reset the laptime
            //laptime.timeReset();
            //Add a lap
            lap++;
            //reset the sectors again
            pos.setFalse();
        }
    }

}
