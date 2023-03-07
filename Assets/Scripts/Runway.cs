using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runway : MonoBehaviour
{
    public bool open;
    public float timeToRunway = 20.0f;

    public Airplane plane;
    
    void Update() {
        if (!open){
            if(timeToRunway <= 0.0f){
                plane.status = PlaneStatus.Runway;
                Debug.Log("Plane " + plane._flightName + " is at the Runway!");
            }else{
                timeToRunway -= Time.deltaTime;
            }
        }
        if (plane.status == PlaneStatus.TakingOff) {
            timeToRunway = 20.0f;
            open = true;
        }
    }
}
