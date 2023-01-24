using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zurück : MonoBehaviour
{
    public FadeScreen fadeScreen;



    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hand");
        StartCoroutine(GoToScene());

    }

    IEnumerator GoToScene()
    {
        fadeScreen.FadeOut();
        AsyncOperation operation = SceneManager.LoadSceneAsync(0);
        operation.allowSceneActivation = false;

        float timer = 0;
        while (timer <= fadeScreen.fadeDuration && !operation.isDone)
        {
            timer += Time.deltaTime;
            yield return null;
        }
        operation.allowSceneActivation = true;
    }
}
