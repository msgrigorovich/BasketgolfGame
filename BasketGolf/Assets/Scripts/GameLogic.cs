using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    private int zone;
    private int stage;
    public Text gameStageAndZone;

    private int coins;
    public Text coinsText;
    // Start is called before the first frame update
    void Start()
    {
        //save info about game stage and zone in profile
        zone = 1;
        stage = 1;
        gameStageAndZone.text = zone + "-" + stage;
        //save info about coins in profile
        coins = 0;
        coinsText.text = coins + "";
    }
}
