using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour {
    bool gameStarted = false;

    public Text textComponent;

    int score1 = 0;
    int score2 = 0;

    public Transform Player2Score;
    public Transform Player1Score;
    private void Start()
    {
        transform.position = new Vector3(0.67f,-1.54f,-1.13f);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            gameStarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, 5f);
        }
        if (transform.position.x < Player2Score.transform.position.x)
        {
            transform.position = new Vector3(0.67f, -1.54f, -1.13f);
            score1++;
            textComponent.text = "Changing" + score1;
        }
        if (transform.position.x > Player1Score.transform.position.x)
        {
            transform.position = new Vector3(0.67f, -1.54f, -1.13f);
            score2++;
            textComponent.text = "Changing" + score2;
        }
        
    
    }
}
