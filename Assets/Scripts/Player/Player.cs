using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public float maxVelocity = 20f;
    public Rigidbody rigid;

    private void Update()
    {
        float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");
        Move(inputH, inputV);

        Vector3 velocity = rigid.velocity;
        if (velocity.magnitude > maxVelocity)
        {
            rigid.velocity = velocity.normalized * maxVelocity;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Item item = other.GetComponent<Item>();
        if (item)
        {
            item.Collect();
        }
    }

    public void Move(float inputH, float inputV)
    {
        Vector3 direction = new Vector3(inputH, 0, inputV);
        rigid.velocity = direction * speed;
    }
}