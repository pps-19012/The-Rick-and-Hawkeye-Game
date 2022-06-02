using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private string sceneName;
    public int maxHealth = 30;
    public int currentHealth;
    public int damage = 1;
    public int damage1 = 2;
    public int damage2 = 4;
    public HealthBar healthbar;
    public TimeManager timeManager;
    private Collider2D coll;
    private Animator anim;
    private AudioSource death;
    public float position;

    private enum State{right, left}
    private State state = State.right;

    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
        coll = GetComponent<Collider2D>();
        anim = GetComponent<Animator>();
        death = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            timeManager.DoSlowmotion();
        }

        Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);

        if(worldPoint.x > position)
        {
            state = State.right;
        }

        if (worldPoint.x < position)
        {
            state = State.left;
        }

        anim.SetInteger("state", (int)state);
        //Debug.Log(currentHealth);

        //if (Input.GetKeyUp(KeyCode.X))
        //{
        //    timeManager.Update();
        //}
    }

    private IEnumerator waiter()
    {
        //anim.SetTrigger("Death");
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
        SceneManager.LoadScene(sceneName);

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (currentHealth <= 0)
        {
            anim.SetTrigger("Death");
            death.Play();
            StartCoroutine(waiter());
            //Destroy(gameObject, 1f);
            //SceneManager.LoadScene(sceneName);
        }

        if (col.gameObject.tag == "Bullet" && currentHealth >0)
        {
            currentHealth -= damage;
            healthbar.SetHealth(currentHealth);
        }

        if (col.gameObject.tag == "Bullet1" && currentHealth > 0)
        {
            currentHealth -= damage1;
            healthbar.SetHealth(currentHealth);
        }

        if (col.gameObject.tag == "Bullet2" && currentHealth > 0)
        {
            currentHealth -= damage2;
            healthbar.SetHealth(currentHealth);
        }


    }

}
