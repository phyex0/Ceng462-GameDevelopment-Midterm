using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private float characterSpeed = 5.0f;

    private Rigidbody2D characterRb;
    private Animator animator;
    private SpriteRenderer characterSr;
    [SerializeField] GameObject daggerPrefab;

    private float horizontalMoveDirection = 0f;
    private float verticalMoveDirection = 0f;
    private float daggerXOffset = 1.45f;
    private float daggerYOffset = 0.42f;


    private void Awake()
    {
        characterRb = GetComponent<Rigidbody2D>(); //caching
        characterSr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S))
        {
            if(Input.GetKey(KeyCode.D))
            {
                horizontalMoveDirection = 1;
                characterSr.flipX = false;
                animator.SetBool("isRun", true);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                horizontalMoveDirection = -1;
                characterSr.flipX = true;
                animator.SetBool("isRun", true);
            }
            else if (Input.GetKey(KeyCode.W))
            {
                verticalMoveDirection = 1;
                characterSr.flipX = true;
                animator.SetBool("isRun", true);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                verticalMoveDirection = -1;
                characterSr.flipX = true;
                animator.SetBool("isRun", true);
            }
            else
            {
                animator.SetBool("isRun", true);
            }
        }
        else
        {
            horizontalMoveDirection = 0f;
            verticalMoveDirection = 0f;
            animator.SetBool("isRun", false);
        }

        if (Input.GetKeyDown(KeyCode.Space) ){
            animator.SetTrigger("Throw");
            StartCoroutine(playAnimation());
                  
        }
    }

    public IEnumerator playAnimation()
    {
        yield return new WaitForSeconds(1f);

        if(characterSr.flipX == true)
        {
           Instantiate(daggerPrefab, new Vector3(transform.position.x - daggerXOffset, transform.position.y - daggerYOffset, 0), Quaternion.Inverse(daggerPrefab.transform.rotation));
        }
        else
        {
            Instantiate(daggerPrefab, new Vector3(transform.position.x + daggerXOffset, transform.position.y - daggerYOffset, 0), daggerPrefab.transform.rotation);
        }
        
    }

    private void FixedUpdate()
    {
        characterRb.velocity = new Vector2(characterSpeed * horizontalMoveDirection, characterRb.velocity.y);
        characterRb.velocity = new Vector2(characterRb.velocity.x, characterSpeed * verticalMoveDirection);
    }
}
