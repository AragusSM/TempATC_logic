using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane : MonoBehaviour
{
    public string _flightName; // flight identifier
    public bool _departure;    // true if airplane is departing, false if airplane is arriving
    public PlaneStatus status;
    
    
    
    void Start() {
        status = PlaneStatus.Terminal;
    }

    void Update() {
        if (status == PlaneStatus.Taxiing) {

        }
    }

}
public enum PlaneStatus {
    Terminal,
    Taxiing,
    Runway,
    TakingOff
}