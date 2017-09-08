using UnityEngine;
using System.Collections;

public class EngineSound : MonoBehaviour {

    // Use this for initialization
    public float maxSpeed;
    public float maxPitch;
    public float maxVolume;
    private Rigidbody body;
    private float currentSpeed;
    private float percentage;
    private float currentPitch;
    private float currentVolume;
    //public AudioSource audio;
    void Start () {
        body = GetComponent<Rigidbody>();
         //audio= GetComponent<AudioSource>();
         // AudioSource audio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        AudioSource audio = GetComponent<AudioSource>();
        currentSpeed = body.velocity.magnitude;
        percentage = (currentSpeed * 100) / maxSpeed;
        currentPitch = (percentage * maxPitch) / 100;
        //*if (currentSpeed<0)){
        audio.pitch = currentPitch;
        currentVolume= (percentage * maxVolume) / 100;
        audio.volume = currentVolume;
    }
}
