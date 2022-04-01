using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;



public class touchedSkull : MonoBehaviour
{


    public GameObject bola;
    public GameObject caveira;
    public GameObject caixa;

    // Start is called before the first frame update


    void OnAttachedToHand(Hand hand)

    {



        bola.SetActive(true);
        Destroy(caveira);
        caixa.SetActive(false);

        Debug.Log("Mão pegou a caveira");
        // inventario.SetActive(true);

    }
}
