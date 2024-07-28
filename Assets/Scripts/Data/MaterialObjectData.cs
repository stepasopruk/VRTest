using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "MaterialObjectData", menuName = "ScriptableObjects/AddMaterialObjectData", order = 1)]
public class MaterialObjectData : ScriptableObject
{
    [SerializeField] private List<Material> standartMaterials;
    [SerializeField] private List<Material> selectedMaterials;
    [SerializeField] private List<Material> hoverMaterials;

    public Material[] StandartMaterials => standartMaterials.ToArray();
    public Material[] SelectedMaterials => selectedMaterials.ToArray();
    public Material[] HoverMaterials => hoverMaterials.ToArray();
}

