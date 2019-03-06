using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CustomizeMenu : MonoBehaviour
{
    [Header("CustomizePanels")]
    public GameObject LeilaCustomizer;
    public GameObject DanCustomizer;

    private void Start()
    {
        LeilaCustomizer.SetActive(true);
        DanCustomizer.SetActive(false);
    }

    public void LeilaFinishButton()
    {
        LeilaCustomizer.SetActive(false);
        DanCustomizer.SetActive(true);
    }

    public void DanFinishButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
