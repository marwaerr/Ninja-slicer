using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
   
{
    Rigidbody2D rb;
     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up*100f);
    }
    //[SerializeField] private Transform pasteque;
    public GameObject xpasteque;
    
    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.tag == "Blade")
        {
            Instantiate(xpasteque,transform.position,Quaternion.identity);
            Destroy (gameObject);
            Scoremanager.instance.AddPoint();
            SoundManager.PlaySound("slicingSound");
           

        }
    }
}
