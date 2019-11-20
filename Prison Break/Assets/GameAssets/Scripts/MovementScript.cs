using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour{
    private const float tileSize = 0.5f;
    private Vector3 position;
    public float positionTransferTime;
    // Start is called before the first frame update
    void Awake(){
        position = new Vector3(0.0f,0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update(){
        //Tile size of 8 by 8
        //Size not sure yet.
        if (Input.GetKeyDown("up")){
            position.y += 1;
        }
        else if (Input.GetKeyDown("down")){
            position.y -= 1;
        }
        else if (Input.GetKeyDown("left")){
            position.x -= 1;
        }
        else if (Input.GetKeyDown("right")) {
            position.x += 1;
        }
        transform.position = Vector3.Lerp(transform.position, position * tileSize, positionTransferTime);

    }
}
