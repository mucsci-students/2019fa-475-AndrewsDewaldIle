using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InfoText{
	public Text textImageObject;
	private Vector2 mySpeed;
    private static int id = 0;
    private int myID;

	public InfoText(Text text,float speed) { 
		textImageObject = text;
        speed = -speed;
		mySpeed = new Vector2(0.0f,speed);
        myID = id;
        id++;
	}

    // Update is called once per frame
    public void Update(){
        Vector2 nextPos = textImageObject.rectTransform.anchoredPosition + mySpeed;
        textImageObject.rectTransform.anchoredPosition = Vector2.Lerp(textImageObject.rectTransform.anchoredPosition, nextPos, 0.5f);
        
    }

    public Vector2 myPosition() {
        return textImageObject.rectTransform.anchoredPosition;
    }

    public bool sameInfoText(List<InfoText> rList, InfoText anotherIT) {
        foreach (InfoText info in rList) {
            if(info == this)
            return true;
        }
        return false;
        
    }
    public int getID(){
        return myID;
    }

    public void setPosText(float xPos, float yPos) {
        textImageObject.rectTransform.anchoredPosition = new Vector2(xPos, yPos);
    }
}
