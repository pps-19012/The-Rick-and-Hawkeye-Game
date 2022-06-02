using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHelper : MonoBehaviour
{
    [SerializeField] private string sceneName;
    [SerializeField] private string sceneName1;

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void GoToPreviousLevel()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Restart()
    {
        SceneManager.LoadScene(sceneName1);
    }
}
