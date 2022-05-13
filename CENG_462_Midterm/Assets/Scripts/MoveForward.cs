using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this class is written for items movement that throw from either boss or player
public class MoveForward : MonoBehaviour
{
    [SerializeField]   private float speed = 15.0f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
