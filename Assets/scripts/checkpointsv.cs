using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointsv : MonoBehaviour
{
    public Vector3 v;
    void Start()
    {
        v = transform.rotation.eulerAngles;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="car")
        {
            SoundManager.instance.Play("hit");
            UiManager.v1 = transform.position;
            UiManager.v1.y = transform.position.y + 2;
            UiManager.r1 = transform.rotation.eulerAngles;
            Destroy(gameObject);
        }
    }
}
