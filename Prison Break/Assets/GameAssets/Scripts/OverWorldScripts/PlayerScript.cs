using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerScript : MonoBehaviour{
    private int sanityLevel;
    private bool knifeCollected;
    private bool boardCollected;
    private bool keyCollected;

    public UIManagerScript uIManager;
    public MovementScript moveScript;
    //Testing purposes: private float lastTime;
    // Start is called before the first frame update
    void Awake()
    {
        sanityLevel = 0;
        knifeCollected = false;
        boardCollected = false;
        keyCollected = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        actionCall();
    }

    private void actionCall()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            Vector2 actionDir = getDirection();
            RaycastHit2D[] hits = Physics2D.RaycastAll(this.gameObject.transform.position,actionDir);
            foreach(RaycastHit2D hit in hits)
            {
                if(hit.collider.gameObject.name == "Cliff")
                {
                    if (boardCollected)
                    {
                        uIManager.displayInfo("Board used for cliff.");
                        hit.collider.gameObject.GetComponentInChildren<SpriteRenderer>().enabled = true;
                        hit.collider.enabled = false;

                    }
                }
                else if(hit.collider.gameObject.name == "doorsBossRoom")
                {
                    if(actionDir == new Vector2(-1.0f, 0.0f))
                    {
                        hit.collider.gameObject.SetActive(false);
                    }
                }
                else if(hit.collider.gameObject.tag == "Arrow")
                {
                    hit.collider.gameObject.GetComponent<ArrowLogic>().updateArrow();
                }
                else if(hit.collider.gameObject.name == "doorsExit")
                {
                    if (keyCollected)
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
                    }
                }
            }
          
        }
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
    public void pickupKey()
    {
        keyCollected = true;
    }
    public void pickupBoard()
    {
        boardCollected = true;
    }

    private Vector2 getDirection()
    {
        MovementScript.DIR lastDir = moveScript.getLastMovement();
        Vector2 actionDir = Vector2.zero;
            switch (lastDir)
            {
                case MovementScript.DIR.LEFT:
                    actionDir = new Vector2(-1.0f, 0.0f);
                    break;
                case MovementScript.DIR.RIGHT:
                    actionDir = new Vector2(1.0f, 0.0f);
                    break;
                case MovementScript.DIR.UP:
                    actionDir = new Vector2(0.0f, 1.0f);
                    break;
                case MovementScript.DIR.DOWN:
                    actionDir = new Vector2(0.0f, -1.0f);
                    break;
            }
        return actionDir;
    }

    public bool getKeyCollected()
    {
        return keyCollected;
    }

    public bool getBoardCollected()
    {
        return boardCollected;
    }
    public bool getKnifeCollected()
    {
        return knifeCollected;
    }
}
