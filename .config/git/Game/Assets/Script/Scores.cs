using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour {
    public GameObject button1;
    public enum Score {
           Player1Score, Player2Score
    }

    void Start()
    {
        button1.gameObject.SetActive(false);
    }

    public Text Player1Txt, Player2Txt;

    private int player1Scores, player2Scores;

    public void Increment(Score whichScore)
    {
        if (whichScore == Score.Player1Score)
        {
            Player1Txt.text = (++player1Scores).ToString();
    }
        else
        {
            Player2Txt.text = (++player2Scores).ToString();
    }
        if (player1Scores == 5)
        {
            Player1Txt.text = "Winner";
            button1.gameObject.SetActive(true);
            
        }
        else if (player2Scores == 5)
        {
            Player2Txt.text = "Winner";
            button1.gameObject.SetActive(true);
        }
    }

        /*
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
        */

    }
