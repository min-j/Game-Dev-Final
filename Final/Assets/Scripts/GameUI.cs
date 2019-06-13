using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameUI : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject gameUI;
    [SerializeField] GameObject playerPrefab;
    [SerializeField] GameObject playerStartPosition;

    //[SerializeField] GameObject playButton;

    private void Start()
    {
        ShowMainMenu();
    }

    private void OnEnable()
    {
        EventManager.onStartGame += ShowGameUI;
        EventManager.onPlayerDeath += ShowMainMenu;
    }

    private void OnDisable()
    {
        EventManager.onStartGame -= ShowGameUI;
        EventManager.onPlayerDeath -= ShowMainMenu;
    }

    void ShowMainMenu()
    {
        mainMenu.SetActive(true);
        gameUI.SetActive(false);
    }

    void ShowGameUI()
    {
        mainMenu.SetActive(false);
        gameUI.SetActive(true);

        Instantiate(playerPrefab, playerStartPosition.transform.position, playerStartPosition.transform.rotation);
    }

}
