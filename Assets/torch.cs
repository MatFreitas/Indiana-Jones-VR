using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torch : MonoBehaviour
{

    public GameObject hand_a;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position= new Vector3(hand_a.transform.position.x, hand_a.transform.position.y+0.2f, hand_a.transform.position.z);
        
    }
}
