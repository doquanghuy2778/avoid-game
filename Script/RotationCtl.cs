using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCtl : MonoBehaviour
{
    [SerializeField] private float rotateY;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateY, 0);
    }
}
