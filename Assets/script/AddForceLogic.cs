using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceLogic : MonoBehaviour
{
    Rigidbody m_rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_rigidbody.AddForce(Vector3.up * 1000.0f);
        }
        
    } 
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("On Trigger Entered");
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
