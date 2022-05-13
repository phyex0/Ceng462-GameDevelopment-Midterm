using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    private Rigidbody2D bossRb;
    private bool topWall = true;
    private bool downWall = false;

    

    // Start is called before the first frame update
    void Start()
    {
        bossRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void FixedUpdate()
    {
        if (topWall)
        {
            bossRb.velocity = new Vector2(0f, 3f);
        }
        else if (downWall)
        {
            bossRb.velocity = new Vector2(0f, -3f);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("TopWall"))
        {
            topWall = false;
            downWall = true;
        }
        else if (collision.gameObject.CompareTag("DownWall"))
        {
            downWall = false; ;
            topWall = true;
        }
    }


}
