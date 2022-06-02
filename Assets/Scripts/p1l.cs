using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1l : MonoBehaviour
{ 
    //public Transform finale;
    private Animator anim;
    private AudioSource death;
    private int a = 1;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        death = GetComponent<AudioSource>();
        //private Collider2D coll;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator waiter()
    {
        //anim.SetTrigger("Death");
        yield return new WaitForSeconds(0.3f);

        transform.position = new Vector3(-300f, -431f, 0);
        anim.SetTrigger("Idle");
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Bullet3")
        {
            if (a == 1)
            {
                anim.SetTrigger("Death");
                death.Play();
                StartCoroutine(waiter());
                //transform.position = new Vector3(-300f, -431f, 0);
            }
        }
    }
}
