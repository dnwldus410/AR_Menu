using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnController : MonoBehaviour
{
    public GameObject stopcv;
   // public GameObject exppcv;
    private bool b_stopcv=false;
    public AudioSource btnclickSound;
    public AudioSource btnbackSound;
    public AudioSource btnsetSound;
    // private bool b_exppcv = false;
    public void startBtn()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void restartBtn() //=okbtn
    {
        btnclickSound.Play();

        PlayerPrefs.DeleteAll();  //기록들 다 사라지고 새로시작
        SceneManager.LoadScene("GameScene");
    }
    public void quit_restartBtn() //=okbtn
    {
        btnclickSound.Play();

        PlayerPrefs.DeleteAll();  //기록들 다 사라지고 새로시작
        SceneManager.LoadScene("StartScene");
    }
    public void AgainBtn()
    {
        btnclickSound.Play();

        if (b_stopcv)
        {
            stopcv.SetActive(false);
            if (Time.timeScale == 0.0f)
            {
                Time.timeScale = 1.0f;
            }
            b_stopcv = false;
        }
    }
    public void OkBtn() //지도화면 ,= quitbtn
    {
        btnclickSound.Play();
        Application.CancelQuit();


    }

  
    public void StopBtn()
    {
        
        if (b_stopcv == false)
        {
            btnclickSound.Play();
            stopcv.SetActive(true);
            Time.timeScale = 0.0f;
            b_stopcv = true;
        }
        else if (b_stopcv)
        {
            btnbackSound.Play();
            stopcv.SetActive(false);
            if (Time.timeScale == 0.0f)
            {
                Time.timeScale = 1.0f;
            }
            b_stopcv = false;
        }
    }
    
}
