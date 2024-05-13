using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{
    void FixedUpdate()
    {
        Move();
        Jump();
    }

    void Move()
    {
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            Debug.Log("왼쪽으로 움직이는 중");
        }

        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            Debug.Log("오른쪽으로 움직이는 중");
        }
        else if (Input.GetButtonUp("Horizontal"))
        {
            Debug.Log("멈춤");
        }
    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("점프!");
        }
    }
     
}
