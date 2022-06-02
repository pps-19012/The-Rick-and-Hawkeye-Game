using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public AudioSource death;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public int b = 1;

    void Start()
    {
        death = GetComponent<AudioSource>();
    }

    public void Spawn(Vector3 position)
    {
        if (b == 3)
        {
            enemy1.transform.position = position;
            death.Play();
        }
        //Instantiate(enemy1).transform.position = position;

        else if( b==5) { enemy2.transform.position = position;
            death.Play();
        }
        //Instantiate(enemy2).transform.position = position;

        else if (b == 7) { enemy3.transform.position = position;
            death.Play();
        }

        else if (b == 9) { enemy4.transform.position = position;
            death.Play();
        }
    }

    public void Update()
    {
        //left mouse click
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            
            b = b + 2;
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);

            //Make Z position the Z position of the prefab
            if (b == 3)
            {
                Vector3 adjustZ = new Vector3(worldPoint.x, worldPoint.y, enemy1.transform.position.z);
                Spawn(adjustZ);
            }
            //Vector3 adjustZ = new Vector3(worldPoint.x, worldPoint.y, enemy1.transform.position.z);
            else if (b==5)
            {
                Vector3 adjustZ = new Vector3(worldPoint.x, worldPoint.y, enemy2.transform.position.z);
                Spawn(adjustZ);
            }
            else if (b == 7)
            {
                Vector3 adjustZ = new Vector3(worldPoint.x, worldPoint.y, enemy3.transform.position.z);
                Spawn(adjustZ);
            }
            else if (b == 9)
            {
                Vector3 adjustZ = new Vector3(worldPoint.x, worldPoint.y, enemy4.transform.position.z);
                Spawn(adjustZ);
                b = 1;
              
            }

            

            //Spawn(adjustZ);
        }
    }
}

