using UnityEngine;
using System.Collections;

public class WaterScript : MonoBehaviour {
    public Transform waterTilt;
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
            Instantiate(waterTilt, new Vector3((float)158.2635, (float)9.379862, (float)364.0185), Quaternion.Euler((float)1.1538, (float)-50.5252, (float)-113.9632));
        }
    }
}
