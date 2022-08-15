using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Service
public class Collect : MonoBehaviour
{
    [SerializeField]
    private AudioSource coinFX;
    private int coinCount = 0;
    public int CoinCount { get => coinCount; set => coinCount = value; }
  

    private void OnTriggerEnter(Collider other)
    {
       
        string otherName = (string)other.gameObject.tag;
        switch (otherName)
        {
            // Model [ COIN ]
            case "Coin":
                coinCount++;
                coinFX.Play();
                other.gameObject.SetActive(false);
                break;
        }
    }
}
