using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform student;  // 학생의 Transform을 저장할 변수
    [SerializeField] float zOffset = -10f;



    private void Update()
    {
        // 카메라 위치 업데이트
        transform.position = new Vector3(student.position.x, student.position.y, zOffset);
    }
}
