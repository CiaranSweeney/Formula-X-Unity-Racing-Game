using UnityEngine;
using System.Collections;
//using System.Collections.Generic;

public class AIRacingLine : MonoBehaviour {

    // Use this for initialization
    public RacelineEditor[] racingLine;
    public int currentPointID = 0;
    public float acceleration;
    public float reachedDistence = 1.0f;
    public float rotationSpeed = 5.0f;
    public float speed;
    public float maxspeed=300;
    int randomNum = 0;

    Vector3 lastPosition;
    Vector3 currentPosition;
    void Start () {
        lastPosition = transform.position;
        randomNum = Random.Range(0, racingLine.Length);
    }
	
	// Update is called once per frame
	void Update () {
        if (speed<maxspeed) {
            speed += acceleration;
        }
        //The Ai follows the points on the racingline
        float distance = Vector3.Distance(racingLine[randomNum].racingLinePoints[currentPointID].position,transform.position);
        transform.position = Vector3.MoveTowards(transform.position, racingLine[randomNum].racingLinePoints[currentPointID].position, Time.deltaTime * speed);
        Quaternion rotation = Quaternion.LookRotation(racingLine[randomNum].racingLinePoints[currentPointID].position - transform.position);
        //This allows the AI to turn toward the direction of the racing point
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation,Time.deltaTime * rotationSpeed);
        if (distance < reachedDistence){
            currentPointID++;
        }
        if(currentPointID >= racingLine[randomNum].racingLinePoints.Count){
            //Picks which racing line to use
            randomNum = Random.Range(0, racingLine.Length);
            currentPointID = 0;
        }
	}
}
