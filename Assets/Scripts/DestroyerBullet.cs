using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class DestroyerBullet : MonoBehaviour
{
    public float moveSpeed = 7f;
    public Rigidbody2D rb;
    //public Player target;
    public Transform finale;
    private Vector2 moveDirection;
    public GameObject portal1_left;
    public GameObject portal1_right;
    public GameObject portal2_left;
    public GameObject portal2_right;
    public GameObject portal3_left;
    public GameObject portal3_right;
    public GameObject portal4_left;
    public GameObject portal4_right;
    private int a;
    private int b = 1;
    public float angela;

    public static DestroyerBullet db;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<SpriteRenderer>().color = Color.black;
        //Debug.Log("I am MJ");
        a = Random.Range(1, 9);
        Debug.Log(a);
        rb = GetComponent<Rigidbody2D>();
        portal1_left = GameObject.FindGameObjectWithTag("Portal1_left");
        portal1_right = GameObject.FindGameObjectWithTag("Portal1_right");
        portal2_left = GameObject.FindGameObjectWithTag("Portal2_left");
        portal2_right = GameObject.FindGameObjectWithTag("Portal2_right");
        portal3_left = GameObject.FindGameObjectWithTag("Portal3_left");
        portal3_right = GameObject.FindGameObjectWithTag("Portal3_right");
        portal4_left = GameObject.FindGameObjectWithTag("Portal4_left");
        portal4_right = GameObject.FindGameObjectWithTag("Portal4_right");
        //if ((a == 0) && Input.GetMouseButtonDown(0))
        //{
        //    a = 1;
        //}
        if ((a == 1) && (-24.37f <= portal1_left.gameObject.transform.position.x) &&(portal1_left.gameObject.transform.position.x <= 24.24f) && 
            (-12f <= portal1_left.gameObject.transform.position.y) &&(portal1_left.gameObject.transform.position.y <= 12.07f))  //GameObject.Find("Portal-1_left") != null)
        {
            b = 0;
            //a = 1;
            moveDirection = (portal1_left.gameObject.transform.position - transform.position).normalized * moveSpeed;
        }

        else if ((a == 2) && (-24.37f <= portal1_right.gameObject.transform.position.x) && (portal1_right.gameObject.transform.position.x <= 24.24f) && 
            (-12f <= portal1_right.gameObject.transform.position.y) && (portal1_right.gameObject.transform.position.y <= 12.07f))
        {
            b = 0;
            //a = 2;
            moveDirection = (portal1_right.gameObject.transform.position - transform.position).normalized * moveSpeed;
        }

        else if ((a == 3) && (-24.37f <= portal2_left.gameObject.transform.position.x) && (portal2_left.gameObject.transform.position.x <= 24.24f) && 
            (-12f <= portal2_left.gameObject.transform.position.y) && (portal2_left.gameObject.transform.position.y <= 12.07f))
        {
            b = 0;
            //a = 3;
            moveDirection = (portal2_left.gameObject.transform.position - transform.position).normalized * moveSpeed;
        }

        else if ((a == 4) && (-24.37f <= portal2_right.gameObject.transform.position.x) && (portal2_right.gameObject.transform.position.x <= 24.24f) && 
            (-12f <= portal2_right.gameObject.transform.position.y) && (portal2_right.gameObject.transform.position.y <= 12.07f))
        {
            b = 0;
            //a = 4;
            moveDirection = (portal2_right.gameObject.transform.position - transform.position).normalized * moveSpeed;
        }

        else if ((a == 5) && (-24.37f <= portal3_left.gameObject.transform.position.x) && (portal3_left.gameObject.transform.position.x <= 24.24f) && 
            (-12f <= portal3_left.gameObject.transform.position.y) && (portal3_left.gameObject.transform.position.y <= 12.07f))
        {
            b = 0;
            //a = 5;
            moveDirection = (portal3_left.gameObject.transform.position - transform.position).normalized * moveSpeed;
        }

        else if ((a == 6) && (-24.37f <= portal3_right.gameObject.transform.position.x) && (portal3_right.gameObject.transform.position.x <= 24.24f) && 
            (-12f <= portal3_right.gameObject.transform.position.y) && (portal3_right.gameObject.transform.position.y <= 12.07f))
        {
            b = 0;
            // a = 6;
            moveDirection = (portal3_right.gameObject.transform.position - transform.position).normalized * moveSpeed;
        }

        else if ((a == 7) && (-24.37f <= portal4_left.gameObject.transform.position.x) && (portal4_left.gameObject.transform.position.x <= 24.24f) && 
            (-12f <= portal4_left.gameObject.transform.position.y) && (portal4_left.gameObject.transform.position.y <= 12.07f))
        {
            b = 0;
            //a = 7;
            moveDirection = (portal4_left.gameObject.transform.position - transform.position).normalized * moveSpeed;
        }

        else if ((a == 8) && (-24.37f <= portal4_right.gameObject.transform.position.x) && (portal4_right.gameObject.transform.position.x <= 24.24f) && 
            (-12f <= portal4_right.gameObject.transform.position.y) && (portal4_right.gameObject.transform.position.y <= 12.07f))
        {
            b = 0;
            //a = 0;
            moveDirection = (portal4_right.gameObject.transform.position - transform.position).normalized * moveSpeed;
        }

        //if (b == 1) ;
        //{
        //    transform.position = new Vector3(finale.transform.position.x, finale.transform.position.y, finale.transform.position.z);
        //}
        //moveDirection = (portal1_left.gameObject.transform.position - transform.position).normalized * moveSpeed;

        else
        {
            transform.position = new Vector3(finale.transform.position.x, finale.transform.position.y, finale.transform.position.z);
        }
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        angela = angle;
        Destroy(gameObject, 60f);
    }

    // Update is called once per frame
    void Update()
    {
        //moveDirection = (portal1_left.gameObject.transform.position - transform.position).normalized * moveSpeed;
        //rb.velocity = new Vector2(moveDirection.x, moveDirection.y);

        //angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Portal1_left" || col.gameObject.tag == "Portal1_right" || col.gameObject.tag == "Portal2_left" || col.gameObject.tag == "Portal2_right" || col.gameObject.tag == "Portal3_left" || col.gameObject.tag == "Portal3_right"  || col.gameObject.tag == "Portal4_left" || col.gameObject.tag == "Portal4_right")
        {
            //Destroy(col.gameObject);
            Destroy(gameObject);
        }


       // if (col.gameObject.tag == "DHelper")
       // {
       //     GetComponent<SpriteRenderer>().color = Color.white;
       //     Debug.Log("Iam whitey");
       // }
    }


}
