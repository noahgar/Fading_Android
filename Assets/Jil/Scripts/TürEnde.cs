using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;



public class TürEnde : MonoBehaviour
{

   



   
    public GameObject Platte;
    public GameObject FadeScreen;
    Collider Door;

    void Start()
    {
        //nimm am Anfang den Door Collider und setze ihn auf false
     
       
    }


    void Update()
    {
     

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
        SceneManager.LoadScene(4);
        FadeScreen.GetComponent<Animator>().Play("FadeIn");
    }
}
