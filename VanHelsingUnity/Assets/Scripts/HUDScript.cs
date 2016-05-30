using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HUDScript : MonoBehaviour {

    //health
    public int startingHealth = 100;
    public int health;
    public Slider healthSlider;

    //ammo
    public int startingAmmo = 6;
    public int ammo;
    public Slider ammoSlider;

    //inventory
    public bool cross = false;
    public bool water = false;
    public bool wafers = false;
    public Slider inventorySlider;

    // Use this for initialization
    void Start () {
        health = startingHealth;
        ammo = startingAmmo;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("h"))
        {
            hurt(10);
        }
        if (Input.GetMouseButtonDown(0))
        {
            shoot(1);
        }
    }

    public void hurt(int amount)
    {
        health -= amount;
        healthSlider.value = health;
        if (health <= 0)
        {
            //GameOver
        }
    }
    public void shoot(int bullets)
    {
        ammo -= bullets;   
        //ammoSlider.value = ammo;
        if (ammo <= 0)
        {
            //reload
            ammo = 6;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        //Destroy(other.gameObject);
        if (other.gameObject.CompareTag("Cross"))
        {
            other.gameObject.SetActive(false);
            cross = true;
            //GameObject.Find("InvCross").SetActive(true);
        }

        if (other.gameObject.CompareTag("Water"))
        {
            other.gameObject.SetActive(false);
            water = true;
        }

        if (other.gameObject.CompareTag("Wafers"))
        {
            other.gameObject.SetActive(false);
            wafers = true;
        }
    }
}
