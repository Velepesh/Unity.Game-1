using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;

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
        int menuSceneIndex = SceneManager.GetActiveScene().buildIndex - 1;
        SceneManager.LoadScene(menuSceneIndex);
        Time.timeScale = 1;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
