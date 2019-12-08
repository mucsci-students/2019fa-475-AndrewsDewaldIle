using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour
{
    public int x;
    public GameObject Get;
    public UIManagerScript uIManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Wrapper()
    {
        StartCoroutine(hit());
    }

    // Update is called once per frame
    public IEnumerator hit()
    {
        if (BattleData.turn == 1)
        {
            x = Random.Range(1, 5);
            if (x < 4 && EnemyHealth.enemyPick == 1 && EnemyHealth.health1 > 0)
            {
                EnemyHealth.health1 -= 1;
                TextChange.BattleText = "Hit Enemy 1";
                yield return new WaitForSeconds(1);
                if (EnemyHealth.health1 > 0 || EnemyHealth.health2 > 0)
                {
                    print(EnemyHealth.health1);
                    print(EnemyHealth.health2);
                    TextChange.BattleText = "Enemy Turn";
                    yield return new WaitForSeconds(1);
                    BattleData.turn = 2;
                    Get.GetComponent<EnemyAttack>().Wrapper();
                }
                else
                {
                    uIManager.displayInfo("Won Battle");
                    TextChange.BattleText = "Player Turn";
                    EnemyHealth.health1 = 3;
                    EnemyHealth.health2 = 3;
                    EnemyAttack.enemyNum = 2;
                }
            }
            else if (x < 4 && EnemyHealth.enemyPick == 2 && EnemyHealth.health2 > 0)
            {
                EnemyHealth.health2 -= 1;
                TextChange.BattleText = "Hit Enemy 2";
                yield return new WaitForSeconds(1);
                if (EnemyHealth.health1 > 0 || EnemyHealth.health2 > 0)
                {
                    print(EnemyHealth.health1);
                    print(EnemyHealth.health2);
                    TextChange.BattleText = "Enemy Turn";
                    yield return new WaitForSeconds(1);
                    BattleData.turn = 2;
                    Get.GetComponent<EnemyAttack>().Wrapper();
                }
                else
                {
                    uIManager.displayInfo("Won Battle");
                    TextChange.BattleText = "Player Turn";
                    EnemyHealth.health1 = 3;
                    EnemyHealth.health2 = 3;
                    EnemyAttack.enemyNum = 2;
                }
            }
            else if(EnemyHealth.enemyPick == 1 && EnemyHealth.health1 > 0 && x == 4) 
            {
                TextChange.BattleText = "Missed Enemy 1";
                yield return new WaitForSeconds(1);
                TextChange.BattleText = "Enemy Turn";
                yield return new WaitForSeconds(1);
                BattleData.turn = 2;
                Get.GetComponent<EnemyAttack>().Wrapper();
            }
            else if(EnemyHealth.enemyPick == 2 && EnemyHealth.health2 >0 && x == 4)
            {
                TextChange.BattleText = "Missed Enemy 2";
                yield return new WaitForSeconds(1);
                TextChange.BattleText = "Enemy Turn";
                yield return new WaitForSeconds(1);
                BattleData.turn = 2;
                Get.GetComponent<EnemyAttack>().Wrapper();
            }
        }
    }
}
