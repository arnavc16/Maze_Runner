using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    GameManagerScript GMS;
    private float rotateSpeed = 10f;
    public float xGrowRate = 10.0F;
    public float yGrowRate = 10.0F;
    public float zGrowRate = 10.0F;
    public float playerMass = 1.0f;
    public float massGrowRate = 0.1f;
    private Rigidbody rb;
    private int count;

    void Awake()
    {
        GMS = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
        GMS.cur_coins++;
    }

    void Update()
    {
        transform.Rotate(Vector3.left * rotateSpeed);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "player")
        {
            Destroy(gameObject);
            GMS.cur_coins--;

            GMS.UpdateUI();
        }
    }
    void IncreaseCount()
    {
        count = count + 1;
        transform.localScale += new Vector3(xGrowRate, yGrowRate, zGrowRate);
        rb.mass += massGrowRate;
    }

}
