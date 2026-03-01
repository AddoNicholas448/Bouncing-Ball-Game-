using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
 public float bounceForce = 5f;   // How strong the bounce is
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
     rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.B))
        {
            rb.AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
        }   
    }
}
