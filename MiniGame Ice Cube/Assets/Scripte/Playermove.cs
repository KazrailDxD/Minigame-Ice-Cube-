using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{

    Rigidbody rb = null;
    [SerializeField] float moveStrength = 5.0f;
    Vector3 moveDirection = Vector3.zero;
   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = Vector3.zero;
        moveDirection.x = Input.GetAxis("Horizontal");
        moveDirection.z = Input.GetAxis("Vertical");

        
    }

    void FixedUpdate()
    {
        rb.AddForce(moveDirection.normalized * moveStrength);
               
    }
}
