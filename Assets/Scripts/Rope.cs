using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hand_a;
    void Start()
    {
        
    }

    void Update(){

        transform.position= new Vector3(hand_a.transform.position.x-0.65f, hand_a.transform.position.y-102, hand_a.transform.position.z);
        // transform.rotation = Quaternion.Euler(0, 0, 0);
    
    }
}
