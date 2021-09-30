using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Move : MonoBehaviour
{
    public float moveForce;
    public float jumpForce;

    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * moveForce, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * moveForce, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); 
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * -(jumpForce+2), ForceMode.Impulse);
        }


    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(moveForce, rb.velocity.y, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Goal")
        {
            SceneManager.LoadScene("LevelEnd");
        }
        if (collision.collider.tag == "Obsticle")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
