using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameUI : MonoBehaviour
{
    bool isDisplayed = true;
    [SerializeField] GameObject playButton;

    private void OnEnable()
    {
        EventManager.onStartGame += HidePanel;
    }

    private void OnDisable()
    {
        EventManager.onStartGame -= HidePanel;
    }

    void HidePanel() {
        isDisplayed = !isDisplayed;
        playButton.SetActive(isDisplayed);

        /*if (isDisplayed)
        {
            playButton.SetActive(false);
        }
        else {
            playButton.SetActive(true);
        }*/
    }

    public void PlayGame()
    {
        EventManager.StartGame();
    }
}
