using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour
{
    public AudioSource Closed;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    
    
    {
        if (other.tag=="Drawer")
        {
        Closed.GetComponent<AudioSource>().Play();
            Debug.Log("Rüttel");
        }
        
    }
}
