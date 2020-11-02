using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnController : MonoBehaviour
{
    public GameObject stopcv;
    public GameObject Topbar;
    public GameObject g_slider;
    // public GameObject exppcv;
    private bool pause=false;
    public AudioSource btnclickSound;
    private float fixedDeltatime;

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
            Time.timeScale = 0;
            g_slider.SetActive(false);
            Topbar.SetActive(false);
            stopcv.SetActive(true);
           
        }

    }
    public void startBtn() //startscene->gamescene
    {
       //팝업 버튼에 따라 시작 할 게임을 달리해야..? 우선 무조건 g_Scene으로 가게 할게요.
        SceneManager.LoadScene("g_Scene");
    }
    public void restartBtn() //=okbtn 각 특정점수제거하면서 새로시작
    {
        btnclickSound.Play();
        if (Time.timeScale == 0)
        {
            stopcv.SetActive(false);
            Topbar.SetActive(true);
            Time.timeScale = 1f;
            pause = false;

        }
        Time.fixedDeltaTime = this.fixedDeltatime * Time.timeScale;
        if (SceneManager.GetActiveScene().name == "g_Scene") {
            PlayerPrefs.DeleteKey("Ground");
            PlayerPrefs.DeleteKey("g_Wincount"); //기회
            PlayerPrefs.DeleteKey("golfGame");
            SceneManager.LoadScene("g_Scene");
        }
        if (SceneManager.GetActiveScene().name == "d_Scene")
        {
        
            SceneManager.LoadScene("d_Scene");
        }
        if (SceneManager.GetActiveScene().name == "t_Scene")
        {

            SceneManager.LoadScene("t_Scene");
        }
        if (SceneManager.GetActiveScene().name == "a_Scene")
        {

            SceneManager.LoadScene("a_Scene");
        }

    }
    public void quit_restartBtn() // 아예 처음부터
    {
        btnclickSound.Play();
        if (SceneManager.GetActiveScene().name == "g_Scene")
        {
            PlayerPrefs.DeleteKey("Ground");
            PlayerPrefs.DeleteKey("g_Wincount"); //기회
            PlayerPrefs.DeleteKey("golfGame");
            SceneManager.LoadScene("g_Scene");
        }
        if (SceneManager.GetActiveScene().name == "k_Scene")
        {

        }
        if (SceneManager.GetActiveScene().name == "t_Scene")
        {

       
        }
        if (SceneManager.GetActiveScene().name == "a_Scene")
        {

      
        }
        SceneManager.LoadScene("StartScene");
    }
 

    public void OkBtn() //지도화면 , 
    {
        btnclickSound.Play();
        if (SceneManager.GetActiveScene().name == "g_Scene")
        {
            if ((PlayerPrefs.HasKey("golfWinScore")))
            {
                //밖의 지도씬으로 이동
                /*
                 * 여기 값이 있다 치면 밖에 지도씬으로 가서
                 * 게임을 완수했다는 점수를 줄 때 golfWinScore값의 유무로 하면 될듯 합니다.
                 */
            }
            if (!(PlayerPrefs.HasKey("golfWinScore")))
            {
               /*여기 성공한 값 없이 그냥 지도로 나가게 되다는 ㄴ것을
                * 좀 더 보기 좋게 정리하려고 필요없는 데 만들었습니다.
                * 삭제 해도 상관없을 것 같습니다.

                */
            }
        }
        if (SceneManager.GetActiveScene().name == "d_Scene")
        {

          
        }
        if (SceneManager.GetActiveScene().name == "t_Scene")
        {

        }
        if (SceneManager.GetActiveScene().name == "a_Scene")
        {

        }


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
