using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TakeLoading());
    }
    
    IEnumerator TakeLoading() 
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1);
    }
    
}
