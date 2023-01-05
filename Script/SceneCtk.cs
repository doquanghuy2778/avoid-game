using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCtk : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TakePlay());
    }

    IEnumerator TakePlay()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(2);
    }
   
}
