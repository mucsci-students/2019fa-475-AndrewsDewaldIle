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
    public GameObject PlayerGet;
    public GameObject BattleMenu;
    public GameObject BattlePlayer;
    public GameObject BattleInfo;
    public GameObject EnemySelect1;
    public GameObject EnemySelect2;
    public bool ghostDead;
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
        else if(health1 <= 0 && health2 <= 0)
        {
            PlayerGet.SetActive(true);
            BattleMenu.SetActive(false);
            BattlePlayer.SetActive(false);
            ghost.SetActive(false);
            ghost2.SetActive(false);
            BattleInfo.SetActive(false);
            EnemySelect1.SetActive(false);
            EnemySelect2.SetActive(false);
        }
    }
}
