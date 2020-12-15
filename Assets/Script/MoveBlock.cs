using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour
{
    public float speed;

    GameObject cubeX, cubeZ;

    private void Start()
    {
        cubeZ = GameObject.FindGameObjectWithTag("Vertical");
        cubeX = GameObject.FindGameObjectWithTag("Horizontal");
    }

    void Update()
    {
            MoveHorizontal();
            MoveVertical();
        
    }

    void MoveHorizontal()
    {
        
        float x = Input.GetAxis("Horizontal");
        Vector3 dirX = new Vector3(x, 0, 0);
        cubeX.transform.Translate(dirX.normalized * Time.deltaTime * speed);
        Debug.Log("Berhasil Horizontal");
    }
    void MoveVertical()
    {
        float z = Input.GetAxis("Vertical");
        Vector3 dirZ = new Vector3(0, 0,z);
        Debug.Log("Berhasil Vertical");
        cubeZ.transform.Translate(dirZ.normalized * Time.deltaTime * speed);
        
    }
}
