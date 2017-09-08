using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour{
    // Use this for initialization
    public PlayerLaps playerLap;
    public GameObject winMenu;
    public GameObject losingMenu;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider col){
        if (col.gameObject.tag == "Player"){
            Position pos = col.gameObject.GetComponent<Position>();
            //PlayerLaps pl = col.gameObject.GetComponent<PlayerLaps>();
            if (pos.position==1 && playerLap.currentlap== playerLap.maxLaps){
                winMenu.SetActive(true);
            }
            else if (pos.position !=1 && playerLap.currentlap == playerLap.maxLaps){
                losingMenu.SetActive(true);
            }
        }
    }
}
