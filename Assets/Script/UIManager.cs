using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    #region Deklarasi
    public GameObject infoPanel;

    [SerializeField]
    private float delayLoading = 2f;
    private float timeElapeds;

    #endregion

    #region Menu
    public void Info()
    {
        infoPanel.SetActive(true);

    }

    public void BackInfo()
    {
        infoPanel.SetActive(false);

    }

    public void Intro()
    {
        SceneManager.LoadScene("Intro");
    }

    public void Exit()
    {
        Application.Quit();
    }
    #endregion

    #region Intro
    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Play()
    {
        SceneManager.LoadScene("Level 1");
    }
    #endregion

    #region level1

    public void Level1()
    {
        if (SceneManager.GetActiveScene().name == "Level 1")
        {
            if (Input.GetKey(KeyCode.Y))
            {
                SceneManager.LoadScene("Level 2");
            }
            else if (Input.GetKey(KeyCode.N))
            {
                SceneManager.LoadScene("Menu");
            }
        }

    }
    #endregion

    #region level2

    public void Level2()
    {
        if (SceneManager.GetActiveScene().name == "Level 2")
        {
            if (Input.GetKey(KeyCode.Y))
            {
                SceneManager.LoadScene("Level 1");
            } else if (Input.GetKey(KeyCode.N))
            {
                SceneManager.LoadScene("Menu");
            }
        }
        
    }
    #endregion

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Intro")
        {
            timeElapeds += Time.deltaTime;

            if (timeElapeds > delayLoading)
            {
                Play();
            }
        }

        Level1();
        Level2();
    }










}
