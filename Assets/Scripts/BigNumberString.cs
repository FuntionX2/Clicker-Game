using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigNumberString 
{
    //Transform any number beyond 1mil to strings
    public string BNtoString(double bigNumber)
    {
        if(bigNumber<1 && bigNumber>0)
        {
            return bigNumber.ToString("F1");
        }
        else if(bigNumber/Mathf.Pow(10,6)>=10 && bigNumber/Mathf.Pow(10,9)<1)
        {
            return (bigNumber/Mathf.Pow(10,6)).ToString("F0") + " Millions";
        }
        else if(bigNumber/Mathf.Pow(10,9)>=1 && bigNumber/Mathf.Pow(10,12)<1)
        {
            if(((bigNumber/Mathf.Pow(10,9)).ToString("F0"))=="1")
            {
                return  (bigNumber/Mathf.Pow(10,9)).ToString("F0") + " Billion";
            }
            else
            {
                return (bigNumber/Mathf.Pow(10,9)).ToString("F0") + " Billions";
            }
        }
        else if(bigNumber/Mathf.Pow(10,12)>=1 && bigNumber/Mathf.Pow(10,15)<1)
        {
            if(((bigNumber/Mathf.Pow(10,12)).ToString("F0"))=="1")
            {
                return (bigNumber/Mathf.Pow(10,12)).ToString("F0") + " Trillion";
            }
            else
            {
                return (bigNumber/Mathf.Pow(10,12)).ToString("F0") + " Trillions";
            }
        }
        else if(bigNumber/Mathf.Pow(10,15)>=1 && bigNumber/Mathf.Pow(10,18)<1)
        {
            if(((bigNumber/Mathf.Pow(10,15)).ToString("F0"))=="1")
            {
                return (bigNumber/Mathf.Pow(10,15)).ToString("F0") + " Quadrillion";
            }
            else
            {
                return (bigNumber/Mathf.Pow(10,15)).ToString("F0") + " Quadrillions";
            }
        }
        else if(bigNumber/Mathf.Pow(10,18)>=1 && bigNumber/Mathf.Pow(10,21)<1)
        {
            if(((bigNumber/Mathf.Pow(10,18)).ToString("F0"))=="1")
            {
                return (bigNumber/Mathf.Pow(10,18)).ToString("F0") + " Quintillion";
            }
            else
            {
                return (bigNumber/Mathf.Pow(10,18)).ToString("F0") + " Quintillions";
            }
        }
        else if(bigNumber/Mathf.Pow(10,21)>=1 && bigNumber/Mathf.Pow(10,24)<1)
        {
            if(((bigNumber/Mathf.Pow(10,21)).ToString("F0"))=="1")
            {
                return (bigNumber/Mathf.Pow(10,21)).ToString("F0") + " Sextillion";
            }
            else
            {
                return (bigNumber/Mathf.Pow(10,21)).ToString("F0") + " Sextillions";
            }
        }
        else if(bigNumber/Mathf.Pow(10,24)>=1 && bigNumber/Mathf.Pow(10,27)<1)
        {
            if(((bigNumber/Mathf.Pow(10,24)).ToString("F0"))=="1")
            {
                return (bigNumber/Mathf.Pow(10,24)).ToString("F0") + " Septillion";
            }
            else
            {
                return (bigNumber/Mathf.Pow(10,24)).ToString("F0") + " Septillions";
            }
        }
        else if(bigNumber/Mathf.Pow(10,27)>=1 && bigNumber/Mathf.Pow(10,30)<1)
        {
            if(((bigNumber/Mathf.Pow(10,27)).ToString("F0"))=="1")
            {
                return (bigNumber/Mathf.Pow(10,27)).ToString("F0") + " Octillion";
            }
            else
            {
                return (bigNumber/Mathf.Pow(10,27)).ToString("F0") + " Octillions";
            }
        }
        else
        {
            return bigNumber.ToString("F0");
        }
    }
}
