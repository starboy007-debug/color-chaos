using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using UnityEditor.Experimental.U2D;
using UnityEngine;
using UnityEngine.SceneManagement;
public class player : MonoBehaviour
{
    private Rigidbody2D myBody;

    public string currentColor;

    public float moveSpeed = 2f;
    public SpriteRenderer sr;
    public Sprite b;
    public Sprite r;
    public Sprite p;
    public Sprite bl;
    public Sprite g;
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {

        if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            myBody.velocity = new Vector2(moveSpeed, myBody.velocity.y);
        }

        if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            myBody.velocity = new Vector2(-moveSpeed, myBody.velocity.y);
        }

        if (Input.GetButtonDown("Jump"))
        {
            myBody.velocity = new Vector2(myBody.velocity.x, moveSpeed+3f);
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "ColorChanger")
        {
            SetRandomColor();
            Destroy(col.gameObject);
            return;
        }
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != currentColor && collision.gameObject.tag != "Black")
        {
            if (sr.sprite != b)
            {
                Debug.Log("GAME OVER!");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
           
        }
    }
    void SetRandomColor()
    {
        int index = Random.Range(0, 4);

        switch (index)
        {
            case 0:
                if (Random.Range(0, 2) > 0)
                {
                    currentColor = "Black";
                    sr.sprite = b;
                }
                else
                {
                    currentColor = "Red";
                    sr.sprite = r;
                }
                break;

            case 1:
                if (Random.Range(0, 2) > 0)
                {
                    currentColor = "Black";
                    sr.sprite = b;
                }
                else
                {
                    currentColor = "Purple";
                    sr.sprite = p;
                }
                break;

            case 2:
                if (Random.Range(0, 2) > 0)
                {
                    currentColor = "Black";
                    sr.sprite = b;
                }
                else
                {
                    currentColor = "Blue";
                    sr.sprite = bl;
                }
                break;

            case 3:
                if (Random.Range(0, 2) > 0)
                {
                    currentColor = "Black";
                    sr.sprite = b;
                }
                else
                {
                    currentColor = "Green";
                    sr.sprite = g;
                }
                break;


        }

    }

}
