using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapKenzan : MonoBehaviour
{
    //血しぶき, ゲームオーバー画面
    public GameObject BloodFx;
    public GameObject GAMEOVER_UI;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
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