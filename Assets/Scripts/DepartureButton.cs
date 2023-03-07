using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepartureButton : MonoBehaviour
{
    public Terminal terminal;
    public ATC atc;
    public int buttonNumber;
    bool pressed;
    // Update is called once per frame
    void Update()   // there is probably a better way to do this than every frame
    {
        if (terminal._planes.Count > buttonNumber) {
            gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = terminal._planes[buttonNumber]._flightName + " " + terminal._planes[buttonNumber].status.ToString();
            if (buttonNumber == atc.selectedButton) {
                gameObject.GetComponent<TMPro.TextMeshProUGUI>().color = Color.green;
            } else {
                gameObject.GetComponent<TMPro.TextMeshProUGUI>().color = Color.black;
            }
            
        } else {
            gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "";
        }
    }
    
}
