using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNave : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody rb;

    Vector3 movimiento;


    private void Update()
    {
        movimiento.x = Input.GetAxisRaw("Horizontal");
        movimiento.z = Input.GetAxisRaw("Vertical");
    }


    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movimiento * moveSpeed * Time.fixedDeltaTime);
    }



}
