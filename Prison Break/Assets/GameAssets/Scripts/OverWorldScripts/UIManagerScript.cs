using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManagerScript : MonoBehaviour{
    public Image SanityMeter;
    public PlayerScript Player;
    public Sprite[] brainSprites;
    // Start is called before the first frame update
    void Awake(){

    }

    // Update is called once per frame
    void Update(){
        updateUI();
    }

    public void updateUI(){
        int sanityLevel = Player.getSanityLevel();
        SanityMeter.sprite = brainSprites[sanityLevel];

    }
}
