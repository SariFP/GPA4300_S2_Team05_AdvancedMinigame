using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameModeManager : MonoBehaviour
{
    [HideInInspector] public MainMenuManager mainMenuManager;
    public GameObject OneScreen;
    public GameObject SplitScreen;

    private void Start()
    {
        mainMenuManager.MainMenu.GetComponent<MainMenuManager>();
    }

    private void Update()
    {
        if (mainMenuManager.singlePlayer == true)
        {
            OneScreen.SetActive(true);
            SplitScreen.SetActive(false);
        }
        else if (mainMenuManager.multiPlayer == true)
        {
            OneScreen.SetActive(false);
            SplitScreen.SetActive(true);
        }
    }
}
