using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prize_Ctrl : MonoBehaviour
{

    public bool Marker1 = false;
    public bool is_spwaned = true;
    public bool is_shuffeled = true;
    public bool prizespawn = false;
    public GameObject prize1;
    public GameObject prize2;
    public GameObject prize3;
    public GameObject prize4;
    public GameObject prize5;
    public GameObject prize6;
    public GameObject prize7;
    public GameObject prize8;
    public GameObject prize9;

    public GameObject prize_spawner1;
    public GameObject prize_spawner2;
    public GameObject prize_spawner3;
    public GameObject prize_spawner4;
    public GameObject prize_spawner5;
    public GameObject prize_spawner6;
    public GameObject prize_spawner7;
    public GameObject prize_spawner8;
    public GameObject prize_spawner9;

    public static List<GameObject> Prizes = new List<GameObject>();
    public List<GameObject> Prizes_spawner = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        Prizes.Add(prize1);
        Prizes.Add(prize2);
        Prizes.Add(prize3);
        Prizes.Add(prize4);
        Prizes.Add(prize5);
        Prizes.Add(prize6);
        Prizes.Add(prize7);
        Prizes.Add(prize8);
        Prizes.Add(prize9);

        Prizes_spawner.Add(prize_spawner1);
        Prizes_spawner.Add(prize_spawner2);
        Prizes_spawner.Add(prize_spawner3);
        Prizes_spawner.Add(prize_spawner4);
        Prizes_spawner.Add(prize_spawner5);
        Prizes_spawner.Add(prize_spawner6);
        Prizes_spawner.Add(prize_spawner7);
        Prizes_spawner.Add(prize_spawner8);
        Prizes_spawner.Add(prize_spawner9);

    }

    // Update is called once per frame
    void Update()
    {
        if (is_shuffeled)
        {
            Prizes = ShuffleList(Prizes);
        }
        
        if (Marker1)
        {
            if (is_spwaned)
            {
                Prize_Spawn();
            } 
        }
        /*
        else if(Marker1 == false)
        {
            if (prizespawn)
            {
                for (int i = 0; i < Prizes.Count; i++)
                {
                    Prizes[i].gameObject.SetActive(false);
                }
            }
            
        }
        */
    }
    public void isTrackedOn()
    {
        Marker1 = true;
        Debug.Log("a");
    }
    public void isTrackedOff()
    {
        Marker1 = false;
    }

    void Prize_Spawn()
    {
        for(int i = 0; i<9; i++)
        {
            Instantiate(Prizes[i], Prizes_spawner[i].transform.position, Prizes[i].transform.rotation);
            Prizes[i].gameObject.SetActive(true);
        }
        is_spwaned = false;
        prizespawn = true;
        
    }
    private List<T> ShuffleList<T>(List<T> list)
    {
        int random1, random2;
        T temp;

        for (int i = 0; i < list.Count; ++i)
        {
            random1 = Random.Range(0, list.Count);
            random2 = Random.Range(0, list.Count);

            temp = list[random1];
            list[random1] = list[random2];
            list[random2] = temp;
        }
        is_shuffeled = false;
        return list;
    }
}
