using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManagerScript : MonoBehaviour
{
    public ArrowLogic greenArrow;
    public ArrowLogic redArrow;
    public ArrowLogic blueArrow;
    public UIManagerScript uiManager;
    public GameObject exitDoors;
    public GameObject exitDoorsOpen;
    //Answers to the puzzle.
    private bool puzzleSolved = false;
    private const int greenArrowAnswer = 2;
    private const int redArrowAnswer = 3;
    private const int blueArrowAnswer = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!puzzleSolved)
        {
            if (greenArrow.getSpriteIndex() == greenArrowAnswer && redArrow.getSpriteIndex() == redArrowAnswer && blueArrow.getSpriteIndex() == blueArrowAnswer)
            {
                puzzleSolved = true;
                uiManager.displayInfo("Puzzle has been solved.");
                Invoke("endMessage", 1.2f);
            }
        }
        else
        {
            exitDoors.SetActive(false);
            exitDoorsOpen.SetActive(true);
        }
    }

    private void endMessage()
    {
        uiManager.displayInfo("You may leave. >:)");
    }
}
