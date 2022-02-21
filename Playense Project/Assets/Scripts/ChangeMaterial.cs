using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material material;
    //private float timer;
    bool hasChanged = true;
    int index = 0;
   /* Renderer rend;
    private float timer;*/
    // Start is called before the first frame update
    void Start()
    {
        /*rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];*/
        
       
    }

    private void Update()
    {

        Debug.Log(GameManager.Instance.score);

        if (index == 0)
       
        {        
            material.color = Color.blue;
            // rend.sharedMaterial = material[1];
            
           
        }
        else if(index ==1)
        {
            material.color = Color.magenta;

        } 
        else if(index ==2)
        {
            material.color = new Color(0,0,0);

        }
       
        if(hasChanged)
        {
            hasChanged = false;
            StartCoroutine(ColorChange());
        }
    }

    IEnumerator ColorChange()
    {
        yield return new WaitForSeconds(5);
        hasChanged = true;
        index++;
        if(index >2)
        {
            index = 0;
        }
    }



}
