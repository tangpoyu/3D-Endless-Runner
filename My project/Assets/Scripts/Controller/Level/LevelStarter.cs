using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Controller 
public class LevelStarter : MonoBehaviour
{
    [SerializeField]
    private GameObject[] countDown; // Service
    private int currentCountDown = 0; 
    [SerializeField]
    private AudioSource readFX, goFX; // Service
    [SerializeField]
    private PlayerMove playMove; // Service 
    [SerializeField]
    private Collect playerCollect; // Service
    [SerializeField]
    private AnimatorControll animatorController;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountDown(1.5f));
    }

    private void Update()
    {
        isPlayerCollCollided();
    }

    private void isPlayerCollCollided()
    {
        if (playerCollect.IsCollided)
        {
            playMove.enabled = false;
            playerCollect.enabled = false;
            animatorController.SetTrigger(PlayerAnimation.KNOCKDOWN_TRIGGER); 
        }
    }

    IEnumerator CountDown(float second)
    {
        yield return new WaitForSeconds(second);
        countDown[currentCountDown++].SetActive(true);
        if (currentCountDown < countDown.Length)
        {
            StartCoroutine(CountDown(1));
            readFX.Play();
            yield break;
        }
        goFX.Play();
        playMove.CanMove = true;
    }
}
