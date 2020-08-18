using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumDestroyerSc : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        // 画面外の壁に衝突したらhumsterタグのついたオブジェクトは削除
        if (other.gameObject.tag == "humster")
        {
            Destroy(other.gameObject);

            //BoxColliderコンポーネントを取得
            BoxCollider component = this.gameObject.GetComponent<BoxCollider>();
            // 指定したコンポーネントを削除
            Destroy(component);

        }
    }
}
