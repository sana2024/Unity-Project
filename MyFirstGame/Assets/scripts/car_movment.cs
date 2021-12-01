using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class car_movment : MonoBehaviour
    
{
    Rigidbody rb;
    public GameObject winTex;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount>0)
        {
            //rb.AddForce(Vector3.up * 500);
            rb.velocity = Vector3.forward * 20f;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("scene2");
        }
    }
    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
         
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag== "Enemy")
        {
            Destroy(collision.gameObject);
            winTex.SetActive(true);
        }
    }
}
