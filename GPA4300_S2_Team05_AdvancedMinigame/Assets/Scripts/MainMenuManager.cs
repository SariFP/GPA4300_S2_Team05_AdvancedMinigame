using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [Header("Menus")]
    public GameObject MainMenu;
    public GameObject OptionsMenu;
    public GameObject StartOptions;

    //[Header("MainMenu")]
    //public Button StartButton;
    //public Button OptionsButton;
    //public Button QuitButton;

    //[Header("StartOption")]
    //public Button Singleplayer;
    //public Button MultiPlayer;

    //[Header("OptionsMenu")]
    //public Slider Volume;

    public void StartButton_Click()
    {
        MainMenu.SetActive(false);
        StartOptions.SetActive(true);
    }
    public void SinglePlayer_Click()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void MultiPlayer_Click()
    {

    }
    
    public void OptionsButton_Click()
    {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(true);
    }

    public void QuitButton_Click()
    {
        Application.Quit();
    }

    public void BackToMainMenu_Click()
    {
        OptionsMenu.SetActive(false);
        StartOptions.SetActive(false);
        MainMenu.SetActive(true);
    }

    public void VolumeSlide()
    {

    }
}
