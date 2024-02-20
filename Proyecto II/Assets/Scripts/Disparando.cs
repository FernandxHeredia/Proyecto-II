using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparando : MonoBehaviour
{
    public Transform puntoDisparo;
    public GameObject disparoPrefab;

    public float bulletForce = 5f;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bala = Instantiate(disparoPrefab, puntoDisparo.position, puntoDisparo.rotation);
        Rigidbody rb = bala.GetComponent<Rigidbody>();
        rb.AddForce(puntoDisparo.transform.forward * bulletForce, ForceMode.Impulse);
    }
}
