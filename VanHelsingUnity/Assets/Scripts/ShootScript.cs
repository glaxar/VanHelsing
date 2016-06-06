using UnityEngine;
using System.Collections;



public class ShootScript : MonoBehaviour
{

    public Rigidbody bullet;
    public float speed = 25;
    public int fireRate = 1;
    public float fireTime = 0.0f;
    public int startingAmmo = 6;
    public int ammo;
    public int reload = 3;

    // Use this for initialization
    void Start()
    {
        ammo = startingAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        fireTime += Time.deltaTime;

        if (ammo > 0)
        {
            if (fireTime >= fireRate)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    fireTime = 0;
                    ammo -= 1;
                    Rigidbody shotBullet = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
                    shotBullet.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
                }
            }
        }else
        {
            if (fireTime >= reload)
            {
                ammo = 6;
            }
        }

    }
}
