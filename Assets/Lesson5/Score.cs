using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //GameScoreの変数
    private int GameScore =0;
    //点数を表示するテキスト
    private GameObject scoretext;

    // Start is called before the first frame update
    void Start()
    {
        //シーン中の開始スコアを取得
        this.scoretext = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Ballが衝突したオブジェクトがSmallCloudだった場合
        if (collision.gameObject.tag == "SmallCloudTag")
        {
            //Scoreに100点追加
            GameScore += 100;
            //ToString()でint型をstring型に変換
            this.scoretext.GetComponent<Text>().text = "Score " + this.GameScore;
        }
        //LaegeCloudの場合
        else if (collision.gameObject.tag == "LargeCloudTag")
        {
            //LargeCloudの場合200点
            GameScore += 200;
            this.scoretext.GetComponent<Text>().text = "Score " + this.GameScore;
        }
        //SmallStarの場合
        else if (collision.gameObject.tag == "SmallStarTag")
        {
            //SmallStarの場合10点
            GameScore += 10;
            this.scoretext.GetComponent<Text>().text = "Score " + this.GameScore;
        }
        //LargeStarの場合
        else if(collision.gameObject.tag == "LargeStarTag")
        {
            //SmallStarの場合50点
            GameScore += 50;
            this.scoretext.GetComponent<Text>().text = "Score " + this.GameScore;
        }
    }
}
