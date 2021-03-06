﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupScript : MonoBehaviour
{
    private string tagName;
    public UIManagerScript uiManager;
    public PlayerScript player;
    // Start is called before the first frame update
    void Awake()
    {
        tagName = this.gameObject.tag;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            switch (tagName)
            {
                case "Knife":
                    player.pickupKnife();
                    uiManager.displayInfo("Collected: Knife");
                    break;
                case "Board":
                    player.pickupBoard();
                    uiManager.displayInfo("Collected: Board");
                    break;
                case "Key":
                    player.pickupKey();
                    uiManager.displayInfo("Collected: Key");
                    break;
            }
            Destroy(this.gameObject);
        }
    }
}
