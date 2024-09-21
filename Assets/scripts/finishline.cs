using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishline : MonoBehaviour
{
    public bool onetm;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="car" && !onetm)
        {
            onetm = true;
            StartCoroutine(wingm());
        }
    }

    IEnumerator wingm()
    {
        UiManager.instance.confiti.transform.parent = transform.parent;
        UiManager.instance.confiti.transform.localPosition = new Vector3(0, 0, 0);
        UiManager.instance.confiti.SetActive(true);
        
        SoundManager.instance.Play("clap");
        SoundManager.instance.Play("win");
        yield return new WaitForSeconds(4f);
        Advertisements.Instance.ShowInterstitial();
        yield return new WaitForSeconds(1f);
        UiManager.instance.winpanel.SetActive(true);
    }
}
