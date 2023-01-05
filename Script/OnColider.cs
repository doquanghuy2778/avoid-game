using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OnColider : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("va cham");
        //khi va cham se chuyen sang mau xanh
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
        }
    }
}