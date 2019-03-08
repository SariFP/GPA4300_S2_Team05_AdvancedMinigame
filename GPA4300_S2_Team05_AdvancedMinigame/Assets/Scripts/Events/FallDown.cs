using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDown : MonoBehaviour
{
    public GameObject PlayerLeila;
    public GameObject PlayerDan;

    private void OnTriggerEnter(Collider fallDown)
    {
        if (fallDown.gameObject == PlayerLeila || fallDown.gameObject == PlayerDan)
        {
            SceneManager.LoadScene(SceneManager.sceneCount);
        }
    }
}
