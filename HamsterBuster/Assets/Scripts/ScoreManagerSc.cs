using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UIの追加

public class ScoreManagerSc : MonoBehaviour
{
    public GameObject score_object = null; //textオブジェクト
    public Text scoreText;
    public int score_num = 0; //スコア変数


    //初期化
    // Start is called before the first frame update
    void Start()
    {
        score_num = 0;
        SetScore();

    }

    private void OnCollisionEnter(Collision collision)
    {
        string yourTag = collision.gameObject.tag;

        if (yourTag == "humster")
        {
            score_num += 150;
        }
        else
        {
            score_num = 0;
        }

        SetScore();

    }

    void SetScore()
    {
        scoreText.text = string.Format("Score:{0}", score_num);

    }


    //ここいる？↓
    private void OnGUI()
    {
        GUI.color = Color.black;

        //現在のスコアを表示
        string label = "Score : " + score_num;

        GUI.Label(new Rect(0, 0, 100, 30), label);
    }

}
