using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

    public GameObject ball;
    private Vector3 offset;

    
    void Start()
    {
        offset = transform.position - ball.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = ball.transform.position + offset;
        if (transform.position.y <= -5)
        {
            ball.transform.position = new Vector3(0, 0.5f, 0);
        }
    }
}
