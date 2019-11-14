using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour
{
    public int x;
    public static int turn;
    // Start is called before the first frame update
    void Start()
    {
        turn = 1;
    }

    // Update is called once per frame
    public void hit()
    {
        if (turn == 1)
        {
            x = Random.Range(1, 5);
            if (x < 4 && EnemyHealth.enemyPick == 1 && EnemyHealth.health1 > 0)
            {
                EnemyHealth.health1 -= 1;
                turn = 2;
            }
            else if (x < 4 && EnemyHealth.enemyPick == 2 && EnemyHealth.health2 > 0)
            {
                EnemyHealth.health2 -= 1;
                turn = 2;
            }
            else if(EnemyHealth.enemyPick == 1 && EnemyHealth.health1 > 0 && x == 4) 
            {
                turn = 2;
            }
            else if(EnemyHealth.enemyPick == 2 && EnemyHealth.health2 >0 && x == 4)
            {
                turn = 2;
            }
        }
    }
}
