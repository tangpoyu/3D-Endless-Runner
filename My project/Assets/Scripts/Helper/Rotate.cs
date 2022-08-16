using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    private GameObject coins;

    private void Awake()
    {
        Vector3 myScale = transform.localScale;
        coins.transform.localScale = new Vector3(1/myScale.x, 1/myScale.y, 1/myScale.z);
    }
}
