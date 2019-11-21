using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InfoText: MonoBehaviour{
	public Text textImageObject;
	private Vector3 mySpeed;
    private static int id = 0;
    private int myID;

	public InfoText(Text text,float speed) { 
		textImageObject = text;
		mySpeed = new Vector3(0.0f,speed, 0.0f);
        myID = id;
        id++;
	}
    // Start is called before the first frame update
    void Awake(){
        
    }

    // Update is called once per frame
    void Update(){
        Vector3 nextPos = textImageObject.transform.position + mySpeed;
        textImageObject.transform.position = Vector3.Lerp(textImageObject.transform.position, nextPos, 0.005f);
        
    }

    public Vector3 myPosition() {
        return textImageObject.transform.position;
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
}
