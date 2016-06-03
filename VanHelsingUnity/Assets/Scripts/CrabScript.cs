using UnityEngine;
using System.Collections;

public class CrabScript : MonoBehaviour {
    //health
    public int enemyHealth = 100;
    public int health;
    public int damage = 10;
    bool attack = false;
    float timer = 0.0f;
    float waitTime = 1.0f;
    Transform player;
    NavMeshAgent nav;
    CapsuleCollider capsuleCollider;
    HUDScript playerHealth;

	// Use this for initialization
	void Start () {
        health = enemyHealth;
        capsuleCollider = GetComponent<CapsuleCollider>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            attack = true;
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

        if (health > 0)
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
        health -= amount;

        if (health <= 0)
        {
            capsuleCollider.isTrigger = true;
            GetComponent<NavMeshAgent>().enabled = false;
            Destroy(gameObject);
        }
    }
}

