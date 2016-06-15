using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    private Rigidbody rb;
    private int points = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        if (moveH == 0) moveH = Input.acceleration.x * 2;
        if (moveV == 0) moveH = Input.acceleration.y * 2;


        rb.AddForce(new Vector3(moveH * 5, 0.0f, moveV * 5));

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bbad"))
        {
            other.gameObject.SetActive(false);
            points++;
        }
    }

}
