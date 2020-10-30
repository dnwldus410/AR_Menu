using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinController : MonoBehaviour
{

    public GameObject ball;
    private Handforce Handf;
    public int wincount=3;
    public bool winset = false;
    // Start is called before the first frame update
    void Start()
    {
        Handf = FindObjectOfType<Handforce>();

        if ((PlayerPrefs.HasKey("Wincount")))
        {
           wincount= PlayerPrefs.GetInt("Wincount");
        }
        if (!(PlayerPrefs.HasKey("Wincount")))
        {
            PlayerPrefs.SetInt("Wincount",3);
            wincount = PlayerPrefs.GetInt("Wincount");
        }
        Debug.Log("now = " + wincount);

}

    // Update is called once per frame
    void Update()
    {
        if (Handf.finish == true && Handf.touch == true)
        {
            StartCoroutine(Losing());
        }




    }
    void OnCollisionEnter(Collision col)
    {
        PlayerPrefs.DeleteKey("Ground");
        if (col.collider.tag == "Ball")
        {
            if (wincount == 3)
            {
                Debug.Log("win3 = " + wincount);
            }
            else if (wincount == 2)
            {
                Debug.Log("win2 = " + wincount);
            }
            else if (wincount == 3)
            {
                Debug.Log("win = " + wincount);
            }

        }
    }


    public IEnumerator Losing()
    {
        if (ball.transform.position.z > gameObject.transform.position.z + 1f)
        {

            if (wincount >0 && !winset)
            {
                wincount--;
                PlayerPrefs.SetInt("Wincount", wincount);
                Debug.Log("loosing = " + wincount);
                winset = true;
            }
       

        }


        yield return new WaitForSeconds(10f);
        if (ball.transform.position.z < gameObject.transform.position.z)
        {
            if (wincount > 0 && !winset)
            {

                wincount--;
                PlayerPrefs.SetInt("Wincount", wincount);
                Debug.Log("loosing2 = " + wincount);
                ball.GetComponent<Rigidbody>().velocity = Vector3.zero;              
                winset = true;
            }
           
        }
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("g_Scene");
        if (wincount == 0)
        {
            Debug.Log(wincount);
            PlayerPrefs.SetInt("Wincount", 0);
            PlayerPrefs.DeleteKey("Wincount");
        }
        winset = false;
    }
}
        


    
