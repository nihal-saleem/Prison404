using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [Header("Panels")]
    public GameObject settingsPanel;
    public GameObject controllerPanel;
    public GameObject aboutPanel;

    [Header("Audio")]
    public Slider volumeSlider;

    private bool isMuted = false;

    void Start()
    {
        settingsPanel.SetActive(false);
        controllerPanel.SetActive(false);
        aboutPanel.SetActive(false);

        volumeSlider.value = AudioListener.volume;
    }

    // START GAME
    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }

    // OPEN SETTINGS
    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
    }

    // CLOSE SETTINGS
    public void CloseSettings()
    {
        settingsPanel.SetActive(false);
    }

    // QUIT GAME
    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    // SOUND BUTTON
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

    // VOLUME SLIDER
    public void AdjustVolume()
    {
        if (!isMuted)
        {
            AudioListener.volume = volumeSlider.value;
        }
    }

    // CONTROLLER PANEL
    public void OpenControllerPanel()
    {
        controllerPanel.SetActive(true);
    }

    public void CloseControllerPanel()
    {
        controllerPanel.SetActive(false);
    }

    // ABOUT PANEL
    public void OpenAboutPanel()
    {
        aboutPanel.SetActive(true);
    }

    public void CloseAboutPanel()
    {
        aboutPanel.SetActive(false);
    }
}