using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour{
    private const float tileSize = 0.25f;
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
            nextPosition.y += tileSize;
        }
        else if (Input.GetKeyDown("down")){
            nextPosition.y += -tileSize;
        }
        else if (Input.GetKeyDown("left")){
            nextPosition.x += -tileSize;
        }
        else if (Input.GetKeyDown("right")) {
            nextPosition.x += tileSize;
        }

        Debug.DrawRay(currentPos, nextPosition, Color.red, 0.5f);

        RaycastHit2D[] rays = Physics2D.RaycastAll(currentPos, nextPosition.normalized, tileSize);
        foreach (var ray in rays){
            if (ray.collider.gameObject.tag != "Player" && ray.collider.gameObject.tag != "Knife") {
                return;
            }
        }

        currentPos += nextPosition;
        transform.position = Vector2.Lerp(currentPos, nextPosition, positionTransferDist);
        

    }
}
