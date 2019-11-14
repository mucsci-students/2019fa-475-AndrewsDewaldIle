using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSanity : MonoBehaviour
{
    public static int Sanity;
    public GameObject player;
    public GameObject Sanity1;
    public GameObject Sanity2;
    public GameObject Sanity3;
    public GameObject Sanity4;
    public GameObject Sanity5;
    // Start is called before the first frame update
    void Start()
    {
        Sanity = 5;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Sanity);
        if(Sanity == 4)
        {
            Sanity1.SetActive(false);
            Sanity2.SetActive(true);
        }
        else if(Sanity == 3)
        {
            Sanity2.SetActive(false);
            Sanity3.SetActive(true);
        }
        else if(Sanity == 2)
        {
            Sanity3.SetActive(false);
            Sanity4.SetActive(true);
        }
        else if(Sanity == 1)
        {
            Sanity4.SetActive(false);
            Sanity5.SetActive(true);
        }
        if (Sanity == 0)
        {
            player.SetActive(false);
        }
    }
}
