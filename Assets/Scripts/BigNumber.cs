using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BigNumber : MonoBehaviour
{
    public TextMeshProUGUI totalCurrencyTXT;
    public GameObject upgradersAMNT;
    public TextMeshProUGUI currencyPSTXT;
    public double totalCurrency;
    public double currencyPS;
    BigNumberString bn = new BigNumberString();
    void Start()
    {
        totalCurrency=0;
        currencyPS =0;
        totalCurrencyPS();
    }

    void Update()
    {
        totalCurrencyPS();
        totalCurrencyPSTXT();
        sumTotalCurrency();
    }

    //This is to get the total amount of upgraders, with this we create an array with the same lenght to save
    //all the upgraders currencyPS
    private int getUpgraderAmnt()
    {
        int upTotal = 0;
        for (int i = 0; i < upgradersAMNT.transform.childCount; i++)
        {
            upTotal = ++upTotal;   
        }
        return upTotal;
    }
    //Click of the big button, it adds 1 for now
    public void clickBigButton()
    {
        //It'll be changed to some multiplier later
        totalCurrency = ++totalCurrency;
    }
    //Sums the big currency and transforms it to text
    private void sumTotalCurrency()
    {
        totalCurrency = totalCurrency + currencyPS * Time.deltaTime;
        totalCurrencyTXT.text = totalCurrency.ToString("F0");
    }
    //Sums all the different upgrades into one number, now we have all of them for separate and together
    private void totalCurrencyPS()
    {
        currencyPS = 0;
        getUpgraderAmnt();
        double[] amountofUpgraders = new double[getUpgraderAmnt()];
        for (int i = 0; i < upgradersAMNT.transform.childCount; i++)
        {
            amountofUpgraders[i] = upgradersAMNT.transform.GetChild(i).GetComponent<UpgradeNumber>().getCurrencyPSTotal();
            currencyPS = currencyPS + amountofUpgraders[i];
        }
    }
    //Transform numbers per second to text
    private void totalCurrencyPSTXT()
    {
        currencyPSTXT.text = bn.BNtoString(currencyPS) + " per second";
    }
}
