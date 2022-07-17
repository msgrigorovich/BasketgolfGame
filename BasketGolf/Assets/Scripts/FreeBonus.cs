using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeBonus : MonoBehaviour
{
    Time time;
    public GameObject rewardButton;
    public GameObject RewardButtonDisable;

    public void BonusIsReady() {
        rewardButton.SetActive(true);
        rewardButton.SetActive(false);
    }
}
