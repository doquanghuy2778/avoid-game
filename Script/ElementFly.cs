using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementFly : MonoBehaviour
{
    [SerializeField] private float timeCheck = 0;
    private void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
        //GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    private void Update()
    {
        //Debug.Log(Time.time);
        if(Time.time > timeCheck)
        {
            GetComponent<Rigidbody>().useGravity = true;
            //GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
