using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour
{
    public float power = 2000.0F;

    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetMouseButtonDown(0))
        {
            SetExplosion();
        }
	}

    public void SetExplosion()
    {
        float radius = 25.0F;

        Vector3 explosionPos = transform.position;
        //Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        Collider[] colliders = this.gameObject.GetComponentsInChildren<Collider>();
        foreach (Collider col in colliders)
        {
            Rigidbody rb = col.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(power, explosionPos, radius, 3.0F);

        }
    }
}
