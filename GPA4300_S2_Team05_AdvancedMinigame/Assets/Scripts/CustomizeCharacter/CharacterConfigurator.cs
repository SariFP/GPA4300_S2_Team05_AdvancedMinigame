using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterConfigurator : MonoBehaviour
{
    public ScriptableObjectClothes Clothes;

    [Header("BodyParts")]
    public GameObject Body;
    public GameObject Hair;
    public GameObject Head;
    public GameObject Eyes;
    public GameObject Mask;
    public GameObject Torso;
    public GameObject Outer;
    public GameObject Backpack;
    public GameObject Hands;
    public GameObject Legs;
    public GameObject Feets;

    [Header("Customizables")]
    public BodyParts HairParts;
    public BodyParts HeadParts;
    public BodyParts EyesParts;
    public BodyParts MaskParts;
    public BodyParts TorsoParts;
    public BodyParts OuterParts;
    public BodyParts BackpackParts;
    public BodyParts HandParts;
    public BodyParts LegParts;
    public BodyParts FeetParts;


    private int currentHair;
    private int currentHead;
    private int currentEyes;
    private int currentMask;
    private int currentTorso;
    private int currentOuter;
    private int currentBackpack;
    private int currentHands;
    private int currentLegs;
    private int currentFeets;

    private void Start()
    {
        currentHair = HairParts.Parts.Length - 1;
        currentHead = HeadParts.Parts.Length - 1;
        currentEyes = EyesParts.Parts.Length - 1;
        currentMask = MaskParts.Parts.Length - 1;
        currentTorso = TorsoParts.Parts.Length - 1;
        currentOuter = OuterParts.Parts.Length - 1;
        currentBackpack = BackpackParts.Parts.Length - 1;
        currentHands = HandParts.Parts.Length - 1;
        currentLegs = LegParts.Parts.Length - 1;
        currentFeets = FeetParts.Parts.Length - 1;
    }

    public void Finish()
    {
        Clothes.Hair = new ScriptableObjectClothes.BodyPartAsset(Hair.GetComponent<SkinnedMeshRenderer>().sharedMaterial, Hair.GetComponent<SkinnedMeshRenderer>().sharedMesh);
        Clothes.Head = new ScriptableObjectClothes.BodyPartAsset(Head.GetComponent<SkinnedMeshRenderer>().sharedMaterial, Head.GetComponent<SkinnedMeshRenderer>().sharedMesh);
        Clothes.Eyes = new ScriptableObjectClothes.BodyPartAsset(Eyes.GetComponent<SkinnedMeshRenderer>().sharedMaterial, Eyes.GetComponent<SkinnedMeshRenderer>().sharedMesh);
        Clothes.Mask = new ScriptableObjectClothes.BodyPartAsset(Mask.GetComponent<SkinnedMeshRenderer>().sharedMaterial, Mask.GetComponent<SkinnedMeshRenderer>().sharedMesh);
        Clothes.Torso = new ScriptableObjectClothes.BodyPartAsset(Torso.GetComponent<SkinnedMeshRenderer>().sharedMaterial, Torso.GetComponent<SkinnedMeshRenderer>().sharedMesh);
        Clothes.Outer = new ScriptableObjectClothes.BodyPartAsset(Outer.GetComponent<SkinnedMeshRenderer>().sharedMaterial, Outer.GetComponent<SkinnedMeshRenderer>().sharedMesh);
        Clothes.Backpack = new ScriptableObjectClothes.BodyPartAsset(Backpack.GetComponent<SkinnedMeshRenderer>().sharedMaterial, Backpack.GetComponent<SkinnedMeshRenderer>().sharedMesh);
        Clothes.Hands = new ScriptableObjectClothes.BodyPartAsset(Hands.GetComponent<SkinnedMeshRenderer>().sharedMaterial, Hands.GetComponent<SkinnedMeshRenderer>().sharedMesh);
        Clothes.Legs = new ScriptableObjectClothes.BodyPartAsset(Legs.GetComponent<SkinnedMeshRenderer>().sharedMaterial, Legs.GetComponent<SkinnedMeshRenderer>().sharedMesh);
        Clothes.Feets = new ScriptableObjectClothes.BodyPartAsset(Feets.GetComponent<SkinnedMeshRenderer>().sharedMaterial, Feets.GetComponent<SkinnedMeshRenderer>().sharedMesh);
    }

    public void NextHair()
    {
        if (currentHair == HairParts.Parts.Length - 1)
            currentHair = 0;
        else
            currentHair++;

        Hair.GetComponent<SkinnedMeshRenderer>().sharedMesh = HairParts.Parts[currentHair].GetComponent<MeshFilter>().sharedMesh;
        Hair.GetComponent<SkinnedMeshRenderer>().sharedMaterial = HairParts.Parts[currentHair].GetComponent<MeshRenderer>().sharedMaterial;
    }
    public void PrevHair()
    {
        if (currentHair == 0)
            currentHair = HairParts.Parts.Length + 1;
        else
            currentHair--;

        Hair.GetComponent<SkinnedMeshRenderer>().sharedMesh = HairParts.Parts[currentHair].GetComponent<MeshFilter>().sharedMesh;
        Hair.GetComponent<SkinnedMeshRenderer>().sharedMaterial = HairParts.Parts[currentHair].GetComponent<MeshRenderer>().sharedMaterial;
    }

    public void NextHead()
    {
        if (currentHead == HeadParts.Parts.Length - 1)
            currentHead = 0;
        else
            currentHead++;

        Head.GetComponent<SkinnedMeshRenderer>().sharedMesh = HeadParts.Parts[currentHead].GetComponent<MeshFilter>().sharedMesh;
        Head.GetComponent<SkinnedMeshRenderer>().sharedMaterial = HeadParts.Parts[currentHead].GetComponent<MeshRenderer>().sharedMaterial;
    }
    public void PrevHead()
    {
        if (currentHead == 0)
            currentHead = HeadParts.Parts.Length + 1;
        else
            currentHead--;

        Head.GetComponent<SkinnedMeshRenderer>().sharedMesh = HeadParts.Parts[currentHead].GetComponent<MeshFilter>().sharedMesh;
        Head.GetComponent<SkinnedMeshRenderer>().sharedMaterial = HeadParts.Parts[currentHead].GetComponent<MeshRenderer>().sharedMaterial;
    }

    public void NextEyes()
    {
        if (currentEyes == EyesParts.Parts.Length - 1)
            currentEyes = 0;
        else
            currentEyes++;

        Eyes.GetComponent<SkinnedMeshRenderer>().sharedMesh = EyesParts.Parts[currentEyes].GetComponent<MeshFilter>().sharedMesh;
        Eyes.GetComponent<SkinnedMeshRenderer>().sharedMaterial = EyesParts.Parts[currentEyes].GetComponent<MeshRenderer>().sharedMaterial;
    }
    public void PrevEyes()
    {
        if (currentEyes == 0)
            currentEyes = EyesParts.Parts.Length + 1;
        else
            currentEyes--;

        Eyes.GetComponent<SkinnedMeshRenderer>().sharedMesh = EyesParts.Parts[currentEyes].GetComponent<MeshFilter>().sharedMesh;
        Eyes.GetComponent<SkinnedMeshRenderer>().sharedMaterial = EyesParts.Parts[currentEyes].GetComponent<MeshRenderer>().sharedMaterial;
    }

    public void NextMask()
    {
        if (currentMask == MaskParts.Parts.Length - 1)
            currentMask = 0;
        else
            currentMask++;

        Mask.GetComponent<SkinnedMeshRenderer>().sharedMesh = MaskParts.Parts[currentMask].GetComponent<MeshFilter>().sharedMesh;
        Mask.GetComponent<SkinnedMeshRenderer>().sharedMaterial = MaskParts.Parts[currentMask].GetComponent<MeshRenderer>().sharedMaterial;
    }
    public void PrevMask()
    {
        if (currentMask == 0)
            currentMask = MaskParts.Parts.Length + 1;
        else
            currentMask--;

        Mask.GetComponent<SkinnedMeshRenderer>().sharedMesh = MaskParts.Parts[currentMask].GetComponent<MeshFilter>().sharedMesh;
        Mask.GetComponent<SkinnedMeshRenderer>().sharedMaterial = MaskParts.Parts[currentMask].GetComponent<MeshRenderer>().sharedMaterial;
    }

    public void NextTorso()
    {
        if (currentTorso == TorsoParts.Parts.Length - 1)
            currentTorso = 0;
        else
            currentTorso++;

        Torso.GetComponent<SkinnedMeshRenderer>().sharedMesh = TorsoParts.Parts[currentTorso].GetComponent<MeshFilter>().sharedMesh;
        Torso.GetComponent<SkinnedMeshRenderer>().sharedMaterial = TorsoParts.Parts[currentTorso].GetComponent<MeshRenderer>().sharedMaterial;
    }
    public void PrevTorso()
    {
        if (currentTorso == 0)
            currentTorso = TorsoParts.Parts.Length + 1;
        else
            currentTorso--;

        Torso.GetComponent<SkinnedMeshRenderer>().sharedMesh = TorsoParts.Parts[currentTorso].GetComponent<MeshFilter>().sharedMesh;
        Torso.GetComponent<SkinnedMeshRenderer>().sharedMaterial = TorsoParts.Parts[currentTorso].GetComponent<MeshRenderer>().sharedMaterial;
    }

    public void NextOuter()
    {
        if (currentOuter == OuterParts.Parts.Length - 1)
            currentOuter = 0;
        else
            currentOuter++;

        Outer.GetComponent<SkinnedMeshRenderer>().sharedMesh = OuterParts.Parts[currentOuter].GetComponent<MeshFilter>().sharedMesh;
        Outer.GetComponent<SkinnedMeshRenderer>().sharedMaterial = OuterParts.Parts[currentOuter].GetComponent<MeshRenderer>().sharedMaterial;
    }
    public void PrevOuter()
    {
        if (currentOuter == 0)
            currentOuter = OuterParts.Parts.Length + 1;
        else
            currentOuter--;

        Outer.GetComponent<SkinnedMeshRenderer>().sharedMesh = OuterParts.Parts[currentOuter].GetComponent<MeshFilter>().sharedMesh;
        Outer.GetComponent<SkinnedMeshRenderer>().sharedMaterial = OuterParts.Parts[currentOuter].GetComponent<MeshRenderer>().sharedMaterial;
    }

    public void NextBackpack()
    {
        if (currentBackpack == BackpackParts.Parts.Length - 1)
            currentBackpack = 0;
        else
            currentBackpack++;

        Backpack.GetComponent<SkinnedMeshRenderer>().sharedMesh = BackpackParts.Parts[currentBackpack].GetComponent<MeshFilter>().sharedMesh;
        Backpack.GetComponent<SkinnedMeshRenderer>().sharedMaterial = BackpackParts.Parts[currentBackpack].GetComponent<MeshRenderer>().sharedMaterial;
    }
    public void PrevBackpack()
    {
        if (currentBackpack == 0)
            currentBackpack = BackpackParts.Parts.Length + 1;
        else
            currentBackpack--;

        Backpack.GetComponent<SkinnedMeshRenderer>().sharedMesh = BackpackParts.Parts[currentBackpack].GetComponent<MeshFilter>().sharedMesh;
        Backpack.GetComponent<SkinnedMeshRenderer>().sharedMaterial = BackpackParts.Parts[currentBackpack].GetComponent<MeshRenderer>().sharedMaterial;
    }

    public void NextHands()
    {
        if (currentHands == HandParts.Parts.Length - 1)
            currentHands = 0;
        else
            currentHands++;

        Hands.GetComponent<SkinnedMeshRenderer>().sharedMesh = HandParts.Parts[currentHands].GetComponent<MeshFilter>().sharedMesh;
        Hands.GetComponent<SkinnedMeshRenderer>().sharedMaterial = HandParts.Parts[currentHands].GetComponent<MeshRenderer>().sharedMaterial;
    }
    public void PrevHands()
    {
        if (currentHands == 0)
            currentHands = HandParts.Parts.Length + 1;
        else
            currentHands--;

        Hands.GetComponent<SkinnedMeshRenderer>().sharedMesh = HandParts.Parts[currentHands].GetComponent<MeshFilter>().sharedMesh;
        Hands.GetComponent<SkinnedMeshRenderer>().sharedMaterial = HandParts.Parts[currentHands].GetComponent<MeshRenderer>().sharedMaterial;
    }

    public void NextLegs()
    {
        if (currentLegs == LegParts.Parts.Length - 1)
            currentLegs = 0;
        else
            currentLegs++;

        Legs.GetComponent<SkinnedMeshRenderer>().sharedMesh = LegParts.Parts[currentLegs].GetComponent<MeshFilter>().sharedMesh;
        Legs.GetComponent<SkinnedMeshRenderer>().sharedMaterial = LegParts.Parts[currentLegs].GetComponent<MeshRenderer>().sharedMaterial;
    }
    public void PrevLegs()
    {
        if (currentLegs == 0)
            currentLegs = LegParts.Parts.Length + 1;
        else
            currentLegs--;

        Legs.GetComponent<SkinnedMeshRenderer>().sharedMesh = LegParts.Parts[currentLegs].GetComponent<MeshFilter>().sharedMesh;
        Legs.GetComponent<SkinnedMeshRenderer>().sharedMaterial = LegParts.Parts[currentLegs].GetComponent<MeshRenderer>().sharedMaterial;
    }

    public void NextFeets()
    {
        if (currentFeets == FeetParts.Parts.Length - 1)
            currentFeets = 0;
        else
            currentFeets++;

        Feets.GetComponent<SkinnedMeshRenderer>().sharedMesh = FeetParts.Parts[currentFeets].GetComponent<MeshFilter>().sharedMesh;
        Feets.GetComponent<SkinnedMeshRenderer>().sharedMaterial = FeetParts.Parts[currentFeets].GetComponent<MeshRenderer>().sharedMaterial;
    }
    public void PrevFeets()
    {
        if (currentFeets == 0)
            currentFeets = FeetParts.Parts.Length + 1;
        else
            currentFeets--;

        Feets.GetComponent<SkinnedMeshRenderer>().sharedMesh = FeetParts.Parts[currentFeets].GetComponent<MeshFilter>().sharedMesh;
        Feets.GetComponent<SkinnedMeshRenderer>().sharedMaterial = FeetParts.Parts[currentFeets].GetComponent<MeshRenderer>().sharedMaterial;
    }
}
