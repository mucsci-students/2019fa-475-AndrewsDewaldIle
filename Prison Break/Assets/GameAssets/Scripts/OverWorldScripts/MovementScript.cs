using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour{
    private const float tileSize = 1.0f;
    private float positionTransferDist;
    private Vector2 currentPos;
    // Start is called before the first frame update
    void Awake(){
        positionTransferDist = 0.05f;
        currentPos = transform.position;
    }

    // Update is called once per frame
    void Update(){
        Vector2 nextPosition = Vector2.zero;
        
        if (Input.GetKeyDown("up")){
            nextPosition.y = 1;
        }
        else if (Input.GetKeyDown("down")){
            nextPosition.y = -1;
        }
        else if (Input.GetKeyDown("left")){
            nextPosition.x = -1;
        }
        else if (Input.GetKeyDown("right")) {
            nextPosition.x = 1;
        }

        //Debug.DrawRay(currentPos, nextPosition * tileSize, Color.red, 0.5f);

        RaycastHit2D[] rays = Physics2D.RaycastAll(currentPos, nextPosition, tileSize);
        foreach (var ray in rays){
            if (ray.collider.gameObject.tag != "Player") {
                return;
            }
        }

        currentPos += nextPosition;
        transform.position = Vector2.Lerp(currentPos, currentPos * tileSize, positionTransferDist);
        

    }
}
