using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUIController : MonoBehaviour
{
    public GameObject shopCanvas;
    public GameObject mainCanvas;
    public GameObject buttonHolder;

    public void ButtonClose() {
        if (shopCanvas.activeInHierarchy)
        {
            shopCanvas.SetActive(false);
            mainCanvas.SetActive(true);
        }
        else {
            shopCanvas.SetActive(true);
            mainCanvas.SetActive(false);
        }
    }

    public void SettingsOpener() {
        if (buttonHolder.activeInHierarchy)
        {
            buttonHolder.SetActive(false);
        }
        else {
            buttonHolder.SetActive(true);
        }
    }
}
