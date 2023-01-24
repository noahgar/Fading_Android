using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tag3 : MonoBehaviour
{
   // private float delayBeforeLoading = 6f;
   // private float timeElapsed;
    public GameObject FadeScreen;
    public AudioSource Knubbel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hand")
        {
            FadeScreen.GetComponent<Animator>().Play("FadeOut");
            StartCoroutine(Starten());
            Knubbel.Play();
            Debug.Log("Tag1");
        }
    }
    // Update is called once per frame
    void Update()
    {
       // timeElapsed += Time.deltaTime;
        //if(timeElapsed > delayBeforeLoading)
        {
          //FadeScreen.GetComponent<Animator>().Play("FadeOut");

           // StartCoroutine(Starten());
        }

        


    }

    IEnumerator Starten()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(3);
    }
}
