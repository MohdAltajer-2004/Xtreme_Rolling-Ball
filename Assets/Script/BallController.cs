using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float ballSpeed;
    float horizontalInput;
    float verticalInput;
    public float jumpSpeed;
    Rigidbody rb;
    bool isGrouded = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveBall();
        Jump();
        CheckFallOut();
    }
    void MoveBall()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
        rb.AddForce(movement * ballSpeed);
    }
    void Jump()
    {
        if(Input.GetKey(KeyCode.Space) && isGrouded)
        {
            rb.AddForce(new Vector3(0, jumpSpeed, 0), ForceMode.Impulse);
            isGrouded = false;  
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isGrouded = true;
        }
    }
    void CheckFallOut()
    {
        if (transform.position.y < -5f)
        {
            FindAnyObjectByType<GameManager>().GameLost();
        }
    }
}
