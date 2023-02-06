using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class is_tracked : MonoBehaviour
{
    // Start is called before the first frame update
    public bool Marker1;
    public bool Coi_Marker;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void isTrackedOn()
    {
        Marker1 = true;
    }
    void isTrackedOff()
    {
        Marker1 = false;
    }

}
