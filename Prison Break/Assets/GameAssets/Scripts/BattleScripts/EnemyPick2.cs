using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPick2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Pick()
    {
        EnemyHealth.enemyPick = 2;
    }
}
