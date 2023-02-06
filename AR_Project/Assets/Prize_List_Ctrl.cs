using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prize_List_Ctrl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Main_script;
    public GameObject Prize_script;
    public GameObject mac;

    public GameObject prize_2_1;
    public GameObject prize_2_2;
    public GameObject prize_2_3;
    public GameObject prize_2_4;
    public GameObject prize_2_5;
    public GameObject prize_2_6;
    public GameObject prize_2_7;
    public GameObject prize_2_8;
    public GameObject prize_2_9;
    public GameObject prize_list_spawner1;
    public GameObject prize_list_spawner2;
    public GameObject prize_list_spawner3;
    public GameObject prize_list_spawner4;
    public GameObject prize_list_spawner5;
    public GameObject prize_list_spawner6;
    public GameObject prize_list_spawner7;
    public GameObject prize_list_spawner8;
    public GameObject prize_list_spawner9;
    public List<GameObject> Prizes_List_spawner = new List<GameObject>();
    public List<GameObject> Prizes_List_2 = new List<GameObject>();
    //MainScript mainscript;
    void Start()
    {
        //Main_script = mac.GetComponent<Machine_Ctrl>();
        
        Prizes_List_spawner.Add(prize_list_spawner1);
        Prizes_List_spawner.Add(prize_list_spawner2);
        Prizes_List_spawner.Add(prize_list_spawner3);
        Prizes_List_spawner.Add(prize_list_spawner4);
        Prizes_List_spawner.Add(prize_list_spawner5);
        Prizes_List_spawner.Add(prize_list_spawner6);
        Prizes_List_spawner.Add(prize_list_spawner7);
        Prizes_List_spawner.Add(prize_list_spawner8);
        Prizes_List_spawner.Add(prize_list_spawner9);

        Prizes_List_2.Add(prize_2_1);
        Prizes_List_2.Add(prize_2_2);
        Prizes_List_2.Add(prize_2_3);
        Prizes_List_2.Add(prize_2_4);
        Prizes_List_2.Add(prize_2_5);
        Prizes_List_2.Add(prize_2_6);
        Prizes_List_2.Add(prize_2_7);
        Prizes_List_2.Add(prize_2_8);
        Prizes_List_2.Add(prize_2_9);

    }

    // Update is called once per frame
    void Update()
    {
        prize_list_set();
        /*
        Debug.Log("PrizeIndex2" + PrizeGoal_Ctrl.Prizeindex);
        if(PrizeGoal_Ctrl.Prizeindex != -1)
        {
            Instantiate(Prizes_List[PrizeGoal_Ctrl.Prizeindex], Prizes_List_spawner[0].transform.position, Prizes_List[PrizeGoal_Ctrl.Prizeindex].transform.rotation);
        }
        */

    }

    void prize_list_set()
    {
        Debug.Log("prize_List_set1");
        if (PrizeGoal_Ctrl.Prizeindex == 0)
        {
            Debug.Log("prize_List_se2");
            for (int i = 0; i < Prizes_List_2.Count; i++)
            {
                if(PrizeGoal_Ctrl.prize_name == Prizes_List_2[i].name + "(Clone)")
                {
                    Debug.Log(Prizes_List_2[i].name);
                }
            }
            //PrizeGoal_Ctrl.prize_name
        }
    }
}
