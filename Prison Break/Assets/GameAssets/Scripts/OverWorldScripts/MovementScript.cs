using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour{
    public enum DIR {LEFT,RIGHT,DOWN,UP};
    public GameObject cliff;
    public UIManagerScript uIManager;

    private const float tileSize = 0.25f;
    private float positionTransferDist;
    private DIR lastDir;
    // Start is called before the first frame update
    void Awake(){
        positionTransferDist = 0.05f;
        lastDir = DIR.RIGHT;
    }

    // Update is called once per frame
    void Update(){
        Vector2 nextPosition = Vector2.zero;
        
        if (Input.GetKeyDown("up")){
            nextPosition.y += tileSize;
            lastDir = DIR.UP;
        }
        else if (Input.GetKeyDown("down")){
            nextPosition.y += -tileSize;
            lastDir = DIR.DOWN;
        }
        else if (Input.GetKeyDown("left")){
            nextPosition.x += -tileSize;
            lastDir = DIR.LEFT;
        }
        else if (Input.GetKeyDown("right")) {
            nextPosition.x += tileSize;
            lastDir = DIR.RIGHT;
        }

        Debug.DrawRay(this.gameObject.transform.position, nextPosition, Color.red, 0.5f);

        RaycastHit2D[] rays = Physics2D.RaycastAll(this.gameObject.transform.position, nextPosition.normalized, tileSize);
        foreach (var ray in rays){
            if (ray.collider.gameObject.tag == "Wall") {
                return;
            }
            else if(ray.collider.gameObject.name == "BoardFallEvent")
            {
                uIManager.displayInfo("The board fell. You are trapped.");
                cliff.GetComponent<BoxCollider2D>().enabled = true;
                cliff.GetComponentInChildren<SpriteRenderer>().enabled = false;
                Destroy(ray.collider.gameObject);
            }
        }        
        transform.position += ((Vector3)nextPosition);
        
    }
    public DIR getLastMovement()
    {
        return lastDir;
    }
}
