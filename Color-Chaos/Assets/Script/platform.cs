using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{

    public float move_Speed = 2f;
    public float bound_Y = 6f;

    public bool bplatform, yplatform, bbplatform, pplatform, rplatform, prplatform, gplatform,is_Spike;

    private Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {

        Vector2 temp = transform.position;
        temp.y += move_Speed * Time.deltaTime;
        transform.position = temp;

        if (temp.y >= bound_Y)
        {
            gameObject.SetActive(false);
        }

    } // move



    void OnTriggerEnter2D(Collider2D target)
    {

        if (target.tag == "Player")
        {

            if (is_Spike)
            {

                target.transform.position = new Vector2(1000f, 1000f);
                SoundManager.instance.GameOverSound();
                GameManager.instance.RestartGame();

            }

        }

    } // on trigger enter

    void OnCollisionEnter2D(Collision2D target)
    {

        if (target.gameObject.tag == "Player")
        {

            


        }

    } // on collision enter

    void OnCollisionStay2D(Collision2D target)
    {

        if (target.gameObject.tag == "Player")
        {

           
        }

    }

}
