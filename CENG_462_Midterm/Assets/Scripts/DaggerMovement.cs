using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaggerMovement : MonoBehaviour
{
    private float speed = 15.0f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }
}
