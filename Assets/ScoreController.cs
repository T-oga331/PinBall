using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreController : MonoBehaviour

{
    //Text表示用
    private GameObject gamescoreText;
    //スコア変数
    private int Score = 0;

    // Use this for initialization
    void Start()
    {
        //Canvasからテキストオブジェクトを取得
        gamescoreText = GameObject.Find("GameScoreText");
    }

    // Update is called once per frame
    void Update()
    {

    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {

        //SmallとLargeStarTagは10点
        if (other.gameObject.tag == "SmallStarTag" || other.gameObject.tag == "LargeStarTag")
        {
            Score += 10;
        }

        //SmallとLargeCloudTagは20点
        else if (other.gameObject.tag == "SmallCloudTag" || other.gameObject.tag == "LargeCloudTag")
        {
            Score += 20;
        }

        //得点を表示
        gamescoreText.GetComponent<Text>().text = "Score" + Score;
    }
}
