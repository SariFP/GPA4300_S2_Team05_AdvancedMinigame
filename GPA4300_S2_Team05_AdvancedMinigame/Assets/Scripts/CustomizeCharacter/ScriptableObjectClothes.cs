using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharConfig", menuName = "Character Configuration/New Config", order = 1)]
public class ScriptableObjectClothes : ScriptableObject
{
    public BodyPartAsset Hair;

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
