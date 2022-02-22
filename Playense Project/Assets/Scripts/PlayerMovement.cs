using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Touch touch;
    private float speedModifier;
    private int pointValue = 1;

    public Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        speedModifier = 0.01f;
        playerRb =gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(
                    transform.position.x + touch.deltaPosition.x * speedModifier,
                    transform.position.y,
                    transform.position.z 
                    );
                
            }
        }

    }

    private void OnCollisionEnter(Collision collision)

    {
        if (collision.gameObject.CompareTag("Tiles"))
        {
            
            Debug.Log("jump Up");

            playerRb.AddForce(Vector3.up * GameManager.Instance.upforce);

            GameManager.Instance.UpdateScore(pointValue);
        }
        if (collision.gameObject.CompareTag("Diamond"))
        {
            Destroy(collision.gameObject);
            GameManager.Instance.UpdateScore2(pointValue);
        }


    }


   

}
