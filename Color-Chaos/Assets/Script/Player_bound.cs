using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_bound : MonoBehaviour
{
    public float min_X = -2.5f, max_X = 2.5f, min_Y = -5.6f;
    private bool out_Of_Bounds;
    private Text scoreText;
    private int score = 0;
    private void Awake()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        scoreText.text = "0";
    }
    void Update()
    {
        CheckBounds();
    }

    void CheckBounds()
    {

        Vector2 temp = transform.position;

        if (temp.x > max_X)
            temp.x = max_X;

        if (temp.x < min_X)
            temp.x = min_X;

        transform.position = temp;

        if (temp.y <= min_Y)
        {

            if (!out_Of_Bounds)
            {

                out_Of_Bounds = true;
                if (PlayerPrefs.GetFloat("HighScore") < score)
                    PlayerPrefs.SetFloat("HighScore", score);
                SoundManager.instance.DeathSound();
                GameManager.instance.RestartGame();

            }

        }

    } // check bounds

    void OnTriggerEnter2D(Collider2D target)
    {

        if (target.tag == "TopSpike")
        {

            transform.position = new Vector2(1000f, 1000f);
            if (PlayerPrefs.GetFloat("HighScore") < score)
                PlayerPrefs.SetFloat("HighScore", score);
            SoundManager.instance.DeathSound();
            GameManager.instance.RestartGame();

        }

        if (target.tag == "coin")
        {
            score++;
            scoreText.text = score.ToString();
            
            target.gameObject.SetActive(false);
        }


        if (target.tag == "ColorChanger")
        {
            score = score + 4;
            scoreText.text = score.ToString();

            target.gameObject.SetActive(false);
        }


    }
}
