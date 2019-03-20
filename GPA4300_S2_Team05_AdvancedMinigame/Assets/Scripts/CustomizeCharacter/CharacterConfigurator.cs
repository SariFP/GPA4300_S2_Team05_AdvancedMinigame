using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterConfigurator : MonoBehaviour
{
    public ScriptableObjectClothes Clothes;

    [Header("BodyParts")]
    public GameObject Body;
    public GameObject Hair;

    [Header("Customizables")]
    public BodyParts HairParts;


    private int currentHair;

    private void Start()
    {
        currentHair = HairParts.Parts.Length - 1;
    }

    public void NextHair()
    {
        if (currentHair == HairParts.Parts.Length - 1)
            currentHair = 0;
        else
            currentHair++;

        //while (Hair.transform.childCount > 0)
        //{
        //    Destroy(Hair.transform.GetChild(Hair.transform.childCount - 1));
        //}
        //Instantiate(hairObjects[currentHair], Vector3.zero, Quaternion.identity, Hair.transform);

        Hair.GetComponent<SkinnedMeshRenderer>().sharedMesh = HairParts.Parts[currentHair].GetComponent<MeshFilter>().sharedMesh;
        Hair.GetComponent<SkinnedMeshRenderer>().sharedMaterial = HairParts.Parts[currentHair].GetComponent<MeshRenderer>().sharedMaterial;
    }
    public void PrevHair()
    {
        if (currentHair == 0)
            currentHair = HairParts.Parts.Length + 1;
        else
            currentHair--;

        //while (Hair.transform.childCount > 0)
        //{
        //    Destroy(Hair.transform.GetChild(Hair.transform.childCount - 1));
        //}
        //Instantiate(hairObjects[currentHair], Vector3.zero, Quaternion.identity, Hair.transform);

        Hair.GetComponent<SkinnedMeshRenderer>().sharedMesh = HairParts.Parts[currentHair].GetComponent<MeshFilter>().sharedMesh;
        Hair.GetComponent<SkinnedMeshRenderer>().sharedMaterial = HairParts.Parts[currentHair].GetComponent<MeshRenderer>().sharedMaterial;
    }

    public void Finish()
    {
        Clothes.Hair = new ScriptableObjectClothes.BodyPartAsset(Hair.GetComponent<SkinnedMeshRenderer>().sharedMaterial, Hair.GetComponent<SkinnedMeshRenderer>().sharedMesh);
    }
}
