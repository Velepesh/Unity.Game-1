using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverMenu;
    [SerializeField] private Player _player;

    private readonly string _menuScene = "MenuScene";

    private void OnEnable()
    {
        _player.PlayerDied += OnPlayerDied;
    }

    private void OnDisable()
    {
        _player.PlayerDied -= OnPlayerDied;
    }

    private void OnPlayerDied()
    {
        _gameOverMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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
