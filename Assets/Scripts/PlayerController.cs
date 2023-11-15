using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float horizontalInput;
    private float forwardInput;
   private float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * horizontalInput * speed * Time.deltaTime);
        transform.Translate(Vector3.right * forwardInput * speed * Time.deltaTime);
    }
}
