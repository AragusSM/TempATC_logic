using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// class that represents an airplane
public class Airplane : MonoBehaviour
{
    public string _flightName;  // flight identifier
    public bool _departure;     // true if airplane is departing, false if airplane is arriving
    public PlaneStatus status;  // status of this plane
    
    // airplane initialization
    void Start() {
        status = PlaneStatus.Terminal;
    }
}

// enum of airplane statuses
public enum PlaneStatus {
    Terminal,
    Taxiing,
    Runway,
    TakingOff
}