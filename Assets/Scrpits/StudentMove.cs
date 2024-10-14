using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentMove : MonoBehaviour
{
    [SerializeField] float jump = 2f;
    [SerializeField] float speed = 5f;
    protected Animator animator;
    private Vector3 mousePosition;

    public Vector3 idOffset = new Vector3(0, 2, 0);  // Student ������Ʈ�� ���̵� �ؽ�Ʈ ������ �Ÿ� (������)
    private string playerId;




    private void Start()
    {
        playerId = PlayerPrefs.GetString("PlayerID", "Player");
        
    }


    void Update()
    {
        // wasd�� �̿��� �̵� ����
        Vector2 move = Vector2.zero;

        if(Input.GetKey(KeyCode.W))
        {
            move += Vector2.up;
        }

        if (Input.GetKey(KeyCode.A))
        {
            move += Vector2.left;
        }

        if(Input.GetKey(KeyCode.S))
        {
            move += Vector2.down;
        }

        if(Input.GetKey(KeyCode.D))
        {
            move += Vector2.right;
        }
        


        // �޸��� ��� ����
        if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            speed = 15f;
        }
   
        else
        {
            speed = 5f;
        }

        //������ ������ ���� �ִϸ��̼�
        if(Input.GetKeyDown(KeyCode.Space))
        {
            
        }


        // student ������Ʈ�� ��ġ�� �����ϴ� �ڵ�
        transform.position += (Vector3)move * speed * Time.deltaTime;
        // �ӵ��� ��ŸŸ���� ���ϴ� ����
        // �ӵ��� �����ڰ� ���ϴ� �ӵ��� ���߱� ����.
        // ��ŸŸ���� �����ӿ� ���� �޶��� �� �ִ� �ӵ��� ���߱� ����.



        MousePosition();
        

    }

    public void MousePosition()
    {
        // ���콺 ��ġ�� ȭ�� ��ǥ���� ���� ��ǥ�� ��ȯ
        //���� ī�޶��� ������ǥ���� input��� Ŭ�����ȿ� �ִ� mousePosition�̶�� �ż��带 ���(F12)���� Ȯ�� ����
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        // ���콺�� ĳ������ ���ʿ� ������ ������ ������ �������� ������
        // �� ��� �ܿ��� spriteRenderer�� flip����� �ҷ��ͼ� �ۼ��ص� ����.
        //����
        //SpriteRenderer sp = GetComponent<SpriteRenderer>();
        //sp.flipX = mousePosition.x > transform.position.x;

        if (mousePosition.x < transform.position.x)
        {
            transform.localScale = new Vector3(-0.6f, 0.6f, 0);  // ������ ���� �������� ����
        }
        // ���콺�� ĳ������ �����ʿ� ������ �������� ������ �������� ������� ����
        else if (mousePosition.x > transform.position.x)
        {
            transform.localScale = new Vector3(0.6f, 0.6f, 0);   // �������� ���� �������� ��������
        }
    }

   public void StudentName()
    {

    }
}
