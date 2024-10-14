using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform student;  // �л��� Transform�� ������ ����
    [SerializeField] float zOffset = -10f;



    private void Update()
    {
        // ī�޶� ��ġ ������Ʈ
        transform.position = new Vector3(student.position.x, student.position.y, zOffset);
    }
}
