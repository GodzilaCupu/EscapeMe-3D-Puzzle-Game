using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed = 3;
    GameObject player;

    public GameObject panelWin;

    public AudioSource win;
    
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }
    // Update is called once per frame
    void Update()
    {
        MoveVertical();
    }

    void MoveVertical()
    {
        float z = Input.GetAxis("Vertical");
        Vector3 dirZ = new Vector3(0, 0, z);
        Debug.Log("Berhasil Vertical");
        player.transform.Translate(dirZ.normalized * Time.deltaTime * speed);

    }

    private void OnCollisionEnter(Collision Menang)
    {
        if (SceneManager.GetActiveScene().name == "Level 1")
        {
            if (Menang.collider.CompareTag("Win"))
            {
                win.Play();
                Debug.Log("Winn");
                panelWin.SetActive(true);
                Time.timeScale = 0;
            }
        } else if (SceneManager.GetActiveScene().name == "Level 2")
        {
            if (Menang.collider.CompareTag("Win"))
            {
                win.Play();
                Debug.Log("Winn");
                panelWin.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
