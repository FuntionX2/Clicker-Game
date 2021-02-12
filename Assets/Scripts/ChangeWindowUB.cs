using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWindowUB : MonoBehaviour
{
    public GameObject uWindow;
    public GameObject bWindow;
    void Start()
    {
        uWindow.SetActive(true);
        bWindow.SetActive(false);
    }

    public void uW()
    {
        if(uWindow.activeSelf != true)
        {
            bWindow.SetActive(false);
            uWindow.SetActive(true);
        }
    }
    public void bW()
    {
        if(bWindow.activeSelf != true)
        {
            uWindow.SetActive(false);
            bWindow.SetActive(true);
        }
    }
}
