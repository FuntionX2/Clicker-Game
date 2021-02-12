using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[CreateAssetMenu(fileName = "Upgrader", menuName = "Upgrader/Upgrade")]
public class SOupgrader : ScriptableObject
{
    public int id;
    public Sprite upgraderImage;
    public string upgraderName;
    public int upgraderInitialCost;
    public double upgraderICurrency;
}

