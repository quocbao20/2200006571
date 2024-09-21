using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startpointgm : MonoBehaviour
{
    private void Awake()
    {
        transform.position = UiManager.v1;
        transform.eulerAngles = UiManager.r1;
    }
}
