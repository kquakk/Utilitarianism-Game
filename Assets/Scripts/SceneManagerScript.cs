using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    [SerializeField] bool gamePaused;
    public GameObject pauseScreen;

    [SerializeField] float GPCD;

    //TITLE SCREEN/PAUSE SCREEN
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ReturnMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PauseGame()
    {
        pauseScreen.SetActive(true);
    }    

    public void UnpauseGame()
    {
        pauseScreen.SetActive(false);
        gamePaused = false;
    }    


    //GENERAL SCENES
    private void Start()
    {
        gamePaused = false;
    }
    private void Update()
    {
        if (gamePaused)
        {
            PauseGame();
        } else
        {
            UnpauseGame();
        }

        if (Input.GetKey(KeyCode.Escape) && !gamePaused && GPCD <= 0)
        {
            gamePaused = true;
            GPCD = 1.5f;
        } else if (Input.GetKey(KeyCode.Escape) && gamePaused && GPCD <= 0)
        {
            gamePaused= false;
            GPCD = 1.5f;
        }

        GPCD = GPCD - Time.deltaTime;

    }


    //ROOM 1 SCREEN
    public void EnterRoom2()
    {
        SceneManager.LoadScene(2);
    }

    //Room 2 screen
    public void EnterRoom3()
    {
        if (OrganDonatorScript.DonatorIsAlive == true)
        {
            ControllerScript.SavePeople(1);
        }

        SceneManager.LoadScene(3);
    }

    //Room 3 screen
    public void EnterRoom4()
    {
        SceneManager.LoadScene(4);
    }

    //Ending
    public void ShowEnding()
    {
        SceneManager.LoadScene(5);
    }



}
