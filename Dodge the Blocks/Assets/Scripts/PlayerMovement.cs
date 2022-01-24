using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float HorizontalInput;
    public float speed = 15f;
    public float xRange = 4f;

    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * Time.deltaTime * speed * HorizontalInput);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
