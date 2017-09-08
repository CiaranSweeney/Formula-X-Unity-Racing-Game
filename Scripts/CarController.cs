using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {

	// Use this for initialization
	public float acceleration;
	public float roationRate;

    public float maxSpeed;
    public float topSpeed;

    private float currentSpeed;
    private float speed;
    private float accelerationPercent;
    private float rotationVelocity;
	private float groundAngleVelocity;

	Rigidbody body; 
	void Start () {
		body=GetComponent<Rigidbody>();
	}
	void Update(){
        currentSpeed = body.velocity.magnitude;
        /*if (currentSpeed>0) {
            accelerationPercent = (currentSpeed * 100) /maxSpeed;
            speed = (accelerationPercent * topSpeed)/100;
            accelerationPercent = 100 - accelerationPercent;
            acceleration = (acceleration * accelerationPercent) / 100;
        }*/
        accelerationPercent = (currentSpeed * 100) / maxSpeed;
        speed = (accelerationPercent * topSpeed) / 100;
        //check if we are touching the ground
        if (Physics.Raycast(transform.position,transform.up*-1,3.0f) && speed<topSpeed){
            //when we are on the ground enable the accelorator and work out how much acceloration
            //calulate foward force:
            speed += acceleration;
            //Vector3 forwardForce=transform.forward*acceleration*Input.GetAxis("Vertical");
            Vector3 forwardForce = transform.forward * speed * Input.GetAxis("Vertical");
            //Correct force for deltatime and vehical mass:
            forwardForce =forwardForce*Time.deltaTime*body.mass;
            // Add the force to the space craft
			body.AddForce(forwardForce);
            //Debug.Log(acceleration);
        }
		else{
			//We aren't on the ground
			//body.drag=0;
		}
		//you can trun on the ground
		Vector3 turnTorque=Vector3.up*roationRate*Input.GetAxis("Horizontal");
		//Correct force fo deltatime and vechicle mass:
		turnTorque=turnTorque*Time.deltaTime*body.mass;
		body.AddTorque(turnTorque);
	}

}
