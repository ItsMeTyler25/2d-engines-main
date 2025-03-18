using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip sadSound;
    public GameObject gameOverMenu;

    public void EndGame()
    {
        gameOverMenu.SetActive(true);
        Time.timeScale = 0f;
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(sadSound);
    }

    public void retryGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene( SceneManager.GetActiveScene().name);

    }

    public void quitGame()
    {
        Application.Quit();
    }
}
