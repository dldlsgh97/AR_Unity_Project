using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Ctrl : MonoBehaviour    
{
    // Start is called before the first frame update
    public GameObject MainUi;
    public static Text Credit_Text;
    public bool is_started;
    void Start()
    {
        //MainUi.SetActive(true);
        is_started = false;        
    }

    // Update is called once per frame
    void Update()
    {
        if (Marker_Ctrl.StartMarker)
        {
            is_started = true;
        }
        if (is_started)
        {
            HideUi();
        }
    }

    void HideUi()
    {
        if (Marker_Ctrl.StartMarker)
        {
            MainUi.SetActive(false);
        }
    }
}
