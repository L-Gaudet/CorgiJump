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
    public GameObject SafetyNet;
    public GameObject PlayerCorgi; 


    private void Awake()
    {
        mainMenu();
    }

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
        resetGame();
    }

    public void resetGame()
    {
        deletePlatforms();
        deleteClouds();
        deletePlayer();
        deleteLevelGenerator();
    }

    public void deleteLevelGenerator()
    {
        GameObject generator = GameObject.FindGameObjectWithTag("Generator");
        Destroy(generator);
    }

    public void deletePlayer()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Destroy(player);
    }

    public void deleteClouds()
    {
        // get all the clouds
        GameObject[] cloudObjects = GameObject.FindGameObjectsWithTag("Cloud");
        foreach (GameObject gameObject in cloudObjects)
        {
            Destroy(gameObject);
        }
    }

    public void deletePlatforms()
    {
        // get all the platforms
        GameObject[] platformObjects = GameObject.FindGameObjectsWithTag("Platform");
        foreach(GameObject gameObject in platformObjects)
        {
            Destroy(gameObject);
        }
    }

    public void startGame()
    {
        MainMenuElements.SetActive(false);
        MainMenuPanel.SetActive(false);
        Game.SetActive(true);
        ScoreCanvas.SetActive(true);
        Instantiate(SafetyNet);
        PlayerCorgi.transform.position = new Vector3(-0.1f, -0.025f, -1f);
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
