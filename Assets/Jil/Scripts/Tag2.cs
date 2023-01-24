using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tag2 : MonoBehaviour
{
    private float delayBeforeLoading = 6f;
    private float timeElapsed;
    public GameObject FadeScreen;

  
    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if(timeElapsed > delayBeforeLoading)
        {
          FadeScreen.GetComponent<Animator>().Play("FadeOut");

            StartCoroutine(Starten());
        }

        


    }

    IEnumerator Starten()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(3);
    }
}
