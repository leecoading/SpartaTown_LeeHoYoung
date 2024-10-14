using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentMove : MonoBehaviour
{
    [SerializeField] float jump = 2f;
    [SerializeField] float speed = 5f;
    protected Animator animator;
    private Vector3 mousePosition;

    public Vector3 idOffset = new Vector3(0, 2, 0);  // Student 오브젝트와 아이디 텍스트 사이의 거리 (오프셋)
    private string playerId;




    private void Start()
    {
        playerId = PlayerPrefs.GetString("PlayerID", "Player");
        
    }


    void Update()
    {
        // wasd를 이용한 이동 구현
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
        


        // 달리기 기능 구현
        if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            speed = 15f;
        }
   
        else
        {
            speed = 5f;
        }

        //점프시 실행할 점프 애니메이션
        if(Input.GetKeyDown(KeyCode.Space))
        {
            
        }


        // student 오브젝트의 위치를 조정하는 코드
        transform.position += (Vector3)move * speed * Time.deltaTime;
        // 속도와 델타타임을 곱하는 이유
        // 속도는 개발자가 원하는 속도를 맞추기 위함.
        // 델타타임은 프레임에 따라 달라질 수 있는 속도를 맞추기 위함.



        MousePosition();
        

    }

    public void MousePosition()
    {
        // 마우스 위치를 화면 좌표에서 월드 좌표로 변환
        //메인 카메라의 월드좌표에서 input라는 클래스안에 있는 mousePosition이라는 매서드를 사용(F12)눌러 확인 가능
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        // 마우스가 캐릭터의 왼쪽에 있으면 왼쪽을 보도록 스케일을 뒤집음
        // 이 방법 외에도 spriteRenderer의 flip기능을 불러와서 작성해도 가능.
        //예시
        //SpriteRenderer sp = GetComponent<SpriteRenderer>();
        //sp.flipX = mousePosition.x > transform.position.x;

        if (mousePosition.x < transform.position.x)
        {
            transform.localScale = new Vector3(-0.6f, 0.6f, 0);  // 왼쪽을 보게 스케일을 반전
        }
        // 마우스가 캐릭터의 오른쪽에 있으면 오른쪽을 보도록 스케일을 원래대로 설정
        else if (mousePosition.x > transform.position.x)
        {
            transform.localScale = new Vector3(0.6f, 0.6f, 0);   // 오른쪽을 보게 스케일을 정상으로
        }
    }

   public void StudentName()
    {

    }
}
