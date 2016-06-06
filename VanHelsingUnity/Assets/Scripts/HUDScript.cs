using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HUDScript : MonoBehaviour {

    //health
    public int startingHealth = 100;
    public int health;
    public Slider healthSlider;

    //ammo
    //public int startingAmmo = 6;
    //public int ammo;
    //public float fire = 0.0f;
    //public int wait = 1;
    //public int reload = 3;
    public Slider ammoSlider;
    ShootScript ammoCount;

    //inventory
    public bool cross = false;
    public bool water = false;
    public bool wafers = false;
    public Slider inventorySlider;

    public int obelisk = 3;

    // Use this for initialization
    void Start () {
        health = startingHealth;
        //ammo = startingAmmo;
	}
	
	// Update is called once per frame
	void Update () {
        //fire += Time.deltaTime;

        if (Input.GetKeyDown("h"))
        {
            hurt(10);
        }

        //if (fire >= wait)
        //{
        //    if (Input.GetMouseButtonDown(0))
        //    {
        //        fire = 0;
        //        shoot(1);
        //    }
        //}
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
    //public void shoot(int bullets)
    //{
    //    ammo -= bullets;   
    //    //ammoSlider.value = ammo;
    //    if (ammo <= 0)
    //    {
    //        fire = 0.0f;

    //        if (fire >= reload)
    //        {
    //            //reload
    //            ammo = 6;
    //        }
    //    }
    //}

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

        if (other.gameObject.CompareTag("Obelisk"))
        {
            //other.gameObject.SetActive(false);
            obelisk -= 1;
        }
    }
}
