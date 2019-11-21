using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour{
    private int sanityLevel;
    //Testing purposes: private float lastTime;
    // Start is called before the first frame update
    void Awake()
    {
        sanityLevel = 0;
        //Testing purposes: lastTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //Testing purposes: 
            //if (Time.time - lastTime >= 2.0f) {
            //    gotHurt();
            //     lastTime = Time.time;
            //}
    }

    public int getSanityLevel() {
        return sanityLevel;
    }

    public void gotHurt(){
        if(sanityLevel < 4)
            sanityLevel += 1;
    }
}
