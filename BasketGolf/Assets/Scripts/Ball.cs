using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject ball;

    private void OnMouseDown()
    {
        ball.transform.position = new Vector3(0, 10, 0)*Time.deltaTime;
    }
}
