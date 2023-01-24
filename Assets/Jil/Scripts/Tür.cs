using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Tür : MonoBehaviour
{

    public TelepBack TeleScript;



    private bool coll;
    public GameObject Platte;
    public GameObject FadeScreen;
    Collider Door;

    void Start()
    {
        //nimm am Anfang den Door Collider und setze ihn auf false
        Door = GetComponent<Collider>();
        Door.enabled = false;
    }


    void Update()
    {
        //Ich greife oben auf mein TelepBack Script zu um den bool "klopfen" abzufragen, wenn klopfen true ist dann 
        //gib der Tür den Collider wieder 
        if (TeleScript.klopfen == true)
        {
            Door.enabled = true;
            coll = true;
        }



        //wenn der winkel großer als 0 ist und kleiner als 315 dann starte FadeinWhite

        if (transform.eulerAngles.y > 0 && transform.eulerAngles.y < 315)

        {
            Debug.Log("ENDE");
            StartCoroutine(FadeinWhite());


        }

        
    }
    //FadeScreen ToWhite wird nach 1 Sekunde aktiviert, Platte wird leiser 
    IEnumerator FadeinWhite()
    {
        yield return new WaitForSeconds(1);
        FadeScreen.GetComponent<Animator>().Play("ToWhite");
        Platte.GetComponent<AudioSource>().volume = 0.056f;
        StartCoroutine(TAG2());
    }

    IEnumerator TAG2()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(2);
        FadeScreen.GetComponent<Animator>().Play("FadeIn");
    }
}
