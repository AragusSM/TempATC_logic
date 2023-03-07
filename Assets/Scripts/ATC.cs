using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// class that handles the atc game logic
public class ATC : MonoBehaviour
{
    public Terminal terminal;   // terminal object where all departing planes originate from
    Airplane selectedAirplane;  // the airplane that the user has currently selected
    public int selectedButton = -1; // the button that the user has currently selected, -1 if none

    // called when a plane is selected from the departures UI
    public void selectDepartingAirplane(int index) {
        if (selectedAirplane == terminal._planes[index]) {  // deselect the currently selected plane
            selectedAirplane = null;
            selectedButton = -1;
        }else{  // select the selected plane
            selectedAirplane = terminal._planes[index];
            selectedButton = index;
        }
    }

    // TODO: called when a plane is selected from the arrivals UI
    public void selectArrivingAirplane() {

    }

    // called when a runway is selected from the runway UI
    public void selectRunway(Runway runway) {
        if (selectedAirplane != null && selectedAirplane.status == PlaneStatus.Terminal) {  // ensure that the user has selected a plane and that the plane is at the terminal
            if (runway.open) {
                selectedButton = -1;
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
