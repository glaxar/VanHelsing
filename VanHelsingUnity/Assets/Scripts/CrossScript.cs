using UnityEngine;
using System.Collections;

public class CrossScript : MonoBehaviour {
    public Transform crossTilt;
    public bool placed = false;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && placed == false)
        {
            placed = true;
            Instantiate(crossTilt, new Vector3((float)455.9621, (float)5.999642, (float)192.3723), Quaternion.Euler((float)18.8912, (float)44.0709, 0));
        }
    }
}
