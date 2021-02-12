using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyingBuilding : MonoBehaviour
{
    public GameObject b;
    public BigNumber bigNumber;
    public LoadBuildings buildings;

    public void bnBuying()
    {
        if(bigNumber.totalCurrency>= buildings.cost)
        {
            buildings.amnt.buildingAmnt();
            b.SetActive(false);
            bigNumber.totalCurrency = bigNumber.totalCurrency - buildings.cost;
        }
    }
}
