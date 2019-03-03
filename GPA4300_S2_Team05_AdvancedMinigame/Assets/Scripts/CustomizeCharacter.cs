using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizeCharacter : MonoBehaviour
{
    public new string name;

    public CharacterSkin[] skin;
    public CharacterClothesTypes[] clothesTypes;
    public Clothes[] CurrentClothes;

    public void NextClother(int SkinnedTypeIndex)
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

    public void PreviousClother(int SkinnedTypeIndex)
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
        CurrentClothes = new Clothes[clothesTypes.Length];
    }

    void AddClothes(GameObject _newClothesGo)
    {
        Clothes newClothes = _newClothesGo.GetComponent<Clothes>();
        int slotIndex = (int)newClothes.type;

        removeClothing(slotIndex);

        CurrentClothes[slotIndex] = newClothes;

        if (_newClothesGo.GetComponent<Clothes>().hide == true)
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

[System.Serializable]
public class Clothes : MonoBehaviour
{
    public CustomizeCharacter.Type type;
    public bool hide;
    public CustomizeCharacter.Type hides;
}