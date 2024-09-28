using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Ball : MonoBehaviour
{

    public float speed = 10f;
    public Rigidbody rb;
    Renderer renderer;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        renderer = GetComponent<Renderer>();
        Vector3 force = new Vector3(0, -speed, 0);
        rb.AddForce(Vector3.down * speed, ForceMode.VelocityChange);
    }
    void FixedUpdate()
    {
        if(!renderer.isVisible)
        {
            GameManager.Instance.Balls--;
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        // Pick a random direction
        Vector3 direction = Random.onUnitSphere;

        // Set speed in that direction
        rb.velocity = direction * speed;
    }

}