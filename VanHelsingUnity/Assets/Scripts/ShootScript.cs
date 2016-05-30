using UnityEngine;
using System.Collections;



public class ShootScript : MonoBehaviour
{

    public Rigidbody bullet;
    public float speed = 15;
    public float fireRate = 1.0f;
    public float fireTime = 0.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > fireTime)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Rigidbody shotBullet = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
                shotBullet.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            }

            fireTime = Time.time + fireRate;
        }

    }
}
