using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    float m_horizontallnput;
    float m_verticallnput;

    float m_movementSpeed = 5.0f;

    CharacterController m_characterController;
    Vector3 m_movement;
    // Start is called before the first frame update
    void Start()
    {
        m_characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        m_horizontallnput = Input.GetAxis("Horizontal");
        m_verticallnput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        m_movement.x = m_horizontallnput * m_movementSpeed * Time.deltaTime;
        m_movement.z = m_verticallnput * m_movementSpeed * Time.deltaTime;
        m_characterController.Move(m_movement);
    }
}
