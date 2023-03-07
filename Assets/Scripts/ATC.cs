using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATC : MonoBehaviour
{
    public Terminal terminal;
    Airplane selectedAirplane;
    public int selectedButton = -1;
    public void selectDepartingAirplane(int index) {
        if (selectedAirplane == terminal._planes[index]) {
            selectedAirplane = null;
            selectedButton = -1;
        }else{
            selectedAirplane = terminal._planes[index];
            selectedButton = index;
        }
    }

    public void selectArrivingAirplane() { // for later

    }

    public void selectRunway(Runway runway) {
        if (selectedAirplane != null) {
            Debug.Log("HERE!!!!");
            if (runway.open) {
                selectedAirplane.status = PlaneStatus.Taxiing;
                runway.plane = selectedAirplane;
                runway.open = false;
            } else {
                // there is already a plane on that runway!
            }
            
        } else {
            // you must selected a plane first!
        }
    }
}
