using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public RectTransform pausePanelRect;
    public RectTransform quitTransform;
    public float topPosY, middlePosY;
    public float tweenDuration;
    public static bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused) ResumeGame();
            else PauseGame();
        }
    }

    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        pauseIntro();
    }

    public void QuitGame()
    {
        Debug.Log("lmao no");
        GameObject quit = GameObject.Find("quit");
        Vector2 pos = quit.transform.position;
        pos.x = Random.Range(-500, 1000);
        pos.y = Random.Range(-200, 200);
        quitTransform.DOAnchorPosX(pos.x, tweenDuration).SetUpdate(true);
        quitTransform.DOAnchorPosY(pos.y, tweenDuration).SetUpdate(true);
        quitTransform.DOShakeRotation(5, Vector2.right * 50).SetUpdate(true);
        //Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }

    void pauseIntro()
    {
        pausePanelRect.DOAnchorPosY(middlePosY, tweenDuration).SetUpdate(true);
    }
}
