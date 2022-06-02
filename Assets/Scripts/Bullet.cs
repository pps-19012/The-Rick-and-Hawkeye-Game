using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    //public GameObject[] Enemies;
    public Transform finale;
    public Transform p1left;
    public Transform p2left;
    public Transform p3left;
    public Transform p4left;
    public Transform p1right;
    public Transform p2right;
    public Transform p3right;
    public Transform p4right;
    //public Transform impact;
    public Bullet bullet;
    public float moveSpeed = 7f;
    public Rigidbody2D rb;
    public Player target;
    private Vector2 moveDirection;
    private bool facingLeft = true;
    //[SerializeField] private string sceneName;
    //[SerializeField] public int enemies;


    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<Player>();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 60f);
    }

    public void Update()
    {
        

        float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


    }


    public void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //Debug.Log("HIT!!");
            //impact.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            transform.position = new Vector3(finale.transform.position.x, finale.transform.position.y, finale.transform.position.z);

        }

        if (col.gameObject.tag == "Portal1_left")
        {
            //Destroy(gameObject);
            if (rb.velocity.x > 0f)
            {
                //Debug.Log("I am on right side!! so I will emerge from right");
                transform.position = new Vector3(p1right.transform.position.x + 0.5f, p1right.transform.position.y, p1right.transform.position.z);
            }

            if (rb.velocity.x < 0f)
            {
                //Debug.Log("I am on left side!! so I will emerge from left");
                transform.position = new Vector3(p1right.transform.position.x - 0.5f, p1right.transform.position.y, p1right.transform.position.z);
            }
        }

        if (col.gameObject.tag == "Portal1_right")
        {
            //Destroy(gameObject);
            if (rb.velocity.x > 0f)
            {
                //Debug.Log("I am on right side!! so I will emerge from right");
                transform.position = new Vector3(p1left.transform.position.x + 0.5f, p1left.transform.position.y, p1left.transform.position.z);
            }

            if (rb.velocity.x < 0f)
            {
                //Debug.Log("I am on left side!! so I will emerge from left");
                transform.position = new Vector3(p1left.transform.position.x - 0.5f, p1left.transform.position.y, p1left.transform.position.z);
            }
        }

        if (col.gameObject.tag == "Portal2_left")
        {
            //Destroy(gameObject);
            if (rb.velocity.x > 0f)
            {
                //Debug.Log("I am on right side!! so I will emerge from right");
                transform.position = new Vector3(p2right.transform.position.x + 0.5f, p2right.transform.position.y, p2right.transform.position.z);
            }

            if (rb.velocity.x < 0f)
            {
                //Debug.Log("I am on left side!! so I will emerge from left");
                transform.position = new Vector3(p2right.transform.position.x - 0.5f, p2right.transform.position.y, p2right.transform.position.z);
            }
        }

        if (col.gameObject.tag == "Portal2_right")
        {
            //Destroy(gameObject);
            if (rb.velocity.x > 0f)
            {
                //Debug.Log("I am on right side!! so I will emerge from right");
                transform.position = new Vector3(p2left.transform.position.x + 0.5f, p2left.transform.position.y, p2left.transform.position.z);
            }

            if (rb.velocity.x < 0f)
            {
                //Debug.Log("I am on left side!! so I will emerge from left");
                transform.position = new Vector3(p2left.transform.position.x - 0.5f, p2left.transform.position.y, p2left.transform.position.z);
            }
        }

        if (col.gameObject.tag == "Portal3_left")
        {
            //Destroy(gameObject);
            if (rb.velocity.x > 0f)
            {
                //Debug.Log("I am on right side!! so I will emerge from right");
                transform.position = new Vector3(p3right.transform.position.x + 0.5f, p3right.transform.position.y, p3right.transform.position.z);
            }

            if (rb.velocity.x < 0f)
            {
                //Debug.Log("I am on left side!! so I will emerge from left");
                transform.position = new Vector3(p3right.transform.position.x - 0.5f, p3right.transform.position.y, p3right.transform.position.z);
            }
        }

        if (col.gameObject.tag == "Portal3_right")
        {
            //Destroy(gameObject);
            if (rb.velocity.x > 0f)
            {
                //Debug.Log("I am on right side!! so I will emerge from right");
                transform.position = new Vector3(p3left.transform.position.x + 0.5f, p3left.transform.position.y, p3left.transform.position.z);
            }

            if (rb.velocity.x < 0f)
            {
                //Debug.Log("I am on left side!! so I will emerge from left");
                transform.position = new Vector3(p3left.transform.position.x - 0.5f, p3left.transform.position.y, p3left.transform.position.z);
            }
        }

        if (col.gameObject.tag == "Portal4_left")
        {
            //Destroy(gameObject);
            if (rb.velocity.x > 0f)
            {
                //Debug.Log("I am on right side!! so I will emerge from right");
                transform.position = new Vector3(p4right.transform.position.x + 0.5f, p4right.transform.position.y, p4right.transform.position.z);
            }

            if (rb.velocity.x < 0f)
            {
                //Debug.Log("I am on left side!! so I will emerge from left");
                transform.position = new Vector3(p4right.transform.position.x - 0.5f, p4right.transform.position.y, p4right.transform.position.z);
            }
        }

        if (col.gameObject.tag == "Portal4_right")
        {
            //Destroy(gameObject);
            if (rb.velocity.x > 0f)
            {
                //Debug.Log("I am on right side!! so I will emerge from right");
                transform.position = new Vector3(p4left.transform.position.x + 0.5f, p4left.transform.position.y, p4left.transform.position.z);
            }

            if (rb.velocity.x < 0f)
            {
                //Debug.Log("I am on left side!! so I will emerge from left");
                transform.position = new Vector3(p4left.transform.position.x - 0.5f, p4left.transform.position.y, p4left.transform.position.z);
            }
        }

        //if(col.gameObject.tag == "Ground")
        //{
            //rb.bodyType = RigidbodyType2D.Static;
        //}

        //if (col.gameObject.tag == "Enemy")
        //{
            //Enemies = GameObject.FindGameObjectsWithTag("Enemy");
            //if (Enemies.Length == 0)
            //{
            //    SceneManager.LoadScene(sceneName);
            //}
            //enemies -= 1;
            //if (enemies == 0)
            //{
            //    Debug.Log(enemies);
            //    SceneManager.LoadScene(sceneName); // Load the scene with name "OtherSceneName"
            //}
        //}


    }
}
