using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveCtl : MonoBehaviour
{
    [SerializeField] private float speed;
    int hits = 0;
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        Move();      
    }

    private void Move()
    {
        float MoveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime * -1;
        float MoveZ = Input.GetAxis("Vertical") * speed * Time.deltaTime * -1;
        transform.Translate(MoveX, 0, MoveZ);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("Ban da va cham lan thu: " + hits);
        }
        if(hits == 5)
        {
            Death();
        }
    }
    private void Death()
    {

    }
}