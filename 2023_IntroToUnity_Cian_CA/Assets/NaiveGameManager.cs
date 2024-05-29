using AVR;
using System;
using UnityEngine;

/// <summary>
/// Manages UI and Menu, monitors player state(win/lose)
/// </summary>
public class NaiveGameManager : MonoBehaviour, IHandleTicks
{
    public GameObject menuObject;

    public GameObject uiObject;

    // Start is called before the first frame update
    private void Start()
    {
        TimeTickSystem.Instance.RegisterListener(
            TimeTickSystem.TickRateMultiplierType.EighthTime,
            HandleTick);

        ShowMenu();
        StartGame();
        //start game
        //check player state
    }

    public void HandleTick()
    {
        Debug.Log($"{Time.fixedTime}");
        if (CheckGameState())
            EndGame();
    }

    private void StartGame()
    {
        //set camera, play intro music etc
    }

    private bool CheckGameState()
    {
        //check inventory, check win/lose etc
        return true;
    }

    private void EndGame()
    {
        //win/lose
    }

    [ContextMenu("ShowMenu")]
    public void ShowMenu()
    {
        //show menu and pause the game
        if (!menuObject.activeSelf)
        {
            menuObject.SetActive(true);  //show menu
            Time.timeScale = 0;  //pause game
            //hide UI
        }
    }

    [ContextMenu("HideMenu")]
    public void HideMenu()
    {
        //show menu and pause the game
        if (menuObject.activeSelf)
        {
            menuObject.SetActive(false);  //hide menu
            Time.timeScale = 1;  //unpause game
            //show UI
        }
    }

    private void Update()
    {
        HandleEscape();
    }

    private void HandleEscape()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (menuObject.activeSelf)
                HideMenu();
            else
                ShowMenu();
        }
    }
}