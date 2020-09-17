using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;

    private readonly string _menuScene = "MenuScene";

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OpenPanel();
        }
    }

    private void OpenPanel()
    {
        _pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Continue()
    {
        _pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void Menu()
    {
        SceneManager.LoadScene(_menuScene);
        Time.timeScale = 1;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
