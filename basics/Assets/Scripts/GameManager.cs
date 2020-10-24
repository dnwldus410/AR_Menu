using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject Wincv;
    public GameObject Losecv;
    public GameObject[] heartscore;
    int golfscore = 5;
    int kitescore = 5;
    int tuhoscore = 5;
    int arrowscore = 5;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    /*
     * 이 양식으로 해주셔야 실행됩니다.
     * 게임이 이기든 지든 메소드안의 코드에ex)PlayerPrefs.SetInt("golfGame", 1234);를 저장하시고
      몇번째 이겼는지의 특정 변수에다가 저장되어 있는 값을 ex)PlayerPrefs.SetInt("golfWinScore",변수이름);해주세요. 그다음
      마지막에 GameManager.instance.Game_resultcv();을 쓰시면 이 메소드가 호출되고 Game_resultcv()가 실행
     진 상황의 값dmf 0으로 해서 저장 후 똑같이 호출해 주세요 . .
      */
    public void Game_resultcv()
    {

        if ((PlayerPrefs.HasKey("golfGame")))
        {
            golfscore = PlayerPrefs.GetInt("golfWinScore");
            kitescore = PlayerPrefs.GetInt("kiteWinScore");
            tuhoscore = PlayerPrefs.GetInt("tuhoWinScore");
            arrowscore = PlayerPrefs.GetInt("arrowWinScore");


            if (golfscore == 0 || kitescore==0||tuhoscore==0||arrowscore==0)
                {
                    Losecv.SetActive(true);
                }
               else if (golfscore == 1 || kitescore == 1 || tuhoscore == 1 || arrowscore == 1)
                {

                    Wincv.SetActive(true);
                    heartscore[2].SetActive(false);
                    heartscore[1].SetActive(false);

            }
                else if (golfscore == 2 || kitescore == 2 || tuhoscore == 2 || arrowscore == 2)
                {

                    Wincv.SetActive(true);
                heartscore[2].SetActive(false);

            }
               else if (golfscore == 3 || kitescore == 3 || tuhoscore == 3 || arrowscore == 3)
                {

                    Wincv.SetActive(true);

                }
            
            
        }
    }
}
