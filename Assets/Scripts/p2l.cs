using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2l : MonoBehaviour
{
    private Animator anim;
    private AudioSource death;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        death = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator waiter()
    {
        //anim.SetTrigger("Death");
        yield return new WaitForSeconds(0.3f);
        transform.position = new Vector3(-1160f, -287f, 0);
        anim.SetTrigger("Idle");
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bullet3")
        {
            anim.SetTrigger("Death");
            death.Play();
            StartCoroutine(waiter());
            //transform.position = new Vector3(-1160f, -287f, 0);
        }
    }
}
