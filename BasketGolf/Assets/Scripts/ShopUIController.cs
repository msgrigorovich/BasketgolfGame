using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopUIController : MonoBehaviour
{
    public float timeRemaining = 3600;
    public bool timerIsRunning = false;
    public Text timeText;

    public GameObject rewardActive;
    public GameObject rewardDisable;

    public GameObject shopCanvas;
    public GameObject mainCanvas;
    public GameObject buttonHolder;
    public GameObject bonusCanvas;

    private int rewardTime;
    private bool reward=true;


    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                RewardIsReady();
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

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

    //---------------------------------------------------reward
    public void RewardTake()
    {
        rewardActive.SetActive(false);
        rewardDisable.SetActive(true);
        bonusCanvas.SetActive(false);
        reward = false;
        timeRemaining = 10;
        timerIsRunning = true;
    }

    public void TakeRewardButton()
    {
        if (reward)
        {
            bonusCanvas.SetActive(true);
        }
        else return;
    }
    public void RewardIsReady() {
        rewardDisable.SetActive(false);
        rewardActive.SetActive(true);
        reward = true;
    }
}
