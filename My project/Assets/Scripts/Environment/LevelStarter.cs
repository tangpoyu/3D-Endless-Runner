using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    [SerializeField]
    private GameObject[] countDown;
    private int currentCountDown = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountDown(1.5f));
    }
    
    IEnumerator CountDown(float second)
    {
        yield return new WaitForSeconds(second);
        countDown[currentCountDown++].SetActive(true);
        if(currentCountDown < countDown.Length)  StartCoroutine(CountDown(1));
    }
}
