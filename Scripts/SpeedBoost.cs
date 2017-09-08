using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpeedBoost : MonoBehaviour {

    // Use this for initialization
    public Image speedboost;
    public float boostPower;
    private Rigidbody body;
    void Start () {
        body = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Jump") && speedboost.fillAmount > 0f){
            //speedboost.fillAmount -= Mathf.Lerp(0f, 1f, Time.deltaTime * 0.1f);
            Vector3 forwardForce = transform.forward * boostPower;
            forwardForce = forwardForce * Time.deltaTime * body.mass;
            body.AddForce(forwardForce);
            speedboost.fillAmount -= Time.deltaTime * 0.2f;
        }
    }
    public void resetBoost(){
        speedboost.fillAmount = 1f;
    }
}
