using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ArrowController : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Движение стрелочки
        transform.Translate(Vector2.up * speed * Time.deltaTime);

        // Уничтожение стрелочки при достижении верхней границы экрана
        if (transform.position.y > Camera.main.orthographicSize)
        {
            Destroy(gameObject);
        }

        // Проверка на правильность нажатия
        CheckArrowInput();
    }

    void CheckArrowInput()
    {
        // Получение текущего направления движения
        Vector2 currentVelocity = GetComponent<Rigidbody2D>().velocity;
        ArrowDirection currentDirection = GetArrowDirection(currentVelocity);

        // Проверка на правильность нажатия, если стрелочка находится в верхней части экрана
        if (currentDirection == ArrowDirection.Up && transform.position.y > Camera.main.orthographicSize - 1f)
        {
            // Ваш код для правильного нажатия
            Debug.Log("Правильное нажатие!");
        }
    }

    ArrowDirection GetArrowDirection(Vector2 velocity)
    {
        // Определение направления движения стрелочки
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
