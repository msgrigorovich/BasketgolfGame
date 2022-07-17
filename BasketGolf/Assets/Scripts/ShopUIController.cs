using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUIController : MonoBehaviour
{

    public GameObject rewardActive;
    public GameObject rewardDisable;

    public GameObject shopCanvas;
    public GameObject mainCanvas;
    public GameObject buttonHolder;
    public GameObject bonusCanvas;

    private int RewardTime;
    private bool Reward=true;


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

    public void RewardTake()
    {
        rewardActive.SetActive(false);
        rewardDisable.SetActive(true);
        bonusCanvas.SetActive(false);
        Reward = false;
        RewardTime = 3600;
    }

    public void TakeRewardButton()
    {
        if (Reward)
        {
            bonusCanvas.SetActive(true);
        }
        else return;
    }
}
