using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameObject bullet;
    public Transform ultimatum;
    public float xadjust;
    public float yadjust;
    private Animator anim;
    private AudioSource death;
    private Collider2D coll;
    public DestroyerBullet db;

    private enum State { zero, fortyfive, negativefortyfive, seventyfive, negativeseventyfive }
    private State state = State.fortyfive;

    float fireRate;
    float nextFire;

    // Start is called before the first frame update
    void Start()
    {
        db = GetComponent<DestroyerBullet>();
        fireRate = 1f;
        nextFire = Time.time;
        coll = GetComponent<Collider2D>();
        anim = GetComponent<Animator>();
        death = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfTimetoFire();
        //AnimationState();
        if (DestroyerBullet.db.angela == 0)
        {
            state = State.zero;
        }

        else if (DestroyerBullet.db.angela > 0 && DestroyerBullet.db.angela <= 65)
        {
            state = State.fortyfive;
        }

        else if (DestroyerBullet.db.angela > 65 && DestroyerBullet.db.angela <= 90)
        {
            state = State.seventyfive;
        }

        else if (DestroyerBullet.db.angela < 0 && DestroyerBullet.db.angela >= -65)
        {
            state = State.negativefortyfive;
        }

        else if (DestroyerBullet.db.angela < -65 && DestroyerBullet.db.angela >= -90)
        {
            state = State.negativeseventyfive;
        }

        else if (DestroyerBullet.db.angela == 180)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            state = State.zero;
        }
        else if (DestroyerBullet.db.angela < -90 && DestroyerBullet.db.angela >= -115)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            state = State.negativeseventyfive;
        }

        else if (DestroyerBullet.db.angela < -115 && DestroyerBullet.db.angela > -180)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            state = State.negativefortyfive;
        }

        else if (DestroyerBullet.db.angela < 155 && DestroyerBullet.db.angela > 90)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            state = State.fortyfive;
        }

        else if (DestroyerBullet.db.angela < 180 && DestroyerBullet.db.angela >= 155)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            state = State.seventyfive;
        }
    
    anim.SetInteger("state", (int)state);
    }

    void CheckIfTimetoFire()
    {
        if (Time.time > nextFire)
        {
            Vector3 position = new Vector3(transform.position.x + xadjust, transform.position.y + yadjust, transform.position.z);
            Instantiate(bullet, position, Quaternion.identity);
            nextFire = Time.time + fireRate;
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

    private void AnimationState()
    {
        
    }


}
