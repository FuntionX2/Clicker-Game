using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoadUpgrades : MonoBehaviour
{
    public int id;
    public TextMeshProUGUI upgraderName;
    public TextMeshProUGUI upgraderInumber;
    public Image upgraderImage;
    public double upgraderICurrency;
    public SOupgrader upgraderInfo;
    void Start()
    {
        id = upgraderInfo.id;
        upgraderName.text = upgraderInfo.upgraderName;
        upgraderInumber.text = upgraderInfo.upgraderInitialCost.ToString();
        upgraderImage.sprite = upgraderInfo.upgraderImage;
        upgraderICurrency = upgraderInfo.upgraderICurrency;
    }

}
