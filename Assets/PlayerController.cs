using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        // ��������� ����� ������
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CheckArrowInput(ArrowDirection.Left);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            CheckArrowInput(ArrowDirection.Right);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            CheckArrowInput(ArrowDirection.Up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            CheckArrowInput(ArrowDirection.Down);
        }
    }

    // �������� ������������ �����
    void CheckArrowInput(ArrowDirection arrowDirection)
    {
        
        if (arrowDirection == ArrowDirection.Up && transform.position.y > Camera.main.orthographicSize - 5f)
        {
            // ��� ��� ��� ����������� �������
            Debug.Log("���������� �������!");
        }

        // ������� �� ����������/������������ ����
        if (arrowDirection == ArrowDirection.Up)
        {
            Debug.Log(1);
        }
        else
        {
            Debug.Log(0);
        }
        // ��� 
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


// ����������� �������
public enum ArrowDirection
{
    Left,
    Right,
    Up,
    Down,
    None
}