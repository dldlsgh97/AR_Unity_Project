using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Machine_Ctrl : MonoBehaviour
{
    public GameObject push_machine;
    public GameObject push_machine1;
    public GameObject push_machine2;
    public GameObject push_machine3;
    public GameObject push_machine4;
    public GameObject push_machine5;
    public GameObject Goal_Plate;
    public Vector3 start_point;
    public static int Play_Credit=0;
    public static bool Coin_Marker;
    private Vector3 x_position;
    private Vector3 Machine_1_startPosition;
    private Vector3 y_end_position;
    public GameObject machine_1;
    // Start is called before the first frame update
    void Start()
    {
        Coin_Marker = false;
        /*
        //PlayerPrefs.DeleteKey("Play_Credit");
        if (PlayerPrefs.HasKey("Play_Credit"))
        {
            Play_Credit = PlayerPrefs.GetInt("Play_Credit");
            //UI_Ctrl.Credit_Text.text = "Credit : " + Play_Credit;
        }
        else
        {
            PlayerPrefs.SetInt("Play_Credit", 0);
            //UI_Ctrl.Credit_Text.text = "Credit : " + Play_Credit;
        }
        */     
    }

    // Update is called once per frame
    void Update()
    {
        InsertCoin();
        if (Play_Credit >= 1)
        {
            Debug.Log(Play_Credit);
            if (Marker_Ctrl.LeftMarker)
            {
                if ((push_machine.transform.position.z >= -27.0f) && (push_machine.transform.position.z <= 0.11f))
                {
                    push_machine.transform.position += new Vector3(0.0f, 0.0f, -0.1f);
                    machine_1.transform.position += new Vector3(0.0f, 0.0f, -0.1f);
                }
            }

            if (Marker_Ctrl.UpMarker)
            {
                if ((push_machine.transform.position.y <= 44.0f) && (push_machine.transform.position.y >= -0.1f))
                {
                    push_machine.transform.position += new Vector3(0.0f, 0.1f, 0.0f);
                }
            }
            if (Marker_Ctrl.PushMarker)
            {

                if ((push_machine4.transform.position.x >= -3.0f) && (push_machine4.transform.position.x <= 0.1f))
                {
                    push_machine4.transform.position += new Vector3(-0.1f, 0.0f, 0.0f);
                }
                if ((push_machine3.transform.position.x >= -6.0f) && (push_machine3.transform.position.x <= 0.1f))
                {
                    push_machine3.transform.position += new Vector3(-0.1f, 0.0f, 0.0f);
                }
                if ((push_machine2.transform.position.x >= -9.0f) && (push_machine2.transform.position.x <= 0.1f))
                {
                    push_machine2.transform.position += new Vector3(-0.1f, 0.0f, 0.0f);
                }
                if ((push_machine1.transform.position.x >= -12.0f) && (push_machine1.transform.position.x <= 0.1f))
                {
                    push_machine1.transform.position += new Vector3(-0.1f, 0.0f, 0.0f);
                }
                Play_Credit -= 1;
                //PlayerPrefs.SetInt("Play_Credit", Play_Credit);
                //TextCtrl.Credit_Text.text = "Credit : " + Play_Credit; 

            }
            if (Input.GetKey(KeyCode.A))
            {
                reset_machine_position();
            }

        }
    }

    void reset_machine_position()
    {
        while(machine_1.transform.position.z <= 13.5f)
        {
            machine_1.transform.position += new Vector3(0.0f, 0.0f, 0.1f);
            push_machine.transform.position += new Vector3(0.0f, 0.0f, 0.1f);
        }
        //if ((machine_1.transform.position.z >= -15.0f) && (machine_1.transform.position.z <= 13.5f))
        //{
        //    
        //}
        while((push_machine.transform.position.y <= 13.5f) && (push_machine.transform.position.y >= 0f))
        {
            push_machine.transform.position += new Vector3(0.0f, -0.1f, 0.0f);
        }
        //if ((push_machine.transform.position.y <= 13.5f) && (push_machine.transform.position.y >= 0f))
        //{
        //    push_machine.transform.position += new Vector3(0.0f, -0.1f, 0.0f);
        //}

        if ((push_machine1.transform.position.x >= -12.5f) && (push_machine1.transform.position.x <= 0.0f))
        {
            push_machine1.transform.position += new Vector3(0.1f, 0.0f, 0.0f);
        }
        if ((push_machine2.transform.position.x >= -9.5f) && (push_machine2.transform.position.x <= 0.0f))
        {
            push_machine2.transform.position += new Vector3(0.1f, 0.0f, 0.0f);
        }
        if ((push_machine3.transform.position.x >= -6.5f) && (push_machine3.transform.position.x <= 0.0f))
        {
            push_machine3.transform.position += new Vector3(0.1f, 0.0f, 0.0f);
        }
        if ((push_machine4.transform.position.x >= -3.5f) && (push_machine4.transform.position.x <= 0.0f))
        {
            push_machine4.transform.position += new Vector3(0.1f, 0.0f, 0.0f);
        }
    }
    public void InsertCoin()
    {
        if(Coin_Marker == false)
        {
            if (Marker_Ctrl.CoinMarker)
            {
                Play_Credit += 1;
                //TextCtrl.Credit_Text.text = "Credit : " + Play_Credit;
                Coin_Marker = true;
            }
        }       
    }    
}
 