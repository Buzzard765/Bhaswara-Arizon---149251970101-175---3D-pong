using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Core : MonoBehaviour
{
    public Action FindWinner;
    private bool HasWinner;
    public bool hasWinner_Acc{
        get{return HasWinner;}
        set{HasWinner = value;}
    }
    [SerializeField] private Text WinnerText;
    public Goal P1Goal, P2Goal, P3Goal, P4Goal;
    [SerializeField] private TextMeshProUGUI P1Score, P2Score, P3Score, P4Score;   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        P1Score.text = P1Goal.score_Acc.ToString();
        P2Score.text = P2Goal.score_Acc.ToString();
        P3Score.text = P3Goal.score_Acc.ToString();
        P4Score.text = P4Goal.score_Acc.ToString();
        ValidateWinner();
    }

     public void ValidateWinner(){
        if(P1Goal.score_Acc < 15 && P2Goal.score_Acc >= 15
        && P3Goal.score_Acc >= 15 && P4Goal.score_Acc >= 15){
            whichPlayerWins();
            Debug.Log("Player 1 Wins");
            WinnerText.text = "Player 1 Wins";
        }else if(P1Goal.score_Acc >= 15 && P2Goal.score_Acc < 15
        && P3Goal.score_Acc >= 15 && P4Goal.score_Acc >= 15){
            whichPlayerWins();
            Debug.Log("Player 2 Wins");
             WinnerText.text = "Player 2 Wins";
        }else if(P1Goal.score_Acc >= 15 && P2Goal.score_Acc >= 15
        && P3Goal.score_Acc < 15 && P4Goal.score_Acc >= 15){
            whichPlayerWins();
            Debug.Log("Player 3 Wins");
             WinnerText.text = "Player 3 Wins";
        }
        else if (P1Goal.score_Acc >= 15 && P2Goal.score_Acc >= 15
        && P3Goal.score_Acc >= 15 && P4Goal.score_Acc < 15){
            whichPlayerWins();
            Debug.Log("Player 4 Wins");
             WinnerText.text = "Player 4 Wins";
        }
    }

    public void whichPlayerWins(){
        HasWinner = true;
        FindWinner.Invoke();
    }
}
