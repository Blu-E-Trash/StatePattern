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
            Debug.Log("�������� �����̴� ��");
        }

        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            Debug.Log("���������� �����̴� ��");
        }
        else if (Input.GetButtonUp("Horizontal"))
        {
            Debug.Log("����");
        }
    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("����!");
        }
    }
     
}
