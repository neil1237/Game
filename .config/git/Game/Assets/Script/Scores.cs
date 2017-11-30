using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour {
    int score = 0;


    [SerializeField]Text textComponent;

	// Use this for initialization
	void Start () {
        Update();
	}
	
	// Update is called once per frame
	void Update () {
        score++;
        textComponent.text = "Changing"+score;
	}

}
