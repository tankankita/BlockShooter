using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreClass
{
    public int gameScore = 0;

    public ScoreClass(int score)
    {
        gameScore = score;
    }

    public void increaseScore()
    {
        gameScore = gameScore++;
    }

    public int getScore()
    {
        return gameScore;
    }
}
