using UnityEngine;
using System.Collections;

public class Position : MonoBehaviour {

    // Use this for initialization
    //public int carid;
    public float position;
    public Laps lap;
    public float laps = 0f;
    public int sectorNum=0;
    public Sector[] sector;
    public bool[] passed;
    public bool allPassed = false;
    int count = 0; 
    void Start () {
        //sectorNum = sector.Length-1;
        passed = new bool[sector.Length];
        for (int i = 0; i < passed.Length; i++){
            passed[i] = false;
        }
	}
	
	// Update is called once per frame
	void Update () {
        laps = lap.lap;
        for (int i = 0; i < passed.Length; i++){
            if (passed[i] == true){
                count++;
            }
        }
        if (count == passed.Length){
            allPassed = true;
        }
        count = 0;
	}
    public void setFalse(){
        for (int i = 0; i < passed.Length; i++){
            passed[i] = false;
        }
        allPassed = false;
    }
    /*void OnTriggerEnter(){
         if (col.gameObject.tag == "Player")
    }*/
    /*void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Position"){
            Debug.Log("hello");
            UpdatePosition pos =col.gameObject.GetComponent<UpdatePosition>();
            if (position > pos.position){
                position--;
            }
            /*else if (position < pos.position){
                position++;
            }
        }
    }*/

}
