using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{
    public GameObject panel;
    void Awake()
    {
        panel.SetActive(false);
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

}
