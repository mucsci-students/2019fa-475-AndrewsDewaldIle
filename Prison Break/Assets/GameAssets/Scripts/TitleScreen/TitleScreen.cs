using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    /* TODO
     * get button components
     * make start button change scene to overworld scene
     * make exit button close out of the game
     * 
    */

    public GameObject startButton;
    public GameObject exitButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("OverWorld");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
