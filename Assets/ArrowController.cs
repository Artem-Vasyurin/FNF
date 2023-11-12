using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ArrowController : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // �������� ���������
        transform.Translate(Vector2.up * speed * Time.deltaTime);

        // ����������� ��������� ��� ���������� ������� ������� ������
        if (transform.position.y > Camera.main.orthographicSize)
        {
            Destroy(gameObject);
        }

        // �������� �� ������������ �������
        CheckArrowInput();
    }

    void CheckArrowInput()
    {
        // ��������� �������� ����������� ��������
        Vector2 currentVelocity = GetComponent<Rigidbody2D>().velocity;
        ArrowDirection currentDirection = GetArrowDirection(currentVelocity);

        // �������� �� ������������ �������, ���� ��������� ��������� � ������� ����� ������
        if (currentDirection == ArrowDirection.Up && transform.position.y > Camera.main.orthographicSize - 1f)
        {
            // ��� ��� ��� ����������� �������
            Debug.Log("���������� �������!");
        }
    }

    ArrowDirection GetArrowDirection(Vector2 velocity)
    {
        // ����������� ����������� �������� ���������
        if (velocity == Vector2.up)
        {
            return ArrowDirection.Up;
        }
        else if (velocity == Vector2.down)
        {
            return ArrowDirection.Down;
        }
        else if (velocity == Vector2.left)
        {
            return ArrowDirection.Left;
        }
        else 
        {
            return ArrowDirection.Right;
        }
       /* else
        {
            return ArrowDirection.None;
        }*/
    }
}
