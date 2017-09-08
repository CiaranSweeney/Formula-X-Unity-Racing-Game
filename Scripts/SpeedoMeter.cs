using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class SpeedoMeter : MonoBehaviour {

    // Use this for initialization
    public Text speedoMeter;
    private float speed;
    Rigidbody body;
    void Start () {
        body = GetComponent<Rigidbody>();
    }
	// Update is called once per frame
	void Update () {
        //shows how fast you are moving
        speed = body.velocity.magnitude;
        speedoMeter.text= System.Math.Round(speed, 0).ToString()+" Km";
    }
}
