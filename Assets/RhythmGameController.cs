using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RhythmGameController : MonoBehaviour
{
    public KeyCode[] arrowKeys;  // ��������� � ��������� Unity ������� ��� ������� �����������.
    public GameObject arrowPrefab;
    public Transform arrowSpawnPoint;
    public float arrowSpeed = 5.0f;

    void Update()
    {
        if (Input.GetKeyDown(arrowKeys[0]))  // � ������ �������, arrowKeys[0] - ������� "�����"
        {
            SpawnArrow();
        }
        // �������� ����������� ����� ��� ������ ����������� (�����, ����, ������).
    }

    void SpawnArrow()
    {
        GameObject arrow = Instantiate(arrowPrefab, arrowSpawnPoint.position, Quaternion.identity);
        Rigidbody2D arrowRb = arrow.GetComponent<Rigidbody2D>();
        arrowRb.velocity = Vector2.up * arrowSpeed;
    }
}
