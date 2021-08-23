using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject UI;
    public GameObject Menu;
    public GameObject GameController;
    public GameObject Credits;
    Spawner spaw;



    public GameObject button;

    public Text text;

    bool newGameStarted = false;

    public void Start()
    {
        GameController.SetActive(false);
        UI.SetActive(false);
    }

    // Update is called once per frame
    
    public void mainMenu()
    {
        Time.timeScale = 0;
        UI.SetActive(false);
        Menu.SetActive(true);
        Credits.SetActive(false);
    }

    public void CreditsPage()
    {
        Time.timeScale = 0;
        UI.SetActive(false);
        Menu.SetActive(false);
        Credits.SetActive(true);
    }

    public void newGame()
    {
        Credits.SetActive(false);
        GameController.SetActive(true);
        UI.SetActive(true);
        Menu.SetActive(false);
        Time.timeScale = 1;
        button.SetActive(true);
        text.text = "Continue";

        if (newGameStarted == true)
        {
            SceneManager.LoadScene(0);
        }

        newGameStarted = true;      
    }
    
    public void newNewGame()
    {
        
        Time.timeScale = 1;
        GameController.SetActive(true);
        UI.SetActive(true);
        Menu.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
