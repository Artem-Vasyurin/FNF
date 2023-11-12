using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RhythmGameController : MonoBehaviour
{
    public KeyCode[] arrowKeys;  // Настройте в редакторе Unity клавиши для каждого направления.
    public GameObject arrowPrefab;
    public Transform arrowSpawnPoint;
    public float arrowSpeed = 5.0f;

    void Update()
    {
        if (Input.GetKeyDown(arrowKeys[0]))  // В данном примере, arrowKeys[0] - клавиша "Вверх"
        {
            SpawnArrow();
        }
        // Добавьте аналогичные блоки для других направлений (влево, вниз, вправо).
    }

    void SpawnArrow()
    {
        GameObject arrow = Instantiate(arrowPrefab, arrowSpawnPoint.position, Quaternion.identity);
        Rigidbody2D arrowRb = arrow.GetComponent<Rigidbody2D>();
        arrowRb.velocity = Vector2.up * arrowSpeed;
    }
}
