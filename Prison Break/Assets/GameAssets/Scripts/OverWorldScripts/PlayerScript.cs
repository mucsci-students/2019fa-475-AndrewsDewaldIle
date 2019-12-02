using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour{
    private int sanityLevel;
    private bool knifeCollected;
    //Testing purposes: private float lastTime;
    // Start is called before the first frame update
    void Awake()
    {
        sanityLevel = 0;
        knifeCollected = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getSanityLevel() {
        return sanityLevel;
    }

    public void gotHurt(){
        if(sanityLevel < 4)
            sanityLevel += 1;
    }

    public void pickupKnife()
    {
        knifeCollected = true;
    }
}
