using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockDeath : MonoBehaviour
{

    AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {


        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Finish"){
             audiosource.Stop();
        }
    }
}
