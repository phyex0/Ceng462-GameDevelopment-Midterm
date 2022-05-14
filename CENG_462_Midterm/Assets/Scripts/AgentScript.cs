using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentScript : MonoBehaviour
{

    [SerializeField] Transform target;

    private NavMeshAgent agent;
    private SpriteRenderer agentSr;
    [SerializeField] GameObject daggerPrefab;
    public float _turnSpeed = 3;
    [SerializeField]  private bool isDead = false;
    private Animator animator;


    private float daggerXOffset = 1.7f;
    private float daggerYOffset = 0.42f;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        animator = GetComponent<Animator>();

        agentSr = GetComponent<SpriteRenderer>();
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation =  false;
        agent.updateUpAxis = false;

        StartCoroutine(Attack());

       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        Vector3 lookPos;
        Quaternion targetRot;

        lookPos = target.position - transform.position;

        if (lookPos.x > 0)
        {
            agentSr.flipX = false;
        }
        else if (lookPos.x < 0)
        {
            agentSr.flipX = true;
        }

        agent.SetDestination(target.position);
    }

    public IEnumerator Attack()
    {
        while (isDead == false)
        {
            animator.SetTrigger("isAttack");
            yield return new WaitForSeconds(1f); //time delay in order to perform animation first

            if (agentSr.flipX == true)
            {
                Debug.Log("Buraya kaç kere giriyor");
                Instantiate(daggerPrefab, new Vector3(transform.position.x - daggerXOffset, transform.position.y - daggerYOffset, 0), Quaternion.Inverse(daggerPrefab.transform.rotation));
            }
            else
            {
                Instantiate(daggerPrefab, new Vector3(transform.position.x + daggerXOffset, transform.position.y - daggerYOffset, 0), daggerPrefab.transform.rotation);
            }

            yield return new WaitForSeconds(5f);
        } 
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Throwable"))
        {
            //later
        }
        
    }
}
