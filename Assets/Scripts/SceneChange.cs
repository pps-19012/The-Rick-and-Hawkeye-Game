using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [SerializeField] private int p;
    [SerializeField] private int q;
    private Collider2D coll;
    [SerializeField] private string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(p);
        if (p == q)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            //Destroy(this.gameObject);
            Debug.Log("I am fine");
            p += 1;
            Destroy(collision.gameObject);
            //Debug.Log(p);

            //if(initial == final)
            //{
            //    SceneManager.LoadScene(sceneName);
            //}
        }
    }
}
