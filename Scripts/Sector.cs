using UnityEngine;
using System.Collections;

public class Sector : MonoBehaviour {
    // Use this for initialization
    public int sectorNumber;
    void OnTriggerEnter(Collider col){
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "AI"){
            Position pos = col.gameObject.GetComponent<Position>();
            pos.passed[sectorNumber] = true;
            pos.sectorNum= sectorNumber;
        }
    }
}
