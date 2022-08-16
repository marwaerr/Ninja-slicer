using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    public GameObject BladeTrailPrefab;
    public float minCV=.001f;

    bool isCutting = false;
    Vector2 previousPosition;
    Rigidbody2D rb;
    Camera cam;
    CircleCollider2D circleCollider;
    
    GameObject currentbladeTrail ;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;
        circleCollider = GetComponent<CircleCollider2D>();
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            StartCutting();
            

        }
        else if (Input.GetMouseButtonUp(0))
        {
            StopCutting();
        }
        if (isCutting)
        {
            UpdateCut();
        }
    }
    void StartCutting()
    {
        isCutting = true;
        currentbladeTrail = Instantiate(BladeTrailPrefab, transform);
        circleCollider.enabled = false;
        previousPosition = cam.ScreenToWorldPoint(Input.mousePosition);




    }
    void UpdateCut()
    {
        Vector2 newPosition= cam.ScreenToWorldPoint(Input.mousePosition);
        rb.position = newPosition;
        float velocity = (newPosition - previousPosition).magnitude;
        if (velocity > minCV)
        {
            circleCollider.enabled = true;
            
        }else
        {
            circleCollider.enabled = false;
        }
        previousPosition = newPosition;

        

    }
    void StopCutting()
    {
        isCutting = false;
        currentbladeTrail.transform.SetParent(null);
        Destroy(currentbladeTrail, 2f);
        circleCollider.enabled = false;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Finish")
        {
            
           
            Scoremanager.instance.DelPoint();
            SoundManager.PlaySound("inBetweenSound");


        }
    }
}
