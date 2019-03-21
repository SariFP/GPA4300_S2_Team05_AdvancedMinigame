using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharConfig", menuName = "Character Configuration/New Config", order = 1)]
public class ScriptableObjectClothes : ScriptableObject
{
    public BodyPartAsset Hair;
    public BodyPartAsset Head;
    public BodyPartAsset Eyes;
    public BodyPartAsset Mask;
    public BodyPartAsset Torso;
    public BodyPartAsset Outer;
    public BodyPartAsset Backpack;
    public BodyPartAsset Hands;
    public BodyPartAsset Legs;
    public BodyPartAsset Feets;

    [System.Serializable]
    public struct BodyPartAsset
    {
        public Material material;
        public Mesh mesh;

        public BodyPartAsset(Material mat, Mesh mesh)
        {
            material = mat;
            this.mesh = mesh;
        }
    }
}
