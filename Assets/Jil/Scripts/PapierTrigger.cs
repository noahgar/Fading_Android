using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PapierTrigger : MonoBehaviour
{
    public GameObject Wolke;
    public bool isTriggerd;
    public AudioSource Clean;
    public AudioSource Whatsgoingon;
    

    
    public float delay = 300;
    public float delay2 = 5;


    
    void Start()
    {
        isTriggerd = false;
        Clean.PlayDelayed(delay);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Papier"&& isTriggerd == false)
        {
            Wolke.SetActive(true);
            Debug.Log("test");
            isTriggerd = true;
            Whatsgoingon.PlayDelayed(delay2);
        }
    }

    private void Update()
    {
       
        


    }

}
