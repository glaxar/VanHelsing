using UnityEngine;
using System.Collections;

public class CrabTurretScript : MonoBehaviour {

    //health
    //Random random = new Random();
    //public int startingHealth = random.Next(85, 116);
    public int startingHealth = 100;
    public int health;
    //public Slider healthSlider;
    // Use this for initialization
    void Start () {
        health = startingHealth;
	}
	
	// Update is called once per frame
	void Update () {
        //if (OnCollisionStay(Collision collision))
        //{

        //}
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet")
        {
            hurt(10);
            Destroy(other.gameObject);
        }
    }

    public void hurt(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
