using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReachGoal : MonoBehaviour
{
    public GameObject PlayerLeila;
    public GameObject PlayerDan;

    public Text GoalText;
    public Text ReachedText;

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
            StartCoroutine(WaitGoal());
        }
    }

    IEnumerator WaitGoal()
    {
        yield return new WaitForSecondsRealtime(10f);
        SceneManager.LoadScene("SampleScene");
    }
}
