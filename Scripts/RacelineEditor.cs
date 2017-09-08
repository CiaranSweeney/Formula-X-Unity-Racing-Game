using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RacelineEditor : MonoBehaviour {
    // Use this for initialization
    public Color lineColor;
    public List<Transform> racingLinePoints = new List<Transform>();

    void OnDrawGizmos(){
        // colour of the line
        Gizmos.color = lineColor;
        //all th children of the object are used to make the racing line
        Transform[] array = GetComponentsInChildren<Transform>();
        racingLinePoints = new List<Transform>();
        for (int i=0; i<array.Length; i++){
            if (array[i] !=transform){
                racingLinePoints.Add(array[i]);
            }
        }
        //Go through all the points then draw a line
        for(int i = 0; i < racingLinePoints.Count; i++) {
            Vector3 position = racingLinePoints[i].position;
            Vector3 previous = Vector3.zero;
            if (i > 0){
                previous = racingLinePoints[i- 1].position;
            }
            else if (i==0 && racingLinePoints.Count>1){
                previous = racingLinePoints[racingLinePoints.Count - 1].position;
            }
            //Draw out the racing Line
            Gizmos.DrawLine(previous, position);
            Gizmos.DrawWireSphere(position, 0.3f);
       
        }
    }
}
