using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public static int health1;
    public static int health2;
    public static int enemyPick;
    public GameObject ghost;
    public GameObject ghost2;
    // Start is called before the first frame update
    void Awake()
    {
        enemyPick = 0;
        health1 = 3;
        health2 = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (health1 == 0)
        {
            ghost.SetActive(false);
            EnemyAttack.enemyNum--;
            health1--;
        }
        else if(health2 == 0)
        {
            ghost2.SetActive(false);
            EnemyAttack.enemyNum--;
            health2--;
        }
    }
}
