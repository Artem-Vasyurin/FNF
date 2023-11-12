using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject arrowPrefab; // ������ ���������
    public float speed = 5f;        // �������� ���������
    public float interval = 2f;     // �������� �������� ���������
    private float timer = 0f;

    void Update()
    {
        // �������� ��������� � ������������ ����������
        timer += Time.deltaTime;
        if (timer >= interval)
        {
            CreateArrow();
            timer = 0f;
        }
    }

    void CreateArrow()
    {
        // �������� ���������
        GameObject newArrow = Instantiate(arrowPrefab, transform.position, Quaternion.identity);

        // ����� ���������� �����������
        ArrowDirection randomDirection = (ArrowDirection)Random.Range(0, System.Enum.GetValues(typeof(ArrowDirection)).Length);

        // ��������� ����������� ���������
        SetArrowDirection(newArrow, randomDirection);

        // ������ �������� �������������� ������ ��� ��������� ��� ����� ��������� �����
    }

    void SetArrowDirection(GameObject arrow, ArrowDirection direction)
    {
        // ��������� ����������� ���������
        Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();

        switch (direction)
        {
            case ArrowDirection.Up:
                rb.velocity = Vector2.up * speed;
                break;
            case ArrowDirection.Down:
                rb.velocity = Vector2.down * speed;
                break;
            case ArrowDirection.Left:
                rb.velocity = Vector2.left * speed;
                break;
            case ArrowDirection.Right:
                rb.velocity = Vector2.right * speed;
                break;
            default:
                break;
        }
    }
}
