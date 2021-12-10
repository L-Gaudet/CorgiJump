using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject Game;
    public GameObject MainMenuCorgi;
    public GameObject MainMenuPanel;
    public GameObject GameReverse;
    public GameObject GameOverPanel;


    private void Awake()
    {
        GameReverse.SetActive(false);
        Game.SetActive(false);
        MainMenuCorgi.SetActive(true);
        MainMenuPanel.SetActive(true);
        GameOverPanel.SetActive(false);
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

    public void startGame()
    {
        MainMenuCorgi.SetActive(false);
        MainMenuPanel.SetActive(false);
        Game.SetActive(true);
    }

    public void startGameReverse()
    {
        MainMenuCorgi.SetActive(false);
        MainMenuPanel.SetActive(false);
        GameReverse.SetActive(true);
    }

    public void GameOver()
    {
        GameOverPanel.SetActive(true);
    }

}
