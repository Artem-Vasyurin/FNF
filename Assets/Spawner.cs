using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject arrowPrefab; // Префаб стрелочки
    public float speed = 5f;        // Скорость стрелочек
    public float interval = 2f;     // Интервал создания стрелочек
    private float timer = 0f;

    void Update()
    {
        // Создание стрелочек с определенным интервалом
        timer += Time.deltaTime;
        if (timer >= interval)
        {
            CreateArrow();
            timer = 0f;
        }
    }

    void CreateArrow()
    {
        // Создание стрелочки
        GameObject newArrow = Instantiate(arrowPrefab, transform.position, Quaternion.identity);

        // Выбор случайного направления
        ArrowDirection randomDirection = (ArrowDirection)Random.Range(0, System.Enum.GetValues(typeof(ArrowDirection)).Length);

        // Установка направления стрелочки
        SetArrowDirection(newArrow, randomDirection);

        // Можете добавить дополнительную логику или настройки для новой стрелочки здесь
    }

    void SetArrowDirection(GameObject arrow, ArrowDirection direction)
    {
        // Установка направления стрелочки
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
