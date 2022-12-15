using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DebugMenuUI : MonoBehaviour
{
    [SerializeField] GameObject Camera1;
    [SerializeField] GameObject Camera2;
    [SerializeField] GameObject DebugMenu;
    void Start()
    {
        
    }


    public void LoadLevel1()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene(2);
    }
    public void ChangeCameraView1()
    {
        Camera1.SetActive(true);
        Camera2.SetActive(false);
    }
    public void ChangeCameraView2()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(true);
    }
    public void AddMoney()
    {
        Money.totalDollars += 1000;
    }
    public void SoundOff()
    {
        Camera1.GetComponent<AudioListener>().enabled= false;
        Camera2.GetComponent<AudioListener>().enabled= false;
    }
    public void SoundOn()
    {
        Camera1.GetComponent<AudioListener>().enabled = true;
        Camera2.GetComponent<AudioListener>().enabled = true;
    }
    public void CloseDebugMenu()
    {
        DebugMenu.SetActive(false);
    }
}
