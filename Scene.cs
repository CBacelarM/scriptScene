//TROCA DE CENA (GAME OVER, MENU E PAUSE)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    void OnEnable()
    {
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
    void Update()
    {
        GetComponent<CanvasGroup>().alpha += Time.deltaTime * 0.5f;
    }
}

//MENU
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void NewGame()
    {

        SceneManager.LoadScene("Level1");
    }

    public void Inicio()
    {
        SceneManager.LoadScene("Inicio");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void GoBackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}

//PAUSE

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public void OnEnable()
    {
        GetComponent<CanvasGroup>().alpha = 1;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        Time.timeScale = 0f;
    }

    public void OnDisable()
    {
        Time.timeScale = 1;
        GetComponent<CanvasGroup>().alpha = 0;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
}
