﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unsuccessful : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D collider) {
        Debug.Log("collision");
        Destroy(collider.gameObject);
        GameState.Instance.IncreaseEnemyScore(1);
    }
}
