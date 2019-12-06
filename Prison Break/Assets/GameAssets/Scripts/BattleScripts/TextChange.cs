using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    public static string BattleText;
    Text Texter;
    // Start is called before the first frame update
    void Start()
    {
        Texter = GetComponent<Text>();
        BattleText = "Player Turn";
    }

    // Update is called once per frame
    void Update()
    {
        Texter.text = BattleText;
    }
}
