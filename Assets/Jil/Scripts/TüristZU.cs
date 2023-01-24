using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TüristZU : MonoBehaviour
{

    public TelepBack TeleScript;
    // Start is called before the first frame update

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)

    {
        // wenn klopfen nicht auf true gesetzt wurde durch den Teleportback und der trigger ein hand tag besitzt dann 
        // spiel die scheiße ab
        if (TeleScript.klopfen == false && other.tag == "Hand")
        {
            GetComponent<AudioSource>().Play();
            Debug.Log("Klinge");
        }

        else
        {
            Debug.Log("help");
        }




    }
}
