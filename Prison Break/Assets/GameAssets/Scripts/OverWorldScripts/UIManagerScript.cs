using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManagerScript : MonoBehaviour{
    public Image SanityMeter;
    public PlayerScript Player;
    public Text originalText;
    public List<InfoText> listInfoText;
    public float infoTextSpeed;
    private string infoToDisplay;
    public Sprite[] brainSprites;
    private int called = 0;
    // Start is called before the first frame update
    void Awake(){
        infoToDisplay = "";
        listInfoText = new List<InfoText>();
    }

    // Update is called once per frame
    void Update(){
        updateUI();
    }

    public void updateUI(){
        int sanityLevel = Player.getSanityLevel();
        SanityMeter.sprite = brainSprites[sanityLevel];




        if (listInfoText.Count != 0) {
            Debug.Log("List Count:" + listInfoText.Count);
            List<InfoText> removeText = new List<InfoText>();
            foreach(InfoText info in listInfoText) {
                if (info.textImageObject.transform.position.y > 200.0f) {
                    removeText.Add(info);
                }
            }
            if (removeText.Count != 0){
                foreach (InfoText info1 in removeText)
                    listInfoText.RemoveAll(r => r.getID() == info1.getID());
            }
            
        }

        if (called < 1) {
            displayInfo("Did it work.");
            called++;
        }
    }

    public void displayInfo(string text) {
        Text newText = Instantiate(originalText);
        InfoText infoText = new InfoText(newText,infoTextSpeed);
        listInfoText.Add(infoText);
    }
}
