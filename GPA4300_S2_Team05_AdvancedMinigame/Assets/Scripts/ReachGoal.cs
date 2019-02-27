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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == PlayerLeila || collision.gameObject == PlayerDan)
        {
            GoalText.text = "1/2";
        }

        if (collision.gameObject == PlayerLeila && collision.gameObject == PlayerDan)
        {
            GoalText.text = "2/2";
            ReachedText.text = "You reached the Goal.";
            SceneManager.LoadScene("SampleScene");
        }
    }
}
