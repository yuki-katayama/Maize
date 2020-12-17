using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour 
{
   private float force = 80;
   private float timer;
   private float destroyTimer = 5.0f;
   public GameObject BloodFx;
   public GameObject GAMEOVER_UI;

    // Start is called before the first frame update
   void Awake()
    {
       // Rigidbody コンポーネントを取得
       Rigidbody rb = gameObject.GetComponent<Rigidbody>();

       // Z 方向に力を掛け合わせる
       Vector3 fireForce = transform.forward * force;

       // fireForce の力を加える
       rb.AddForce(fireForce, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
       // timer が destroyTimer 以上の時間になったら
       if (timer >= destroyTimer)
       {
           // 自身(弾)のオブジェクトを消す
           Destroy(gameObject);
       }
       // timer がまだ destroyTimer 以下である場合
       else
       {
           // timer に Update で行われた時間進行の量を足す
           timer += Time.deltaTime;
       }
    }

    void OnTriggerEnter(Collider c)
    {
        GameObject cGO = c.gameObject;
        if(cGO.tag == "Player")
        {
            // 血しぶきを表示
            Instantiate(BloodFx, transform.position, transform.rotation);
            // プレイヤーを非表示＆ゲームオーバー画面を表示
            cGO.SetActive(false);
            GAMEOVER_UI.SetActive(true);
        }
    }
}