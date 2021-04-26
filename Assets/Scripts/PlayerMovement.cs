using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 targetPosition;
    private bool isMoving = false;
    float speed = 2;

    private float lastClickTime;
    public float catchTime = 0.25f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
 
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            isMoving = true;
            targetPosition.z = transform.position.z;
        }
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            if(transform.position == targetPosition)
            {
                isMoving = false;
            }
        }
    }
}
