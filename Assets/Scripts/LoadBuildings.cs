using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UI;

public class LoadBuildings : MonoBehaviour
{
    public SObuilding build;
    public UpgradeNumber amnt;
    public double cost;
    public Image bImage;
    private void Start() {
        bImage.sprite = build.buildingImage;
        cost = build.cost;
    }

}
