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
    private GameObject coinCountDisplay; // View

    private void Update()
    {
        coinCountDisplay.GetComponent<Text>().text = playerCollect.CoinCount.ToString();
    }
}
