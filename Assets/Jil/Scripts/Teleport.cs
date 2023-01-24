using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Teleport : MonoBehaviour
{
    [SerializeField]
    public bool isteleported;

    public GameObject FadeScreen;
    public GameObject SceneStart;
    public GameObject Player;
    public GameObject Void;
   




    private void Start()
    {
        isteleported = false;
        

    }
    private void OnTriggerEnter(Collider other)
    {
        
     if(other.tag == "Hand")
        {

            Debug.Log("Test");
            Void.SetActive(true);
            FadeScreen.GetComponent<Animator>().Play("FadeOut");
            StartCoroutine(Fade());
           



        }


        IEnumerator Fade()
        { 
            yield return new WaitForSeconds(2);
           
            Player.transform.position = new Vector3(-61.992f, 5.353f, -627.943f);
            isteleported = true;
            FadeScreen.GetComponent<Animator>().Play("FadeIn");
            SceneStart.GetComponent<PlayableDirector>().Play();
           
        }



    }
}
