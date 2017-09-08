using UnityEngine;
using System.Collections;

public class Thruster : MonoBehaviour {

	// Use this for initialization
	public float thrusterStrength;
	public float thrusterDistance;
	public Transform[] thrusters;

	Rigidbody body;
	void Start () {
		body=GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	/*void Update () {
	
	}*/
	void FixedUpdate(){
		RaycastHit hit;

		foreach(Transform thruster in thrusters){
			Vector3 downwardForce;
			float distancePercentage;

			if(Physics.Raycast(thruster.position,thruster.up*-1,out hit,thrusterDistance)){
				//the thuster is within thrusterDistance to the ground. How far away?
				distancePercentage=1-(hit.distance/thrusterDistance);

				//callulate how much to push
				downwardForce=transform.up*thrusterStrength*distancePercentage;

				//Correct the force for the mass of the car and distance
				downwardForce=downwardForce*Time.deltaTime*body.mass;
				//apply the force where the thrust is.
				body.AddForceAtPosition(downwardForce,thruster.position);
			}
		}
	}
}
