using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    
    [SerializeField] float _power;
    [SerializeField] GameObject _button;
    float _maxPower = 100;
    float _chargeSpeed = 80;
    bool _buttonTriggered;
    public GameObject ball;
    
    void Update()
    {
        if(_buttonTriggered && _power <= _maxPower){
            _power += Time.deltaTime * _chargeSpeed;
            GameState.Instance.DisplayPower(_power);
        }
        if(GameState.Instance.End){
            RemoveButton();
        }
    }
    public void ButtonDown()
    {
        _buttonTriggered = true;

    }
    public void ButtonUp()
    {
        GameObject newBall = Instantiate(ball, new Vector3(1.3f,-4.3f,-2),Quaternion.identity) as GameObject;
        newBall.GetComponent<ball>().SetDirection(-.016f);
        newBall.GetComponent<ball>().SetPower(_power);
        
        _buttonTriggered =false;
        _power = 0;
    }
    public void RemoveButton()
    {
        _button.SetActive(false);
    }
}
