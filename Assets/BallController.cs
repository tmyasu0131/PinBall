﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BallController : MonoBehaviour
{

    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    private GameObject scoreText;
    private int num = 0;

    // Use this for initialization
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
        //シーン中のScoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
        this.scoreText.GetComponent<Text>().text = "Score: " + num;

    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {
        string yourTag = collision.gameObject.tag;

        if (yourTag == "SmallStarTag")
        {
            //スコアを加算
            this.num += 1;
            this.scoreText.GetComponent<Text>().text = "Score: " + num;
        }
        else if (yourTag == "LargeStarTag")
        {
            //スコアを加算
            this.num += 5;
            this.scoreText.GetComponent<Text>().text = "Score: " + num;
        }
        else if (yourTag == "SmallCloudTag")
        {
            //スコアを加算
            this.num += 10;
            this.scoreText.GetComponent<Text>().text = "Score: " + num;
        }
        else if(yourTag == "LargeCloudTag")
        {
            //スコアを加算
            this.num += 50;
            this.scoreText.GetComponent<Text>().text = "Score: " + num;
        }


    }
}
