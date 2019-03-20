using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterConfigurator : MonoBehaviour
{
    public CharacterConfigurator CharConfig;

    [Header("BodyParts")]
    public GameObject Torso;
    public GameObject Hair;

    [Header("Customizables")]
    public List<GameObject> hair;

    private int currentHair;

    private void Start()
    {
        currentHair = Hair.Length - 1;
    }

    public void NextHat()
    {
        if (currentHair == hair.Count - 1)
            currentHair = 0;
        else
            currentHair++;
    }
    public void PrevHat()
    {
        if (currentHair == 0)
            currentHair = hair.Count + 1;
        else
            currentHair--;
    }

    public void Finish()
    {
        CharConfig.Hair = Hair.gameObject;
    }
}
