using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// Controller
public class UIHandler : MonoBehaviour
{
    [SerializeField]
    private Collect playerCollect; // Service
    [SerializeField]
    private PlayerMove playerMove; // Service
    [SerializeField]
    private GameObject coinCountDisplay, distanceDisplay; // View



    private void Update()
    {
        coinCountDisplay.GetComponent<Text>().text = playerCollect.CoinCount.ToString();
        distanceDisplay.GetComponent<Text>().text = Math.Round(playerMove.MoveDistance).ToString();
    }
}
