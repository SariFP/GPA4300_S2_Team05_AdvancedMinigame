using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizeCharacter : MonoBehaviour
{
    public new string name;

    public CharacterSkin[] skin;
    public CharacterClothesTypes[] clothesTypes;
    public ClothesObject[] CurrentClothes;

    public void NextClother(int SkinnedTypeIndex)       //Button-Action for next Clothings
    {
        int nextClothesIndex;
        nextClothesIndex = skin[SkinnedTypeIndex].currentIndex + 1;

        if(nextClothesIndex >= clothesTypes[SkinnedTypeIndex].clothes.Length)
        {
            nextClothesIndex = 0;
        }

        AddClothes(clothesTypes[SkinnedTypeIndex].clothes[nextClothesIndex]);
        skin[SkinnedTypeIndex].currentIndex = nextClothesIndex;
    }

    public void PreviousClother(int SkinnedTypeIndex)   //Button-Action for previous Clothing
    {
        int nextClothesIndex;

        nextClothesIndex = skin[SkinnedTypeIndex].currentIndex - 1;

        if (nextClothesIndex < 0)
        {
            nextClothesIndex = clothesTypes[SkinnedTypeIndex].clothes.Length - 1;
        }

        AddClothes(clothesTypes[SkinnedTypeIndex].clothes[nextClothesIndex]);
        skin[SkinnedTypeIndex].currentIndex = nextClothesIndex;
    }

    void Start()
    {
        CurrentClothes = new ClothesObject[clothesTypes.Length];    //Player Clothes
    }

    void AddClothes(GameObject _newClothesGo)
    {
        ClothesObject newClothes = _newClothesGo.GetComponent<ClothesObject>();
        int slotIndex = (int)newClothes.type;

        removeClothing(slotIndex);

        CurrentClothes[slotIndex] = newClothes;

        if (_newClothesGo.GetComponent<ClothesObject>().hide == true)
        {
            int slotToHide = (int)newClothes.hides;
            HideClothes(slotToHide);
        }

        skin[slotIndex].skinnedMeshRenderer.sharedMesh = _newClothesGo.GetComponent<MeshFilter>().sharedMesh;
        skin[slotIndex].skinnedMeshRenderer.materials = _newClothesGo.GetComponent<MeshRenderer>().sharedMaterials;
    }

    void removeClothing(int SlotIndex)
    {
        if (CurrentClothes[SlotIndex] != null && CurrentClothes[SlotIndex].hide)
            skin[(int)CurrentClothes[SlotIndex].hides].skinnedMeshRenderer.enabled = true;

        CurrentClothes[SlotIndex] = null;
    }

    void HideClothes(int _slotToHide)
    {
        skin[_slotToHide].skinnedMeshRenderer.enabled = false;
    }

    public enum Type
    {
        Hair,
        Head,
        Torso,
        Legs,
        Hands,
        Feet,
        Eyes,
        Outer,
        BackPack,
        Mask,
    }
}

[System.Serializable]
public class CharacterSkin
{
    public string name;
    public SkinnedMeshRenderer skinnedMeshRenderer;
    [HideInInspector] public int currentIndex;
}

[System.Serializable]
public class CharacterClothesTypes
{
    public string name;
    public GameObject[] clothes;
}