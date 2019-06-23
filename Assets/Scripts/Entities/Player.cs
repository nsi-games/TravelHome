using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool hideCursor = false;
    public float moveSpeed = 10f;
    public float rotationSpeed = 10f;
    public float maxVelocity = 20f;

    private Rigidbody rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Start()
    {
        // Should the cursor be hidden?
        if (hideCursor)
        {
            // Hide it!
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }    
    }
    
    // Update is called once per frame
    void Update()
    {
        // Get input from user
        float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");
        // Get character (cube) to move
        Move(inputH, inputV);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Did we hit a thing with an Item component?
        Item item = other.GetComponent<Item>();
        if (item)
        {
            // Collect it!
            item.Collect();
        }
    }

    public void Move(float inputH, float inputV)
    {
        // Copy rigid.velocity to 'velocity' vector
        Vector3 velocity = rigid.velocity;
        // Get input from user into 'inputDirection' vector
        Vector3 inputDirection = new Vector3(inputH, 0, inputV) * moveSpeed;
        // Convert inputDirection from localspace to worldspace and store in 'direction' variable
        Vector3 direction = transform.TransformDirection(inputDirection);
        // Set 'velocity' to Vector3(direction (x), velocity (y), direction (z)) and multiply by moveSpeed
        velocity = new Vector3(direction.x, velocity.y, direction.z);
        // Apply new velocity to 'rigid.velocity' 
        rigid.velocity = velocity; 
    }
}
