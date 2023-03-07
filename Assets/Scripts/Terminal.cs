using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terminal : MonoBehaviour
{
    public Airplane airplane;
    public List<Airplane> _planes = new List<Airplane>();

    private float nextActionTime = 0.0f;
    private float period = 15.0f;
    void Update() {
        if (Time.time > nextActionTime) {
            nextActionTime += period;
            createPlane();
        }
    }

    void createPlane() {
        Airplane newPlane = Instantiate(airplane, new Vector3(0, 1, 0), Quaternion.identity);
        newPlane._flightName = _planes.Count.ToString();
        newPlane._departure = true;
        _planes.Add(newPlane);
        Debug.Log("Created new plane: " + newPlane._flightName + ". There are " + _planes.Count + " planes in the list.");
    }
}
