using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishAI : MonoBehaviour
{
    [HideInInspector]
    public bool mustPatrol;

    public Rigidbody2D rb;
    public float walkSpeed;
    public static int totalFish = 0;

    private void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        mustPatrol = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(mustPatrol)
        {
            Patrol();
        }
    }

    void Patrol()
    {
        rb.velocity = new Vector2(walkSpeed * Time.fixedDeltaTime, rb.velocity.y);
    }

    void Flip()
    {
        mustPatrol = false;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        walkSpeed *= -1;
        mustPatrol = true;
    }

    void OnTriggerEnter2D(Collider2D f2d)
    {
        if(f2d.CompareTag("Player"))
        {
            totalFish++;
            Debug.Log("You currently have " + FishAI.totalFish + "fish.");
            Destroy(gameObject);
        }
    }
}
