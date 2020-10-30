using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update


    private void Awake()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
AndroidIntent();
#endif

    }
    void AndroidIntent()
    {
        string arguments = "";
        AndroidJavaClass UnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");

        AndroidJavaObject currentActivity = UnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
        AndroidJavaObject intent = currentActivity.Call<AndroidJavaObject>("getIntent");
        arguments = intent.Call<string>("getStringExtra", "testData");
        if (arguments == "2")
        {
            SceneManager.LoadScene(0);
        }
        else if(arguments == "3")
        {
            SceneManager.LoadScene(1);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}