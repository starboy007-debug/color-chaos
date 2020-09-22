using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public GameObject pausepanel;
    void Awake()
    {
        pausepanel.SetActive(false);
    }

    // Update is called once per frame
    public void Pause()
    {
        pausepanel.SetActive(true);
    }

    public void back()
    {
        SceneManager.LoadScene("Game");
        pausepanel.SetActive(false);
    }

    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }

}
