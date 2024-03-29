using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Leaderboard : MonoBehaviour
{
    /*
     - use an array of legnth 5 to hold scores (integers)
     - loop thru array and check:
        if(i < array(i+1); wait, check if theres a sort method call
     */

    public Text currentScoreText;
    public Text[] scoreSlots = new Text[5];

    private int[] scoreArray = new int[6];
    private int currentScoreInt;

    private void Awake()
    {
        GetScoresFromPlayerPrefs();
    }

    public void getCurrentScoreAsInt()
    {
        String s = currentScoreText.text.ToString(); // gets score text as string
        currentScoreInt = int.Parse(s.Split(' ')[1]); // parses the score text string and gets second component which is the score and converts to int
        UpdateScoreArray();
        print(currentScoreInt);
    }


    public void setScores()
    {
        setLeaderboard();
        SetScoresToPlayerPrefs();
        saveScoresToDisk();
    }

    private void saveScoresToDisk()
    {
        PlayerPrefs.Save();
        print("saved");
    }

    private void setLeaderboard()
    {
        for(int i = 0; i < 5; i++)
        {
            scoreSlots[i].text = (i + 1).ToString() + ". " + scoreArray[i].ToString();
        }
    }

    private void GetScoresFromPlayerPrefs()
    {
        int score;
        for(int i = 0; i < 6; i++)
        {
            score = PlayerPrefs.GetInt("score" + i);
            scoreArray[i] = score;
        }
    }

    private void UpdateScoreArray()
    {
        for(int i = 0; i < 5; i++)
        {
            if(currentScoreInt > scoreArray[i])
            {
                int j = 5;
                do
                {
                    scoreArray[j] = scoreArray[j - 1];
                    --j;

                } while (j > i);

                scoreArray[i] = currentScoreInt;
                break;
            }
        }
    }

    private void SetScoresToPlayerPrefs()
    {
        for(int i = 0; i < 6; i++)
        {
            PlayerPrefs.SetInt("score" + i.ToString(), scoreArray[i]);
        }
    }
}
