using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelepBack : MonoBehaviour
{
    [SerializeField]
    public bool isteleported;

    

    public GameObject FadeScreen;
    public GameObject Player;
    public GameObject Void;
    public GameObject Wolke;
    public GameObject Papierschreibmaschine;
    public GameObject Papier;
    public AudioSource Sound;
    public GameObject Tür;
    public GameObject FakeTür;
    public AudioSource OneSec;
    
   
    public bool klopfen;
    public float delay = 2;

    //Papier wird in die Schreibmaschine gesteckt, Teleport Back , Void nichtmehr aktiv, Szene wird gefaded
    // Schreibmaschinen Sound wird abgespielt Coroutine wird gestartet

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Papiervoid" )
        {
            Debug.Log("Back");
            Void.SetActive(false);
            FadeScreen.GetComponent<Animator>().Play("FadeOut");
            Sound.Play();
            Tür.SetActive(true);
            StartCoroutine(Fade());
            
        }
    }
    // nach 2 Sekunden: Player wird teleportiert, bool auf false, FadeIN, Wolke nicht aktiv, Papier ist Aktiv Nächste Routine wird gestartet
    IEnumerator Fade()
    {
        yield return new WaitForSeconds(2);

        Player.transform.position = new Vector3(-3.182f, 0f, -0.03f);
        isteleported = false;
        FadeScreen.GetComponent<Animator>().Play("FadeIn");
        Wolke.SetActive(false);
        Papierschreibmaschine.SetActive(true);
        Papier.SetActive(false);
        StartCoroutine(Door());
        
        FakeTür.SetActive(false);

    }
    //nach 5 Sekunden klopft es klopfen wird auf true gesetzt 
   IEnumerator Door()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("Tür");
        Tür.GetComponent<AudioSource>().Play();
        klopfen = true;
        OneSec.GetComponent<AudioSource>().PlayDelayed(delay);




    }
      
}
