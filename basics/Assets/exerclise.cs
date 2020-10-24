using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exerclise : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(10f, 23f, 23f);
        if (Input.GetKeyDown(KeyCode.Z))
        {

            PlayerPrefs.SetInt("golfGame", 1234);
            PlayerPrefs.SetInt("golfWinScore", 1);
            GameManager.instance.Game_resultcv();

        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            
                PlayerPrefs.SetInt("golfGame", 1234);
                PlayerPrefs.SetInt("golfWinScore", 2);
                GameManager.instance.Game_resultcv();
           
        }
        if (Input.GetKeyDown(KeyCode.C))
        {

            PlayerPrefs.SetInt("golfGame", 1234);
            PlayerPrefs.SetInt("golfWinScore", 3);
            GameManager.instance.Game_resultcv();

        }
        if (Input.GetKeyDown(KeyCode.V))
        {

            PlayerPrefs.SetInt("golfGame", 1234);
            PlayerPrefs.SetInt("golfWinScore", 0);
            GameManager.instance.Game_resultcv();

        }



    }
}
