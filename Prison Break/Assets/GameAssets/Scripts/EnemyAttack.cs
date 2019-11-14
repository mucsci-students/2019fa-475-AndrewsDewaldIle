using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public static int enemyNum;
    public int x;
    // Start is called before the first frame update
    void Start()
    {
        enemyNum = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Punch.turn == 2 && enemyNum > 0)
        {
            for (int i = 0; i < enemyNum; i++)
            {
                x = Random.Range(1, 11);
                if (x < 3)
                {
                    PlayerSanity.Sanity -= 1;

                }
            }
            Punch.turn = 1;
        }
    }
}
