using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldBehaviour : MonoBehaviour {

    Text coinsText;
    int coins = 0;
    GameObject canvasObj;
    Transform child;

	// Use this for initialization
	void Start () {
        canvasObj = GameObject.Find("Canvas");
        child = canvasObj.transform.Find("lblCoins");
        coinsText = child.GetComponent<Text>();
	}

    public void AddCoin()
    {
        coins++;
        coinsText.text = "Coins : " + coins;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
