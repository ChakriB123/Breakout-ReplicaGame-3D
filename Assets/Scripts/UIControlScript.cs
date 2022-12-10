using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIControlScript : MonoBehaviour
{
    GameObject MenuPanel;
    GameObject SettingsPanel;
    GameObject GamePanel;
    GameObject PausePanel;
    public GameObject GameOverPanel;


    public Text g_ScoreText;
    public Text g_LifeText;
    public Text HighScore;


    public Slider MusicVolume;
    public Toggle VolumeButton;
    

    bool StartButton;
    bool SettingButton;
    bool MenuButton;
    bool BackButton;
    private  bool ToggleButton_Flag = false;


    public AudioSource G_Music;

    public static bool GamePause = false;

    private float musicVolume = 1f;
   

    // Start is called before the first frame update
    void Start()
    {
        MusicVolume.value = PlayerPrefs.GetFloat("musicVol");


        G_Music = GetComponent<AudioSource>();

        StartButton = true;
        SettingButton = true;
        MenuButton = true;
        BackButton = true;
       

        MenuPanel = GameObject.Find("Menu Panel");
        SettingsPanel = GameObject.Find("Settings Panel");
        GamePanel = GameObject.Find("Game Panel");
        GameOverPanel = GameObject.Find("GameOver Panel");
        PausePanel = GameObject.Find("Pause Panel");



    }

    // Update is called once per frame
    void Update()
    {
        G_Music.volume = musicVolume;
       // VolumeButton.isOn = PlayerPrefs.
    }

    public void updateMusicVol(float vol)
    {
        musicVolume = vol;

        PlayerPrefs.SetFloat("musicVol", G_Music.volume);
    }

    public void m_OnClickStart()
    {
        if (StartButton == true)
        {
            MenuPanel.SetActive(false);
            GamePanel.SetActive(true);
            SettingsPanel.SetActive(false);
            GameOverPanel.SetActive(false);
            PausePanel.SetActive(false);
        }
    }
    public void m_OnClickSettings()
    {
        if (SettingButton == true)
        {
            MenuPanel.SetActive(false);
            SettingsPanel.SetActive(true);
        }
       
    }
    public void m_OnClickMenu()
    {
        if (MenuButton == true)
        {
            SettingsPanel.SetActive(false);
            MenuPanel.SetActive(true);
        }


    }
    public void m_OnclickPauseButton()
    {
        PausePanel.SetActive(true);

        Time.timeScale = 0f;
        GamePause = true;
    }

    public void m_OnclickResumeButton()
    {
        PausePanel.SetActive(false);

        Time.timeScale = 1f;
        GamePause = false;
    }

    public void m_OnclickBackIcon()
    {
        if (BackButton == true)
        {
            SettingsPanel.SetActive(false);
            MenuPanel.SetActive(true);
        }

    }

    public void m_OnClickHomeButton()
    {
        MenuPanel.SetActive(true);
    }

    public void m_OnClickRestartButton()
    {
        SceneManager.LoadScene("TileBracker");
        GameOverPanel.SetActive(false); 
    }

    public void m_OnClickQuitButton()
    {
        Application.Quit();
    }

    public void m_OnClickMusicOnOff()
    {
        if(ToggleButton_Flag == false)
        {
            ToggleButton_Flag = true;
            G_Music.Stop();
        }
        else
        {
            ToggleButton_Flag = false;
            G_Music.Play();
        }
    }

   
}
