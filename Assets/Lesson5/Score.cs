using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //GameScore�̕ϐ�
    private int GameScore =0;
    //�_����\������e�L�X�g
    private GameObject scoretext;

    // Start is called before the first frame update
    void Start()
    {
        //�V�[�����̊J�n�X�R�A���擾
        this.scoretext = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Ball���Փ˂����I�u�W�F�N�g��SmallCloud�������ꍇ
        if (collision.gameObject.tag == "SmallCloudTag")
        {
            //Score��100�_�ǉ�
            GameScore += 100;
            //ToString()��int�^��string�^�ɕϊ�
            this.scoretext.GetComponent<Text>().text = "Score " + this.GameScore;
        }
        //LaegeCloud�̏ꍇ
        else if (collision.gameObject.tag == "LargeCloudTag")
        {
            //LargeCloud�̏ꍇ200�_
            GameScore += 200;
            this.scoretext.GetComponent<Text>().text = "Score " + this.GameScore;
        }
        //SmallStar�̏ꍇ
        else if (collision.gameObject.tag == "SmallStarTag")
        {
            //SmallStar�̏ꍇ10�_
            GameScore += 10;
            this.scoretext.GetComponent<Text>().text = "Score " + this.GameScore;
        }
        //LargeStar�̏ꍇ
        else if(collision.gameObject.tag == "LargeStarTag")
        {
            //SmallStar�̏ꍇ50�_
            GameScore += 50;
            this.scoretext.GetComponent<Text>().text = "Score " + this.GameScore;
        }
    }
}
