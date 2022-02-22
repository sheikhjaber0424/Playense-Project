using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject effectObject;

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Instantiate(effectObject, transform.position, effectObject.transform.rotation);
            effectObject.SetActive(true);
            ParticleSystem pr = effectObject.GetComponent<ParticleSystem>();
            pr.Play();
        }
    }*/
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            //Instantiate(effectObject, transform.position, effectObject.transform.rotation);
            effectObject.SetActive(true);
            ParticleSystem pr = effectObject.GetComponent<ParticleSystem>();
            pr.Play();
        }
    }
}