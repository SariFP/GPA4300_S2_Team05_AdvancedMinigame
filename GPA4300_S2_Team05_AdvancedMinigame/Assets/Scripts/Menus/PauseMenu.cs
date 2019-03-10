using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [Header("GameObjects")]
    public GameObject PausePanel;
    public GameObject OptionsMenu;
    public GameObject PlayerLeila;
    public GameObject PlayerDan;

    [Header("Sounds")]
    [Range(0, 1)]
    public float Volume = 1;
    public AudioClip ClickSound;

    public bool showCursor = false;


    [HideInInspector] public bool isPaused = false;

    private bool isPressed;

    // Start is called before the first frame update
    void Start()
    {
        PausePanel.SetActive(false);
        Unpause();

        if (showCursor)
        {
            Cursor.visible = (true);
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.visible = (false);
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause") && !isPressed && !isPaused)
        {
            isPressed = true;
            PausePanel.SetActive(!PausePanel.activeSelf);
            AudioSource.PlayClipAtPoint(ClickSound, PlayerLeila.transform.position, Volume);
            AudioSource.PlayClipAtPoint(ClickSound, PlayerDan.transform.position, Volume);
        }
        else if (isPressed)
        {
            isPressed = false;
        }

        if (PausePanel.activeSelf && isPressed)
        {
            //LockStates(true, true, true);
            PlayerLeila.transform.GetComponent<CameraControll>().enabled = false;
            PlayerDan.transform.GetComponent<CameraControll>().enabled = false;
            PlayerLeila.GetComponent<PlayerControll>().controllable = false;
            PlayerDan.GetComponent<PlayerControll>().controllable = false;
            ShowCursor(true);

        }
        else if (isPressed)
        {
            //LockStates(false, true, true);
            PlayerLeila.transform.GetComponent<CameraControll>().enabled = true;
            PlayerDan.transform.GetComponent<CameraControll>().enabled = true;
            PlayerLeila.GetComponent<PlayerControll>().controllable = false;
            PlayerDan.GetComponent<PlayerControll>().controllable = false;
            ShowCursor(true);
        }
    }

    public void BackToMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
        AudioSource.PlayClipAtPoint(ClickSound, PlayerLeila.transform.position, Volume);
        AudioSource.PlayClipAtPoint(ClickSound, PlayerDan.transform.position, Volume);
    }

    public void ResumeButton()
    {
        Unpause();
        AudioSource.PlayClipAtPoint(ClickSound, PlayerLeila.transform.position, Volume);
        AudioSource.PlayClipAtPoint(ClickSound, PlayerDan.transform.position, Volume);
    }

    public void OptionsButton()
    {
        OptionsMenu.SetActive(true);
        PausePanel.SetActive(false);
        AudioSource.PlayClipAtPoint(ClickSound, PlayerLeila.transform.position, Volume);
        AudioSource.PlayClipAtPoint(ClickSound, PlayerDan.transform.position, Volume);
    }

    public void BackButton()
    {
        OptionsMenu.SetActive(false);
        PausePanel.SetActive(true);
        AudioSource.PlayClipAtPoint(ClickSound, PlayerLeila.transform.position, Volume);
        AudioSource.PlayClipAtPoint(ClickSound, PlayerDan.transform.position, Volume);
    }

    //public void LockStates(bool LockState, bool Controller, bool CursorVisible)
    //{
    //    switch (LockState)
    //    {
    //        case true:
    //            PlayerLeila.transform.GetComponent<CameraControll>().enabled = false;
    //            PlayerDan.transform.GetComponent<CameraControll>().enabled = false;
    //            if (Controller)
    //            {
    //                PlayerLeila.GetComponent<PlayerControll>().controllable = false;
    //                PlayerDan.GetComponent<PlayerControll>().controllable = false;
    //            }
    //            if (CursorVisible)
    //            {
    //                ShowCursor(true);
    //            }
    //            break;
    //        case false:
    //            PlayerLeila.transform.GetComponent<CameraControll>().enabled = true;
    //            PlayerDan.transform.GetComponent<CameraControll>().enabled = true;
    //            if (Controller)
    //            {
    //                PlayerLeila.GetComponent<PlayerControll>().controllable = true;
    //                PlayerDan.GetComponent<PlayerControll>().controllable = true;
    //            }
    //            if (CursorVisible)
    //            {
    //                ShowCursor(false);
    //            }
    //            break;
    //    }
    //}

    public void Unpause()
    {
        if (PausePanel.activeSelf)
        {
            PausePanel.SetActive(false);
        }
        //LockStates(false, true, true);
        isPaused = false;
    }

    public void ShowCursor(bool state)
    {
        switch (state)
        {
            case true:
                Cursor.visible = (true);
                Cursor.lockState = CursorLockMode.None;
                break;
            case false:
                Cursor.visible = (false);
                Cursor.lockState = CursorLockMode.Locked;
                break;
        }
    }

}
