using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class angryHumAddPointSc : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        //衝突判定
        if (collision.gameObject.tag == "Seed")
        {
            //スコア処理を追加
            FindObjectOfType<ScoreManagerSc>().AddPoint(150);

            //相手のタグがBallならば、自分を消す
            Destroy(this.gameObject);
        }
    }
}
