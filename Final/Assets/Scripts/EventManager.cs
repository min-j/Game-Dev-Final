using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void StartGameDelegate();
    public static StartGameDelegate onStartGame;
    public static StartGameDelegate onPlayerDeath;

    public delegate void TakeDamageDelegate(float amt);
    public static TakeDamageDelegate onTakeDamage;

    public delegate void ScorePointsDelegate(int amt);
    public static ScorePointsDelegate onScorePoints;

    public static void StartGame() {
        //Debug.Log("Start the Game");
        if (onStartGame != null)
            onStartGame();
    }

    public static void TakeDamage(float percent)
    {
        if (onTakeDamage != null)
            onTakeDamage(percent);
    }

    public static void PlayerDeath()
    {
        //Debug.Log("Start the Game");
        if (onPlayerDeath != null)
            onPlayerDeath();
    }

    public static void ScorePoint(int score)
    {
        if (onScorePoints != null)
            onScorePoints(score);
    }
}
