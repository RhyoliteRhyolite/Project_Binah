using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    float speed = 10f;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");
        float zMove = Input.GetAxis("Vertical");

        Vector3 getVel = new Vector3(xMove, 0, zMove) * speed;
        rb.linearVelocity = getVel;
    }
}

