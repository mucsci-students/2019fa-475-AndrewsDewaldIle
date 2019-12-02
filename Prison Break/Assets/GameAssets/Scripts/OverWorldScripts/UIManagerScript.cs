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
    public Sprite[] brainSprites;
    public Canvas uiCanvas;
    private int called = 0;
    // Start is called before the first frame update
    void Awake(){
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
                info.Update();
                if (info.textImageObject.rectTransform.anchoredPosition.y < -400.0f) {
                    removeText.Add(info);
                }
            }
            if (removeText.Count != 0){
                foreach (InfoText info1 in removeText)
                {
                    Destroy(info1.textImageObject.gameObject);
                    listInfoText.RemoveAll(r => r.getID() == info1.getID());
                   
                }
            }
            
        }

        if (called < 1) {
            displayInfo("Did it work.");
            called += 1;
        }

    }

    public void displayInfo(string text) {
        Text newText = Instantiate(originalText);
        newText.text = text;
        newText.transform.SetParent(uiCanvas.transform);
        newText.rectTransform.anchoredPosition = new Vector2(0,0);
        InfoText infoText = new InfoText(newText, infoTextSpeed);
        listInfoText.Add(infoText);
    }
}
