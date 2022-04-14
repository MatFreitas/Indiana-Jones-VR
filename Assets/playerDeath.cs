using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerDeath : MonoBehaviour
{

    public GameObject	player;
    public GameObject	bag;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag=="ball"){

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Destroy(player);
            Destroy(bag);
        }
    }
}
