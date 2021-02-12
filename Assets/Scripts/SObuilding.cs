using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BuildingUpgrader", menuName = "BuildingUpgrader/Building")]
public class SObuilding : ScriptableObject
{
    public int id;
    public Sprite buildingImage;
    public string buildingName;
    public string buildingDesc;
    public double cost;
}
