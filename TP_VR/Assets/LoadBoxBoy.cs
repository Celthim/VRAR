using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadBoxBoy : MonoBehaviour {

    string levelToLoad = "Ethan_BoxBoy";

    void OnTriggerEnter(Collider other){
        SceneManager.LoadScene(levelToLoad);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
