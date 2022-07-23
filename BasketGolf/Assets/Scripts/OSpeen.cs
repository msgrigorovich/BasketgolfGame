using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OSpeen : MonoBehaviour
{

    public float speed;
    void Update()
    {
        transform.Rotate(0.0f, 0.0f, speed);
    }
}
