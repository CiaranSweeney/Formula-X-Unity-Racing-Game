using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerPosition : MonoBehaviour {
    public Position pos;
    public Text currentPostion;
	// Use this for initialization

	// Update is called once per frame
	void Update () {
        currentPostion.text = "Position:" + pos.position.ToString();
    }
}
