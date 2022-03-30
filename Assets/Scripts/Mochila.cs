using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Mochila : MonoBehaviour
{

    Vector3 originalPos;
    public GameObject player;
    public GameObject inventario;

    // public bool mochila=false;
    // Start is called before the first frame update

    
    void Update(){

        transform.position= new Vector3(player.transform.position.x+0.5f, player.transform.position.y+1, player.transform.position.z+0.2f);
        // transform.Rotate(0,0,0);
        transform.rotation = Quaternion.Euler(0, 0, 0);
    
    }
   

    void OnAttachedToHand(Hand hand)

    {

        inventario.SetActive(true);

        Debug.Log("Mão pegou o objeto");
        // inventario.SetActive(true);

    }

   
    void OnDetachedFromHand(Hand hand){

        transform.position= new Vector3(player.transform.position.x+1, player.transform.position.y+1, player.transform.position.z+1);
        // transform.Rotate(0,0,0);
        transform.rotation = Quaternion.Euler(0, 0, 0);
        




        Debug.Log("Mão soltou o objeto");


    }
}
