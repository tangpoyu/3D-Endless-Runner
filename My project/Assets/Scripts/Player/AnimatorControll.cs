using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Service
public class AnimatorControll : MonoBehaviour
{
    [SerializeField]
    private Animator animator; // Model

    public void SetTrigger(string trigger)
    {
        animator.SetTrigger(trigger);
    }

    public void SetBool(string boolName, bool isOrNot)
    {
        animator.SetBool(boolName, isOrNot);
    }
}
