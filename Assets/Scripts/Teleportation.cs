using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public Transform teleportTarget;
    public Bullet bullet;
    private Rigidbody2D rb;
    private float x;
    private float y;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //if (other.gameObject.tag == "Bullet")
        //{
        //    if (bullet.rb.velocity.x > 0f)
        //    {
        //        Debug.Log("I am on right side!! so I will emerge from right");
        //        bullet.transform.position = new Vector3(teleportTarget.transform.position.x + 2, teleportTarget.transform.position.y, teleportTarget.transform.position.z);
        //    }
        //
        //    if (bullet.rb.velocity.x < 0f)
        //    {
        //        Debug.Log("I am on left side!! so I will emerge from left");
        //        bullet.transform.position = new Vector3(teleportTarget.transform.position.x - 2, teleportTarget.transform.position.y, teleportTarget.transform.position.z);
        //    }


            //Vector3 inPosition = this.transform.InverseTransformPoint(bullet.transform.position);
            //inPosition.x = -inPosition.x;
            //Vector3 outPosition = teleportTarget.transform.TransformPoint(inPosition);

            //Vector3 inDirection = this.transform.InverseTransformDirection(bullet.rb.velocity);
            //Vector3 outDirection = teleportTarget.transform.TransformDirection(inDirection);

            //bullet.transform.position = outPosition;
            //bullet.rb.velocity = -outDirection;


            //if(bullet.transform.forward.z > 0)
            //{
            //    Debug.Log("I am facing left!");
            //Vector2 new_velocity = new Vector2(bullet.rb.velocity.x, bullet.rb.velocity.y);
            //x = bullet.rb.velocity.x;
            //y = bullet.rb.velocity.y;
            //    bullet.transform.position = new Vector3(teleportTarget.transform.position.x , teleportTarget.transform.position.y, teleportTarget.transform.position.z);
            //bullet.rb.velocity = new_velocity;
            //    bullet.rb.velocity = new Vector3(x, y, 0);
            //    Debug.Log("I have Teleported");
            //}

            //if (bullet.transform.forward.z < 0)
            //{
            //    Debug.Log("I am facing right!");
            //    bullet.transform.position = new Vector3(teleportTarget.transform.position.x + 1, teleportTarget.transform.position.y, teleportTarget.transform.position.z);
            //    Debug.Log("I have Teleported");
            //}
            //bullet.transform.position = new Vector3(teleportTarget.transform.position.x - 1, teleportTarget.transform.position.y, teleportTarget.transform.position.z);
            //Debug.Log("I have Teleported");
        //}

    }
}
