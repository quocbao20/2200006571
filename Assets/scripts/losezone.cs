using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class losezone : MonoBehaviour
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
        if (other.gameObject.tag == "car" && !onetm)
        {
            onetm = true;
            StartCoroutine(losegm());
        }
    }

    IEnumerator losegm()
    {
        FindObjectOfType<RCC_CarControllerV3>().gameObject.GetComponent<RCC_CarControllerV3>().SetEngine(false);
        SoundManager.instance.Play("fail");
        Advertisements.Instance.ShowInterstitial();
        yield return new WaitForSeconds(1f);
        UiManager.instance.losepanel.SetActive(true);
    }
}
