using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LapTime : MonoBehaviour {

    // Use this for initialization
    public Text laptimer;
    public Text bestLaptime;
    float time=0f;
    float sec=0f;
    float minute=0f;
    float[] bestlap=new float[3];
    void Start () {
        bestlap[0] = 999;
        bestlap[1] = 999;
        bestlap[2] = 999;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        time += Time.deltaTime;
        if (time >= 10)
        {
            time = 0;
            sec++;
        }
        if (sec >= 6){
            sec = 0;
            minute++;
        }
        laptimer.text = "Time:"+minute.ToString() +":"+sec.ToString()+System.Math.Round(time, 2).ToString();
    }
    public void timeReset(){
        //Display the best laptime
        //bestLaptime.text= minute.ToString() + ":" + sec.ToString() + System.Math.Round(time, 2).ToString();
        if (minute<bestlap[0]) {
            bestlap[0] = minute;
            bestlap[1] = sec;
            bestlap[2] = time;
        }
        else if (minute <= bestlap[0] && sec < bestlap[1]){
            bestlap[0] = minute;
            bestlap[1] = sec;
            bestlap[2] = time;
        }
        else if (minute <= bestlap[0] && sec <= bestlap[1] && time < bestlap[2]){
            bestlap[0] = minute;
            bestlap[1] = sec;
            bestlap[2] = time;
        }
        time = 0;
        sec = 0;
        minute = 0;
        bestLaptime.text = "Best Lap:"+ bestlap[0].ToString() + ":" + bestlap[1].ToString() + System.Math.Round(bestlap[2], 2).ToString();

    }
}
