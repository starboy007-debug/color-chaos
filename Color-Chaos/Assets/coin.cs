using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public float move_Speed = -2f;
    public float bound_Y = -6f;

    void Update()
    {
        Move();
    }

    void Move()
    {

        Vector2 temp = transform.position;
        temp.y += move_Speed * Time.deltaTime;
        transform.position = temp;

        if (temp.y <= bound_Y)
        {
            gameObject.SetActive(false);
        }

    }

}
