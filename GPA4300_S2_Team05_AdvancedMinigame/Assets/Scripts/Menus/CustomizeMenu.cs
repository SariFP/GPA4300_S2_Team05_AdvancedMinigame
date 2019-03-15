using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CustomizeMenu : MonoBehaviour
{
    [HideInInspector] public MainMenuManager mainMenu;

    [Header("CustomizePanels")]
    public GameObject LeilaCustomizer;
    public GameObject DanCustomizer;

    [Header("Sounds")]
    [Range(0, 1)]
    public float Volume = 1;
    public AudioClip ClickSound;

    private void Start()
    {
        LeilaCustomizer.SetActive(true);
        DanCustomizer.SetActive(false);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void LeilaFinishButton()
    {
        LeilaCustomizer.SetActive(false);
        AudioSource.PlayClipAtPoint(ClickSound, LeilaCustomizer.transform.position, Volume);
        DanCustomizer.SetActive(true);
    }

    public void DanFinishButton()
    {
        AudioSource.PlayClipAtPoint(ClickSound, DanCustomizer.transform.position, Volume);
        SceneManager.LoadScene(SceneManager.sceneCount + 1);
    }
}
