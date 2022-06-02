using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class Enemy_Shooter : MonoBehaviour
{
    [SerializeField]
    //public GameObject[] enemies;
    public GameObject bullet;
    public Transform ultimatum;
    private Collider2D coll;
    private Animator anim;
    private AudioSource death;
    public float xadjust;
    public float yadjust;
    private int a = 0;
    //[SerializeField] private string sceneName;
    //[SerializeField] public int enemies;

    float fireRate;
    float nextFire;

    void Start()
    {
        fireRate = 1f;
        nextFire = Time.time;
        coll = GetComponent<Collider2D>();
        anim = GetComponent<Animator>();
        death = GetComponent<AudioSource>();

    }

    void Update()
    {
        CheckIfTimetoFire();
        //Debug.Log(enemies);

        //enemies = GameObject.FindGameObjectsWithTag("Enemy"); // Checks if enemies are available with tag "Enemy". Note that you should set this to your enemies in the inspector.
        //Debug.Log(enemies.Length);
        //if (enemies == 0)
        //{
        //    Debug.Log("Yo");
        //    SceneManager.LoadScene(sceneName); // Load the scene with name "OtherSceneName"
        //}
    }

    void CheckIfTimetoFire()
    {
        if(Time.time > nextFire)
        {
                Vector3 position = new Vector3(transform.position.x + xadjust, transform.position.y + yadjust, transform.position.z);
                Instantiate(bullet, position, Quaternion.identity);
                nextFire = Time.time + fireRate;
            //Vector3 position = new Vector3(transform.position.x + xadjust, transform.position.y + yadjust, transform.position.z);
            //Instantiate(bullet, position, Quaternion.identity);
            //nextFire = Time.time + fireRate;
        }
    }

    private IEnumerator waiter()
    {
        //anim.SetTrigger("Death");
        yield return new WaitForSeconds(0.3f);

        transform.position = new Vector3(ultimatum.transform.position.x, ultimatum.position.y, ultimatum.position.z);
    }

        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "Bullet1" || collision.gameObject.tag == "Bullet2")
        {
            //enemies -= 1;
            //Debug.Log(enemies);
            //if (enemies == 0)
            //{
            //    anim.SetTrigger("Death");
            //    death.Play();
                //waiter();
            //    SceneManager.LoadScene(sceneName); // Load the scene with name "OtherSceneName"
            //}


            //Debug.Log("Bullet has touched me!!!");
            anim.SetTrigger("Death");
            //StartCoroutine(waiter());
            //Debug.Log("Animation should be running!!");
            death.Play();
            StartCoroutine(waiter());
            //transform.position = new Vector3(ultimatum.transform.position.x, ultimatum.position.y, ultimatum.position.z);
        }
    }
}
