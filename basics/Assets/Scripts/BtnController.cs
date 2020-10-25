using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnController : MonoBehaviour
{
    public GameObject stopcv;
    public GameObject Topbar;
   // public GameObject exppcv;
    private bool pause=false;
    public AudioSource btnclickSound;
    private float fixedDeltatime;
    // private bool b_exppcv = false;

    private void Awake()
    {
        {
            this.fixedDeltatime = Time.fixedDeltaTime;
        }
    }

    void Update()
    {
        if (pause)
        {
            Debug.Log("pausd");
            Time.timeScale = 0;
            Topbar.SetActive(false);
            stopcv.SetActive(true);
           
        }

    }
    public void startBtn() //startscene->gamescene
    {
        SceneManager.LoadScene("GameScene");
    }
    public void restartBtn() //=okbtn 각 특정점수제거하면서 새로시작
    {
        btnclickSound.Play();

        SceneManager.LoadScene("GameScene");
    }
    public void quit_restartBtn() // 아예 처음부터
    {
        btnclickSound.Play();

        SceneManager.LoadScene("StartScene");
    }
 

    public void OkBtn() //지도화면 , application.quit()을 하면 유니티프로그램이 아예 꺼지는데 팝업창이 어떤 건지 확인후 고치겠습니다.
    {
        btnclickSound.Play();
        Application.Quit();


    }
    public void StopBtn()
    {
       
        btnclickSound.Play();
        pause = true;

      
        if (Time.timeScale == 0)
        {
            stopcv.SetActive(false);
            Topbar.SetActive(true);
            Time.timeScale = 1f;
            pause = false;
            
        }
        Time.fixedDeltaTime = this.fixedDeltatime * Time.timeScale;
    }

 


}
