using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    // tarkat kommentit löytyvät kurssien materiaaleista

    public float speed = 10;

    private Rigidbody2D rb;
    private Vector2 playerInput;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Im alive");
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        playerInput.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        //rb.AddForce(playerInput * speed);
        rb.velocity = playerInput * speed;
    }
}
