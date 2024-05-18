using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(LoadLevelByFade());
    }

    IEnumerator LoadLevelByFade()
    {

        yield return new WaitForSeconds(3.6f);

        float fadeTime = GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene(Constants.Local.Scene.Menu);
    }
}
