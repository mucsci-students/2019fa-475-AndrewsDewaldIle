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
    public GameObject bossGhost;
    public GameObject bossGhost2;
    public GameObject PlayerGet;
    public GameObject BattleMenu;
    public GameObject BattlePlayer;
    public GameObject BattleInfo;
    public GameObject EnemySelect1;
    public GameObject EnemySelect2;
    public bool ghostDead;
    public UIManagerScript uIManager;
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
        if ((health1 == 0 || health1 == -1) && (EnemyAttack.enemyNum == 1 || EnemyAttack.enemyNum == 2))
        {
            ghost.SetActive(false);
            bossGhost.SetActive(false);
            EnemyAttack.enemyNum--;
            health1 = -2;
        }
        else if ((health2 == 0 || health1 == -1) && (EnemyAttack.enemyNum == 1 || EnemyAttack.enemyNum == 2))
        { 
            ghost2.SetActive(false);
            bossGhost2.SetActive(false);
            EnemyAttack.enemyNum--;
            health1 = -2;
        }

        else if(health1 <= 0 && health2 <= 0 && EnemyAttack.enemyNum == 0)
        {
            PlayerGet.SetActive(true);
            BattleMenu.SetActive(false);
            BattlePlayer.SetActive(false);
            ghost.SetActive(false);
            ghost2.SetActive(false);
            BattleInfo.SetActive(false);
            EnemySelect1.SetActive(false);
            EnemySelect2.SetActive(false);
            bossGhost.SetActive(false);
            bossGhost2.SetActive(false);
            EnemyHealth.health1 = 3;
            EnemyHealth.health2 = 3;
            EnemyAttack.enemyNum = 2;
            uIManager.displayInfo("Won Battle");
            TextChange.BattleText = "Player Turn";
        }
    }
}
