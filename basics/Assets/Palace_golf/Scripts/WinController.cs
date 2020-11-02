using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinController : MonoBehaviour
{
    public GameObject g_slider;
    public GameObject ball;
    private Handforce Handf;
    public int wincount=3;
    public bool winset = false;
    public Text scoretext;

 
    // Start is called before the first frame update
    void Start()
    {
        winset = false;
        Handf = FindObjectOfType<Handforce>();

        if ((PlayerPrefs.HasKey("g_Wincount")))
        {
           wincount= PlayerPrefs.GetInt("g_Wincount");


        }
        if (!(PlayerPrefs.HasKey("g_Wincount")))
        {
            PlayerPrefs.SetInt("g_Wincount", 3);
            wincount = PlayerPrefs.GetInt("g_Wincount");

        }
        scoretext.text = "기회" + wincount;
    }

    // Update is called once per frame
    void Update()
    {
        if (Handf.finish == true && Handf.touch == true)
        {
            StartCoroutine(Losing());
        }
        

    }
    void OnCollisionStay(Collision col)
    {
       
        if (col.collider.tag == "Ball")
        {
            PlayerPrefs.SetInt("golfGame", 1234);
            if (wincount == 3)
            {

               
                PlayerPrefs.SetInt("golfWinScore", wincount);
                g_slider.SetActive(false);
                ARGameManager.instance.Game_resultcv();
            }
            else if (wincount == 2)
            {
                PlayerPrefs.SetInt("golfWinScore", wincount);
                g_slider.SetActive(false);
                ARGameManager.instance.Game_resultcv();
            }
            else if (wincount == 1)
            {
                PlayerPrefs.SetInt("golfWinScore", wincount);
                g_slider.SetActive(false);
                ARGameManager.instance.Game_resultcv();
            }

        }
    }


    public IEnumerator Losing()
    {
        yield return new WaitForSeconds(3f);
        if (wincount == 0)
        {

            PlayerPrefs.SetInt("golfGame", 1234);
            PlayerPrefs.SetInt("golfWinScore", 0);
            g_slider.SetActive(false);
            ARGameManager.instance.Game_resultcv();
        }
        if (ball.transform.position.z > gameObject.transform.position.z + 1f)
        {
           
             if (wincount>0&&!winset)
            {
                wincount--;
                PlayerPrefs.SetInt("g_Wincount", wincount);
                winset = true;

                yield return new WaitForSeconds(3f);
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
              

            }
        }

        yield return new WaitForSeconds(7f);
        if (ball.transform.position.z < gameObject.transform.position.z)
        {
        
            if (wincount >0 && !winset)
            {

                wincount--;
                PlayerPrefs.SetInt("g_Wincount", wincount);
                ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
                winset = true;


                yield return new WaitForSeconds(3f);
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                
            }
         

        }

    }
}
        


    
