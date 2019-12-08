using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerScript : MonoBehaviour{
    //public Image SanityMeter;
    public PlayerScript Player;
    public Text originalText;
    public List<InfoText> listInfoText;
    public float infoTextSpeed;
    public Sprite[] brainSprites;
    public Canvas uiCanvas;

    private float bottomScreenLimit = -280.0f;
    // Start is called before the first frame update
    void Awake(){
        listInfoText = new List<InfoText>();
        beginningInfo();
    }

    // Update is called once per frame
    void Update(){
        updateUI();
    }

    public void updateUI(){
        //int sanityLevel = Player.getSanityLevel();
        //SanityMeter.sprite = brainSprites[sanityLevel];

        if (listInfoText.Count != 0) {
            List<InfoText> removeText = new List<InfoText>();
            foreach(InfoText info in listInfoText) {
                info.Update();
                if (info.textImageObject.rectTransform.anchoredPosition.y < bottomScreenLimit) {
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
    }

    public void displayInfo(string text) {
        Text newText = Instantiate(originalText);
        newText.text = text;
        newText.transform.SetParent(uiCanvas.transform);
        newText.rectTransform.anchoredPosition = new Vector2(0,0);
        InfoText infoText = new InfoText(newText, infoTextSpeed);
        listInfoText.Add(infoText);
    }

    private void beginningInfo()
    {
        displayInfo("Movement: Arrow Keys");
        Invoke("endInfo", 1.2f);
    }
    private void endInfo()
    {
        displayInfo("Action: Spacebar");
    }
}
