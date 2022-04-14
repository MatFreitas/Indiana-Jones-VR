using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class inventory : MonoBehaviour
{
    public GameObject whip;
    public GameObject gun;
    public GameObject torch;


    public GameObject invent;   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClicouWhip(){
        print("clicou whip");
        whip.SetActive(true);
        gun.SetActive(false);
        torch.SetActive(false);
        invent.SetActive(false);

        
    }
    public void ClicouGun(){
        print("clicou gun");
        whip.SetActive(false);
        gun.SetActive(true);
        torch.SetActive(false);
        invent.SetActive(false);

    }

    public void ClicouTorch(){
        print("clicou torch");
        whip.SetActive(false);
        gun.SetActive(false);
        torch.SetActive(true);
        invent.SetActive(false);

    }
}
