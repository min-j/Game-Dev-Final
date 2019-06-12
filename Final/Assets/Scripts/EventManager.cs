using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void StartGameDelegate();
    public static StartGameDelegate onStartGame;

    public static void StartGame() {
        //Debug.Log("Start the Game");
        if (onStartGame != null)
            onStartGame();
    }
}
