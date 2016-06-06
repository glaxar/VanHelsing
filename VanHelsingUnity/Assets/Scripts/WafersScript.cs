using UnityEngine;
using System.Collections;

public class WafersScript : MonoBehaviour {
    public Transform wafersTilt;
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
            Instantiate(wafersTilt, new Vector3((float)433.19, (float)9.18, (float)430.9373), Quaternion.Euler(0, 0, 0));
        }
    }
}
