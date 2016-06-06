using UnityEngine;
using System.Collections;

public class CrabScript : MonoBehaviour {
    //health
    public int enemyHealth = 100;
    public int Health;
    public int damage = 10;
    public bool attack = false;
    public float timer = 0.0f;
    public float waitTime = 1.0f;
    Transform player;
    NavMeshAgent nav;
    CapsuleCollider capsuleCollider;
    HUDScript playerHealth;

	// Use this for initialization
	void Start () {
        Health = enemyHealth;
        capsuleCollider = GetComponent<CapsuleCollider>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            attack = true;
        }

        if (other.gameObject.tag == "bullet")
        {
            Hurt(10);
            Destroy(other.gameObject);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            attack = false;
        }
    }

    // Update is called once per frame
    void Update () {
        timer += Time.deltaTime;

        if (Health > 0)
            {
                if (attack == true)
                {
                    if (timer >= waitTime)
                    {
                        timer = 0;

                        if (playerHealth.health > 0)
                        {
                            playerHealth.hurt(damage);
                        }
                    }
                }else
                {
                    nav.SetDestination(player.position);
                }
            }
	}

    public void Hurt(int amount)
    {
        Health -= amount;

        if (Health <= 0)
        {
            Destroy(gameObject);
            //capsuleCollider.isTrigger = true;
            //GetComponent<NavMeshAgent>().enabled = false;
            
        }
    }
}

