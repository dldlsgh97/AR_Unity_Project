using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Credit_Text;
    void Start()
    {
        Credit_Text.text = "Credit : 0";
    }

    // Update is called once per frame
    void Update()
    {
        Credit_Text.text = "Credit : " + Machine_Ctrl.Play_Credit;
    }
}
