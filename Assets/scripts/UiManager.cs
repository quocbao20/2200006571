using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;
    public Text LevelText,secondmessage;
    public bool skinEnter;
    public GameObject ingamepanel;
    public GameObject playerSelectionPanel;
    public GameObject startpanel,gameplaypanel,losepanel,winpanel,confiti;

    public static bool checksky;

    public Material sky1, sky2;

    public static Vector3 v1, r1;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        
        
        
    }
    void Start()
    {
        print(v1);
        Advertisements.Instance.Initialize();
        //Advertisements.Instance.ShowBanner(BannerPosition.BOTTOM);
        LevelText.text = "Level " + (gamemanager.instance.getLevel() + 1);
    }

    

   

    public void btn_retry()
    {
     
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void nextlvl()
    {
        v1 = new Vector3(0, 0, 0);
        r1 = new Vector3(0, 0, 0);
        if (gamemanager.instance.getLevel()+1>=10)
        {
            gamemanager.instance.setLevel(0);
        }
        else
        {
            gamemanager.instance.setLevel(gamemanager.instance.getLevel() + 1);
        }
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void showrestart()
    {
        Advertisements.Instance.ShowInterstitial();
        gameplaypanel.SetActive(true);
    }

    public void continuegm()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void restartgm()
    {
        v1 = new Vector3(0, 0, 0);
        r1 = new Vector3(0, 0, 0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void changecar()
    {
        v1 = new Vector3(0, 0, 0);
        r1 = new Vector3(0, 0, 0);
        SceneManager.LoadScene(0);
    }
}
