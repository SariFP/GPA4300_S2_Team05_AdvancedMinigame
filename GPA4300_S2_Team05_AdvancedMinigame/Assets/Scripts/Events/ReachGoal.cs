using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReachGoal : MonoBehaviour
{
    [Header("GameObjects")]
    public GameObject PlayerLeila;
    public GameObject PlayerDan;
    public GameObject GoalPanel;

    [Header("Texts")]
    public Text GoalText;
    public Text ReachedText;

    [Header("Sounds")]
    [Range(0, 1)]
    public float Volume = 1;
    public AudioClip GoalSound;
    public AudioClip ClickSound;

    private bool leilaReachedGoal = false;
    private bool danReachedGoal = false;

    private void OnCollisionEnter(Collision player)
    {
        if (player.gameObject == PlayerLeila)
        {
            GoalText.text = "1/2";
            leilaReachedGoal = true;
        }
        else if (player.gameObject == PlayerDan)
        {
            GoalText.text = "1/2";
            danReachedGoal = true;
        }

        if (danReachedGoal && leilaReachedGoal)
        {
            GoalText.text = "2/2";
            ReachedText.text = "You reached the Goal.";
            AudioSource.PlayClipAtPoint(GoalSound, PlayerDan.transform.position, Volume);
            AudioSource.PlayClipAtPoint(GoalSound, PlayerLeila.transform.position, Volume);
            StartCoroutine(WaitGoal());
        }
    }

    IEnumerator WaitGoal()
    {
        yield return new WaitForSecondsRealtime(5f);
        GoalText.text = "";
        ReachedText.text = "";
        GoalPanel.SetActive(true);
    }

    public void NextLevelButton()
    {
        AudioSource.PlayClipAtPoint(ClickSound, PlayerLeila.transform.position, Volume);
        AudioSource.PlayClipAtPoint(ClickSound, PlayerDan.transform.position, Volume);
        SceneManager.LoadScene("SampleScene");
    }
    public void BackToMainMenuButton()
    {
        AudioSource.PlayClipAtPoint(ClickSound, PlayerLeila.transform.position, Volume);
        AudioSource.PlayClipAtPoint(ClickSound, PlayerDan.transform.position, Volume);
        SceneManager.LoadScene("MainMenu");
    }
}
