using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowLogic : MonoBehaviour
{
    public Sprite[] arrowSprites;
    public int indexOFArrow;
    // Start is called before the first frame update
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateArrow()
    {
        indexOFArrow += 1;
        if(indexOFArrow > 3)
        {
            indexOFArrow = 0;
        }
        this.gameObject.GetComponent<SpriteRenderer>().sprite = arrowSprites[indexOFArrow];
    }
    public int getSpriteIndex()
    {
        return indexOFArrow;
    }
}
