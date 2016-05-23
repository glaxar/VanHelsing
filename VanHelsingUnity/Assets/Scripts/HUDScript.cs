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
    bool cross = false;
    bool water = false;
    bool wafer = false;
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
        ammoSlider.value = ammo;
        if (ammo <= 0)
        {
            //reload
            ammo = 6;
        }
    }
}
