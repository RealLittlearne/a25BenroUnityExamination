using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class StartNewGameScript : MonoBehaviour
{
    public UnityEvent OnStartNewGame;
    private float timerBeforeSceneChange = 2f;
    private bool timerHasStarted;

    public void Update()
    {
        if (timerHasStarted)
        {
            timerBeforeSceneChange -= Time.deltaTime;
            if (timerBeforeSceneChange <= 0)
            {
                SceneManager.LoadSceneAsync("Level1", LoadSceneMode.Single);
            }
        }
    }

    public void ChangeScene()
    {
        OnStartNewGame?.Invoke();
        timerHasStarted = true;
    }
}
