using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class LoadStats : MonoBehaviour
{
    public SOupgrader upgrade;
    public UpgradeNumber upgradeUpdate;
    public int id;
    public TextMeshProUGUI nameUpgrader;
    public TextMeshProUGUI cantUpgraderTotal;
    public TextMeshProUGUI cantUpgraderPS;
    public Image imageUpgrader;
    BigNumberString bn = new BigNumberString();
    //load everything it needs
    void Start()
    {
        id = upgrade.id;
        nameUpgrader.text = upgrade.upgraderName;
        cantUpgraderTotal.text = 1.ToString();
        cantUpgraderPS.text = upgrade.upgraderICurrency.ToString();
        imageUpgrader.sprite = upgrade.upgraderImage;
    }
    //update the numbers transformed to strings
    void Update()
    {
        cantUpgraderPS.text = bn.BNtoString(upgradeUpdate.getCurrencyPSTotal()) + " Per second";
        cantUpgraderTotal.text = "Total: " + bn.BNtoString(upgradeUpdate.amountOfUpgrader);
    }
}
