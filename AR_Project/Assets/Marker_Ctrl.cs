using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker_Ctrl : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool LeftMarker;
    public static bool UpMarker;
    public static bool StartMarker = false;
    public static bool PushMarker;
    public static bool MachineMarker;
    public static bool CoinMarker;

    public void StartMarker_On()
    {
        StartMarker = true;
    }
    public void StartMarker_Off()
    {
        StartMarker = false;
    }
    public void LeftMarker_On()
    {
        LeftMarker = true;
    }
    public void LeftMarker_Off()
    {
        LeftMarker =false;
    }
    public void UpMarker_On()
    {
        UpMarker = true;
    }
    public void UpMarker_Off()
    {
        UpMarker = false;
    }
    public void PushMarker_On()
    {
        PushMarker = true;
    }
    public void PushMarker_Off()
    {
        PushMarker = false;
    }
    public void MachineMarker_On()
    {
        MachineMarker = true;
    }
    public void MachineMarker_Off()
    {
        MachineMarker = false;
    }
    public void CoinMarker_On()
    {
        CoinMarker = true;
    }
    public void CoinMarker_Off()
    {
        CoinMarker = false;
        Machine_Ctrl.Coin_Marker = false;
    }
}

