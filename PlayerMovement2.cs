using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2: MonoBehaviour
{
    //1
    public float moveSpeed = 10f;
    public float rotateSpeed = 75f;

    //2
    private float vInput;
    private float hInput;

    private void Update()
    {
        //3
        vInput = Input.GetAxis("Vertical") * moveSpeed;

        //4
        hInput = Input.GetAxis("Horizontal") * rotateSpeed;

        //5
        this.transform.Translate(Vector3.forward * vInput, (Space)Time.deltaTime);

        //6
        this.transform.Rotate(Vector3.up * hInput * Time.deltaTime); 
    }
}
