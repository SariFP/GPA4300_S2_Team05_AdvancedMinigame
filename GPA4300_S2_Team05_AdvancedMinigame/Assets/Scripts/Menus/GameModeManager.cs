using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameModeManager : MonoBehaviour
{
    public GameObject OneScreen;
    public GameObject SplitScreen;

    private void Update()
    {
        if (PlayerPrefs.GetInt("PlayerChoice") == 1)
        {
            OneScreen.SetActive(true);
            SplitScreen.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("PlayerChoice") == 2)
        {
            OneScreen.SetActive(false);
            SplitScreen.SetActive(true);
        }
    }
}
