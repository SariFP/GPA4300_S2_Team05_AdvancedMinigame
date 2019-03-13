using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameModeManager : MonoBehaviour
{
    [HideInInspector] public MainMenuManager MainMenu;
    public GameObject OneScreen;
    public GameObject SplitScreen;

    private void Start()
    {
        MainMenu.GetComponent<MainMenuManager>();
    }

    private void Update()
    {
        if (MainMenu.singlePlayer == true)
        {
            OneScreen.SetActive(true);
            SplitScreen.SetActive(false);
        }
        else if (MainMenu.multiPlayer == true)
        {
            OneScreen.SetActive(false);
            SplitScreen.SetActive(true);
        }
    }
}
