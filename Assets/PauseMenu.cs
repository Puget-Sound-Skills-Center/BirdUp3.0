using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void Pause()
    {
        pauseMenu.SetActive(true);
    }

    public void Resume()
    {

    }

    public void Menu()
    {

    }

    public void Restart()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
