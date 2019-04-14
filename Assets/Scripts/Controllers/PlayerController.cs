using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GoHome
{
    public class PlayerController : MonoBehaviour
    {
        public float speed = 10f;
        public float maxVelocity = 20f;
        public Rigidbody rigid;

        private void Update()
        {
            if(rigid.velocity.magnitude > maxVelocity)
            {
                rigid.velocity = rigid.velocity.normalized * maxVelocity;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            Collectable c = other.GetComponent<Collectable>();
            if (c)
            {
                c.Collect();
            }
        }

        public void Move(float inputH, float inputV)
        {
            Vector3 direction = new Vector3(inputH, 0, inputV);
            rigid.velocity = direction * speed;
        }
    }
}