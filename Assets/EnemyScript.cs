using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
 Vector3 targetPosition;
 public Transform target;
 Vector3 startPosition;
 float percentage;
 public float speed = 0.1f;
 bool moving;
 void Start() { InitMovement(); }
 void Update()
 {
     if (moving)
     {
         transform.position = Vector3.Lerp(startPosition, targetPosition, percentage);
         transform.position += new Vector3(Mathf.PingPong(Time.time, 2), 0, 0);
         percentage += speed * Time.deltaTime;
     }
 }
 void InitMovement()
 {
     percentage = 0;
     startPosition = transform.position;
     targetPosition = target.position;
     moving = true;
 }
}






