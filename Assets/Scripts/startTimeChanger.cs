using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startTimeChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start ()
    {
        // Animator コンポーネントを取得
        Animator ani = GetComponent<Animator>();
         // trap01 というアニメーションのステートを Hash として覚えておく
         int AnimHash = Animator.StringToHash("Base Layer.trap01");
         // スタート時間をランダム(0 ～ 1 秒までの小数点を含む値)を用意
         float startTime = Random.value;
         // アニメーションを再生
         ani.Play(AnimHash, 0, startTime);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
