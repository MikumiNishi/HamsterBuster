using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UIの追加

public class ScoreManagerSc : MonoBehaviour
{
    public Text scoreText;
    public Text highscoreText;
    public Text humsterNumText;

    private int score; //スコア変数
    private int highScore;
    private string highScoreKey = "highscore";

    GameObject[] humsterObjects;
    private int humsterNum;

    //初期化
    // Start is called before the first frame update
    void Start()
    {
        Intialize();

    }


    private void Update()
    {
        //scoreがハイスコアより大きければ
        if (highScore < score)
        {
            highScore = score;
        }
        //スコア・ハイスコアを表示する
        scoreText.text = score.ToString();
        highscoreText.text = highScore.ToString();

        //ハムスターの現在の数を表示する
        humsterObjects = GameObject.FindGameObjectsWithTag("humster");
        humsterNum = humsterObjects.Length;
        humsterNumText.text = humsterNum.ToString();

    }

    //ゲーム開始前の状態に戻す
    public void Intialize()
    {
        // スコアを0にする
        score = 0;

        //ハイスコアを取得する 無い時は0
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);

    }

    //ポイントの追加
    public void AddPoint(int point)
    {
        score = score + point;

    }

    //ハイスコアの保存
    public void Save()
    {
        //ハイスコアを保存して、
        PlayerPrefs.SetInt(highScoreKey, highScore);
        PlayerPrefs.Save();

        //ゲーム開始前の状態に戻す
        Intialize();
    }

}
