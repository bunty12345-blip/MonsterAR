using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public GameObject particleExplosion;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        triggerExplosionEffects();
    }

   /* private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        triggerExplosionEffects();

    }*/

    private void triggerExplosionEffects()
    {
        GameObject sparkles = Instantiate(particleExplosion, transform.position, transform.rotation);
        Destroy(sparkles, 4);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
