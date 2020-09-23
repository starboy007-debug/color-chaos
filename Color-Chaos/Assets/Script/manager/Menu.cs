using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{
    public GameObject panel;
    public Text Highscoretext;
    void Awake()
    {
        panel.SetActive(false);
        Highscoretext.text = "HighScore:" + ((int)PlayerPrefs.GetFloat("HighScore")).ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void game()
    {
        SceneManager.LoadScene("Game");
    }

    public void info()
    {
        panel.SetActive(true);
    }

    public void back()
    {
        panel.SetActive(false);
    }

    public void exit()
    {
        Application.Quit();

    }

}
