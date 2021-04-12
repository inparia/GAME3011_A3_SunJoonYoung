using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneManagers : MonoBehaviour
{

    public Button bOne, bTwo, bThree;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(GameManager.instance.gameLevel)
        {
            case GameLevel.EASY:
                bOne.interactable = false;
                bTwo.interactable = true;
                bThree.interactable = true;
                break;
            case GameLevel.NORMAL:
                bOne.interactable = true;
                bTwo.interactable = false;
                bThree.interactable = true;
                break;
            case GameLevel.HARD:
                bOne.interactable = true;
                bTwo.interactable = true;
                bThree.interactable = false;
                break;
        }
    }

    public void easyGame()
    {
        GameManager.instance.gameLevel = GameLevel.EASY;
    }
    public void normalGame()
    {
        GameManager.instance.gameLevel = GameLevel.NORMAL;
    }
    public void hardGame()
    {
        GameManager.instance.gameLevel = GameLevel.HARD;
    }
    public void playGame()
    {
        switch (GameManager.instance.gameLevel)
        {
            case GameLevel.EASY:
                GameManager.instance.timer = 120;
                break;
            case GameLevel.NORMAL:
                GameManager.instance.timer = 90;
                break;
            case GameLevel.HARD:
                GameManager.instance.timer = 60;
                break;
        }
        GameManager.instance.gameStarted = true;
        SceneManager.LoadScene("Game");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ReturnToMenu()
    {
        GameManager.instance.ResetGame();
        SceneManager.LoadScene("Menu");
    }
}
