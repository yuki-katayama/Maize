using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalChecker : MonoBehaviour
{
    public GameObject Player;
    public GameObject GOAL_UI;
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
        if(c.gameObject.tag == "Player");
        {
            GOAL_UI.SetActive(true);
        }
    }
}
