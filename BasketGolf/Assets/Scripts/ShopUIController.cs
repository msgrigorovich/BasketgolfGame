using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUIController : MonoBehaviour
{
    public GameObject shopCanvas;
    public GameObject mainCanvas;

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
}
