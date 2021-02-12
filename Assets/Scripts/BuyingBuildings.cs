using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyingBuildings : MonoBehaviour
{
    public GameObject stat;
    public UpgradeNumber amountOfUpgrader;
    public UpgradeNumber buildingCostC;
    public BigNumber totalNumber;
    public void BuyingBuilding()
    {
        if(totalNumber.totalCurrency>=buildingCostC.cost)
        {
            createStat();
            totalNumber.totalCurrency = totalNumber.totalCurrency - buildingCostC.cost;
            buildingCostC.upgradeCost();
        }
    }
    private void createStat()
    {
        if(amountOfUpgrader.amountOfUpgrader ==0)
        {
            stat.SetActive(true);
        }
        
    }
}