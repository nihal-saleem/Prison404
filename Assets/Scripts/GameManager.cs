using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Panels")]
    public GameObject pausePanel;
    public GameObject controllerPanel;
    public GameObject gameOverPanel;

    [Header("Audio")]
    public Slider volumeSlider;

    private bool isMuted = false;

    void Start()
    {
        pausePanel.SetActive(false);
        controllerPanel.SetActive(false);
        gameOverPanel.SetActive(false);

        Time.timeScale = 1f;

        volumeSlider.value = AudioListener.volume;
    }

    // PAUSE GAME
    public void PauseGame()
    {
        pausePanel.SetActive(true);

        Time.timeScale = 0f;
    }

    // RESUME GAME
    public void ResumeGame()
    {
        pausePanel.SetActive(false);

        controllerPanel.SetActive(false);

        Time.timeScale = 1f;
    }

    // RESTART GAME
    public void RestartGame()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(
            SceneManager.GetActiveScene().name
        );
    }

    // MAIN MENU
    public void LoadMainMenu()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("MainMenu");
    }

    // QUIT GAME
    public void QuitGame()
    {
        Debug.Log("Quit Game");

        Application.Quit();
    }

    // OPEN CONTROLLER PANEL
    public void OpenControllerPanel()
    {
        controllerPanel.SetActive(true);
    }

    // CLOSE CONTROLLER PANEL
    public void CloseControllerPanel()
    {
        controllerPanel.SetActive(false);
    }

    // SOUND ON/OFF
    public void ToggleSound()
    {
        isMuted = !isMuted;

        if (isMuted)
        {
            AudioListener.volume = 0f;
        }
        else
        {
            AudioListener.volume = volumeSlider.value;
        }
    }

    // VOLUME CONTROL
    public void AdjustVolume()
    {
        if (!isMuted)
        {
            AudioListener.volume = volumeSlider.value;
        }
    }

    // GAME OVER
    public void GameOver()
    {
        gameOverPanel.SetActive(true);

        Time.timeScale = 0f;
    }

    // TEST GAME OVER
    // PRESS G
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            GameOver();
        }
    }
}