using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text winText;
    public TMP_Text loseText;
    public GameObject gameOverButtons;

    public void GameWon()
    {
        winText.gameObject.SetActive(true);
        StartCoroutine(GoToMenuAfterDelay());
    }

    public void GameLost()
    {
        loseText.gameObject.SetActive(true);
        gameOverButtons.SetActive(true);
        StartCoroutine(GoToMenuAfterDelay());
    }
    public void TryAgain()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator GoToMenuAfterDelay()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("MenuScene");
    }
}