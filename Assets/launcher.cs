using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launcher : MonoBehaviour 
{
   public GameObject Bullet;
   public float fireDuration = 3.0f;
   private float timer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       // マウスの左クリックで Bullet を複製
       if (timer >= fireDuration)
       {
           Instantiate(Bullet, transform.position, transform.rotation);
           timer = 0;
       }
       else
       {
           timer += Time.deltaTime;
       }
    }
}
