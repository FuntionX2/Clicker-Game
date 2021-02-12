using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UpgradeNumber : MonoBehaviour
{
    int amountOfBuildings = 0;
    public GameObject upgrade;
    public double cost;
    public double amountOfUpgrader;
    void Start() {
        amountOfUpgrader = 0;
        cost = upgrade.GetComponent<LoadUpgrades>().upgraderInfo.upgraderInitialCost;
    }
    public void upgradeCost()
    {
        amountOfUpgrader = ++amountOfUpgrader;
        cost = upgrade.GetComponent<LoadUpgrades>().upgraderInfo.upgraderInitialCost *  Math.Pow(1.07,amountOfUpgrader);
        upgrade.GetComponent<LoadUpgrades>().upgraderInumber.text = cost.ToString("F0");
    }
    public double getCurrencyPSTotal()
    {
        return amountOfUpgrader * upgrade.GetComponent<LoadUpgrades>().upgraderICurrency * Math.Pow(2,amountOfBuildings);
    }
    public void buildingAmnt()
    {
        amountOfBuildings = ++amountOfBuildings;
    }
}
