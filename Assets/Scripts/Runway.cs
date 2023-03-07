using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// class that handles the selection of a runway
public class Runway : MonoBehaviour
{
    public bool open; // true if this runway can be taxiied to (there is not another plane taxiing here or already here)
    public float timeToRunway = 20.0f;  // time it takes for an airplane to get here

    public Airplane plane;  // the airplane that is taxiing here or is already here
    
    void Update() {
        if (!open){
            if(timeToRunway <= 0.0f){   // airplane has arrived at runway
                plane.status = PlaneStatus.Runway;
                Debug.Log("Plane " + plane._flightName + " is at the Runway!");
            }else{
                timeToRunway -= Time.deltaTime; // counting down
            }
        }
        if (plane.status == PlaneStatus.TakingOff) {
            timeToRunway = 20.0f;
            open = true;
        }
    }
}
