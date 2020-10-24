using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnController : MonoBehaviour
{
    public GameObject stopcv;
    public GameObject Topbar;
   // public GameObject exppcv;
    private bool b_stopcv=false;
    public AudioSource btnclickSound;
    // private bool b_exppcv = false;
    void Update()
    {
      
            if (b_stopcv == true)
            {
                
                
                Time.timeScale = 0;
            Topbar.SetActive(false);
            stopcv.SetActive(true);
        }
    }
    public void startBtn()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void restartBtn() //=okbtn
    {
        btnclickSound.Play();

        SceneManager.LoadScene("GameScene");
    }
    public void quit_restartBtn() //=okbtn
    {
        btnclickSound.Play();

        SceneManager.LoadScene("StartScene");
    }
 

    public void OkBtn() //지도화면 ,= quitbtn
    {
        btnclickSound.Play();
        Application.Quit();


    }
    public void StopBtn()
    {
        btnclickSound.Play();
        b_stopcv = true;
       

        if (Time.timeScale == 0)
        {
            stopcv.SetActive(false);
            Topbar.SetActive(true);
            Time.timeScale = 1;
            b_stopcv = false;
        }
    }

 


}
