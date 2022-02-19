using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this Script is attached to TriggerPlane

public class BallBounce : MonoBehaviour
{
    //VARIABLES
    public GameObject Player;
    Rigidbody playerRb;
    bool isTrigger=false;

    //REFERENCES

    // Start is called before the first frame update
    void Start()
    {
        playerRb = Player.GetComponent<Rigidbody>();

    }

    private void Update()
    {
        if (Player.transform.position.y >= 5.0f && isTrigger == true)
        {
            playerRb.isKinematic = true;
           Player.transform.position= new Vector3(Player.transform.position.x, 4.9f, Player.transform.position.z);
            //Debug.Log("kinematic");
            isTrigger = false;
           
        }
    }
    // Update is called once per frame   

    private void OnTriggerEnter(Collider collider)
    {
         if(collider.gameObject.CompareTag("Tiles"))
        {
            playerRb.isKinematic = false;
            playerRb.AddForce(Vector3.down * GameManager.Instance.downforce);
            isTrigger = true;
            Debug.Log("nn");
        }
   
    }

   
}
