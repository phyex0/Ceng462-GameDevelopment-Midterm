using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this class is written for items movement that throw from either boss or player
public class MoveForward : MonoBehaviour
{
    [SerializeField]   private float speed = 15.0f;
    private AudioSource hit;
    

    private void Awake()
    {
        hit = GameObject.Find("Audio Source").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);

        if(collision.gameObject.CompareTag("Blue Virus") || collision.gameObject.CompareTag("Red Virus") || collision.gameObject.CompareTag("Boss"))
        {
            hit.Play();
            Score.totalScore += 10;
        }   
        Destroy(gameObject);      
    }
}
