using UnityEngine;
using System.Collections;

public class UpdatePosition : MonoBehaviour {

    // Use this for initialization
    int size;
    public Position[] pos;
    public Sector[] sector;
    int i = 0;
    int nextSector = 0;
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        //int n = pos.Length;
        //i = 0;
        //Insertion Sort
        for (int j = 1; j < pos.Length; j++){
            for (i = j; swap()==true; i--){
                Position temp;
                temp = pos[i];
                pos[i] = pos[i-1];
                pos[i-1] = temp;
            }
        }
        for (int j=0; j < pos.Length; j++) {
            pos[j].position = j + 1;
        }
    }
    bool swap(){
        //Debug.Log("swap");
        if (!(i>0)){
            return false;
        }
        //If the play done more laps then he is ahead
        if (pos[i].laps>pos[i-1].laps) {
            return true;
        }
        if (pos[i].laps < pos[i - 1].laps){
            return false;
        }
        //if the player on the same lap and pasted more sectors he is a head
        if (pos[i].sectorNum>pos[i-1].sectorNum){
            return true;
        }
        if (pos[i].sectorNum < pos[i - 1].sectorNum){
            return false;
        }
        //check the distance to the next sector
        if (sectorDistance()){
            return true;
        }
        return false;
    }
    bool sectorDistance(){
        //sectorNum+1 is used to check the next sector ahead
        nextSector = pos[i].sectorNum+1;
        if (nextSector==sector.Length){
            nextSector = 0;
        }
        float distanceA = Vector3.Distance(sector[nextSector].transform.position, pos[i].transform.position);
        float distanceB = Vector3.Distance(sector[nextSector].transform.position, pos[i-1].transform.position);
        if (distanceA<distanceB){
            return true;
        }
        return false;
    }


 }
