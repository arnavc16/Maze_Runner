using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public GameObject player;

    public float jumpForce = 2.0f;
    public float moveSpeed = 10f;
    public float xGrowRate = 10.0F;
    public float yGrowRate = 10.0F;
    public float zGrowRate = 10.0F;
    public float playerMass = 1.0f;
    public float massGrowRate = 0.1f;
    private Rigidbody rb;
    private int count;
    private Vector3 jump;

    void Start()
    {
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0f, moveZ);
        GetComponent<Rigidbody>().velocity = movement * moveSpeed * Time.deltaTime;

        if (Input.GetKeyDown((KeyCode.A)))
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);

        }
    }
    void IncreaseCount()
    {
        count = count + 1;
        transform.localScale += new Vector3(xGrowRate, yGrowRate, zGrowRate);
        rb.mass += massGrowRate;
    }





}
