using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUIController : MonoBehaviour
{
    public GameObject shopCanvas;
    void ButtonClose() {
        shopCanvas.SetActive(false);
    }
}
