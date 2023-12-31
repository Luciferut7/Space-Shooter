using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GoToSettingMenu()
    {
        SceneManager.LoadScene("SettingMenu");
    }

    public void GoToMainmenu()
    {
        SceneManager.LoadScene("Mainmenu");
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
