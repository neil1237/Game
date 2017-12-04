using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Winner : MonoBehaviour {
    public Scores scores;
    public Text Score1, Score2, Winner;

    void Start () {
        scores.player1Scores=PlayerPrefs.GetInt("Player 1 Score");
        scores.player2Scores= PlayerPrefs.GetInt("Player 2 Score");
        Score1.text = (scores.player1Scores).ToString();
        Score2.text = (scores.player2Scores).ToString();
        if (scores.player1Scores > scores.player2Scores)
        {
            Winner.text = ("The winner is player 1");
        }
        else
            Winner.text = ("The winner is player 2");
    }

        
    }