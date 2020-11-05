using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
   [SerializeField] float power;
   float direction;
   
   void Update()
   {
       transform.position += new Vector3(direction, Time.deltaTime * power/5, 0);
   }   
   
   public void SetPower(float ammount)
   {
       power = ammount;
   }
   public void SetDirection(float num){
       direction = num;
   }
}
