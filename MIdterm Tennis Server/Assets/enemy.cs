using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider) {
        Destroy(collider.gameObject);
        GameObject newBall = Instantiate(ball, new Vector3(-.35f,4.2f,-2),Quaternion.identity) as GameObject;
        newBall.GetComponent<ball>().SetDirection(.001f);
        newBall.GetComponent<ball>().SetPower(-55);
        GameState.Instance.IncreaseEnemyScore(1);  
    }
}
