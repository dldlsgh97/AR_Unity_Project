using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrizeGoal_Ctrl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MainScript;
    public static int Prizeindex = -1;
    public static string prize_name;
    public List<GameObject> Prizes_List = new List<GameObject>();

    void Start()
    {
        Prizes_List = prize_Ctrl.Prizes;
        Prizeindex = -1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision prize)
    {
        if(prize.gameObject.tag == "Prize")
        {
            Prizeindex = 0;
            Debug.Log("Prizeindex" + Prizeindex);
            Debug.Log("Prize" + prize.gameObject.name);
            Machine_Ctrl.Play_Credit += 5;
            //PlayerPrefs.SetInt("Play_Credit", Machine_Ctrl.Play_Credit);
            prize_name = prize.gameObject.name;
            //TextCtrl.Credit_Text.text = "Credit : " + Machine_Ctrl.Play_Credit;
            Destroy(prize.gameObject);
            /*
            if (prize.gameObject.name == Prizes_List[i].gameObject.name+"(Clone)")
            {
                Prizeindex = i;
                Debug.Log("Prizeindex"+i);
            }
            */
        }

    }
    }
