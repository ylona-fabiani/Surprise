using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject settingsWindow;
    public GameObject commandesWindow;
    public GameObject histoireWindow;
    public GameObject titre;
    public GameObject soustitre;

    public void StartGame()
    {
        histoireWindow.SetActive(true);
    }

    public void SettingsButton()
    {
        settingsWindow.SetActive(true);
        titre.SetActive(false);
        soustitre.SetActive(false);
    }

    public void CloseSettingsWindow()
    {
        settingsWindow.SetActive(false);
        titre.SetActive(true);
        soustitre.SetActive(true);
    }

    public void CommandesButton()
    {
        commandesWindow.SetActive(true);
        titre.SetActive(false);
        soustitre.SetActive(false);
    }

    public void CloseCommandesWindow()
    {
        commandesWindow.SetActive(false);
        titre.SetActive(true);
        soustitre.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Continuer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
