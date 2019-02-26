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

    private void OnCollisionEnter(Collision goal)
    {
        if (goal.gameObject == PlayerLeila || goal.gameObject == PlayerDan)
        {
            GoalText.text = "1/2";
        }

        if (goal.gameObject == PlayerLeila && goal.gameObject == PlayerDan)
        {
            GoalText.text = "2/2";
            ReachedText.text = "You reached the Goal.";
            SceneManager.LoadScene("SampleScene");
        }
    }
}
