using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentAnimate : MonoBehaviour
{
    protected Animator animator;
    
    

    void Start()
    {
        // �ش� ������Ʈ�� �ִ� Animator ������Ʈ�� �ڵ����� ������
        animator = GetComponent<Animator>();
        
    }

    void Update()
    {
        /*
        if (Input.GetKey(KeyCode.W))
        {
            animator.enabled = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            animator.enabled = true;
        }

        if (Input.GetKey(KeyCode.S))
        {
            animator.enabled = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            animator.enabled = true;
        }

        else
        {
            animator.enabled= false;
        }
        */
    }
}