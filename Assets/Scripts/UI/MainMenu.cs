using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Animator))]
public class MainMenu : MonoBehaviour
{
    private Animator _animator;

    private readonly string _gameScene = "GameScene";

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void Play()
    {
        SceneManager.LoadScene(_gameScene);
        Time.timeScale = 1;
    }

    public void OpenСreatorsPanel()
    {
        _animator.SetTrigger("OpenCreatorsPanel");
    }

    public void CloseСreatorsPanel()
    {
        _animator.SetTrigger("CloseСreatorsPanel");
    }

    public void Exit()
    {
        Application.Quit();
    }
}