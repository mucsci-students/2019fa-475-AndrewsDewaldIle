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
    public void Wrapper()
    {
        if (BattleData.turn == 2 && enemyNum > 0)
        {
            StartCoroutine(enemyAttack());
        }
    }

    public IEnumerator enemyAttack()
    {
        for (int i = 1; i <= enemyNum; i++)
        {
            TextChange.BattleText = "Attacked by enemy " + i;
            yield return new WaitForSeconds(2);
            x = Random.Range(1, 11);
            if (x < 3)
            {
                PlayerSanity.Sanity -= 1;
                TextChange.BattleText = "Player took damage";
                yield return new WaitForSeconds(2);
            }
            else
            {
                TextChange.BattleText = "Enemy " + i + " missed";
                yield return new WaitForSeconds(2);
            }
        }
        TextChange.BattleText = "Player Turn";
        BattleData.turn = 1;
    }
}
