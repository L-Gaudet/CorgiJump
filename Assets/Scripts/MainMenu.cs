using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject Game;
    public GameObject MainMenuElements;
    public GameObject MainMenuPanel;
    public GameObject GameReverse;
    public GameObject GameOverPanel;
    public GameObject ScoreCanvas;


    private void Awake()
    {
        mainMenu();
    }

    //// Start is called before the first frame update
    //void Start()
    //{
    //    GameReverse.SetActive(false);
    //    Game.SetActive(false);
    //    MainMenuCorgi.SetActive(true);
    //    MainMenuPanel.SetActive(true);
    //    GameOverPanel.SetActive(false);

    //}

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mainMenu()
    {
        GameReverse.SetActive(false);
        Game.SetActive(false);
        MainMenuElements.SetActive(true);
        MainMenuPanel.SetActive(true);
        GameOverPanel.SetActive(false);
        ScoreCanvas.SetActive(false);
    }

    public void Reset()
    {
        Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, 1f, Camera.main.transform.position.z);
        GameReverse.SetActive(false);
        Game.SetActive(false);
        MainMenuElements.SetActive(true);
        MainMenuPanel.SetActive(true);
        GameOverPanel.SetActive(false);
        ScoreCanvas.SetActive(false);
    }

    public void startGame()
    {
        MainMenuElements.SetActive(false);
        MainMenuPanel.SetActive(false);
        Game.SetActive(true);
        ScoreCanvas.SetActive(true);
    }

    public void startGameReverse()
    {
        MainMenuElements.SetActive(false);
        MainMenuPanel.SetActive(false);
        GameReverse.SetActive(true);
        ScoreCanvas.SetActive(true);
    }

    public void GameOver()
    {
        GameOverPanel.SetActive(true);
    }

}
