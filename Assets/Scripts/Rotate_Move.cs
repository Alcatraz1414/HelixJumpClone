using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Move : MonoBehaviour
{
    [Range(100f, 300f)]
    public float rotateSpeed;
    private float moveX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Mouse X");

        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0f, moveX*rotateSpeed*Time.deltaTime,0f);
        }
    }
}
