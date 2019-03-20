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

    //[HideInInspector] public bool singlePlayer = false;
    //[HideInInspector] public bool multiPlayer = false;

    [Header("Sounds")]
    [Range(0, 1)]
    public float Volume = 1;
    public AudioClip ClickSound;

    public void StartButton()
    {
        StartOptions.SetActive(true);
        AudioSource.PlayClipAtPoint(ClickSound, transform.position, Volume);
        MainMenu.SetActive(false);
    }
    public void SinglePlayer()
    {
        AudioSource.PlayClipAtPoint(ClickSound, transform.position, Volume);
        SceneManager.LoadScene("CustomizeCharacter");
        //singlePlayer = true;
        PlayerPrefs.SetInt("PlayerChoice", 1);
    }
    public void MultiPlayer()
    {
        AudioSource.PlayClipAtPoint(ClickSound, transform.position, Volume);
        SceneManager.LoadScene("CustomizeCharacter");
        //multiPlayer = true;
        PlayerPrefs.SetInt("PlayerChoice", 2);
    }
    
    public void OptionsButton()
    {
        MainMenu.SetActive(false);
        AudioSource.PlayClipAtPoint(ClickSound, transform.position, Volume);
        OptionsMenu.SetActive(true);
    }

    public void QuitButton()
    {
        AudioSource.PlayClipAtPoint(ClickSound, transform.position, Volume);
        Application.Quit();
    }

    public void BackToMainMenu()
    {
        OptionsMenu.SetActive(false);
        StartOptions.SetActive(false);
        AudioSource.PlayClipAtPoint(ClickSound, transform.position, Volume);
        MainMenu.SetActive(true);
    }
}
