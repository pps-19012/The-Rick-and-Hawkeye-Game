using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Impact : MonoBehaviour
{
    public Transform arrow;
    public Transform finale;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void Hurt()
    {
        if (arrow.transform.position.x == -8.74f)
        {
            Debug.Log("I am Hurt");
            transform.position = new Vector3(0,0,0);
            Show();
        }
    }
            
    private IEnumerator Show()
    {
        yield return new WaitForSeconds(0.5f);
        transform.position = new Vector3(finale.transform.position.x, finale.transform.position.y, finale.transform.position.z);

    }
}
