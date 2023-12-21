using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public float MoveSpeed;
    public float JumpSpeed;
    public float Friction;
    public bool Grounded;
    
    public float MaxSpeed;
    public Transform ColliderTransform;

    private int _jumpFrameCounter;
    private int _flyFrames = 0;

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Grounded == true)
            {
                _flyFrames = 50;
                Jump();
            }
        }
        if (Input.GetKey(KeyCode.LeftControl)|| Input.GetKey(KeyCode.S) || _flyFrames > 20)
        {
            ColliderTransform.localScale = Vector3.Lerp(ColliderTransform.localScale, new Vector3(1f, 0.5f, 1f),Time.deltaTime * 15f);
        
        }
        else
        {
            ColliderTransform.localScale = Vector3.Lerp(ColliderTransform.localScale, new Vector3(1f, 1f, 1f), Time.deltaTime * 15f);

        }

    }
    public void Jump()
    {
        Rigidbody.AddForce(0, JumpSpeed, 0, ForceMode.VelocityChange);
        _jumpFrameCounter = 0;
        
    }

    private void FixedUpdate()
    {
        
        if (!Grounded)
        {
            _flyFrames++;
        }

        float speedMultiplier = 1f;
        if (Grounded == false)
        {
            speedMultiplier = 0.2f;
            if (Rigidbody.velocity.x > MaxSpeed && Input.GetAxis("Horizontal") > 0)
            {
                speedMultiplier = 0;
            }
            if (Rigidbody.velocity.x < -MaxSpeed && Input.GetAxis("Horizontal") < 0)
            {
                speedMultiplier = 0;
            }
        }
        

        Rigidbody.AddForce(Input.GetAxis("Horizontal") * MoveSpeed * speedMultiplier, 0f, 0f, ForceMode.VelocityChange);

        if(Grounded)
        {
            Rigidbody.AddForce(-Rigidbody.velocity.x * Friction, 0f, 0f, ForceMode.VelocityChange);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, Time.deltaTime * 15f);
        }
        _jumpFrameCounter += 1;
        if (_jumpFrameCounter == 2)
        {
            Rigidbody.freezeRotation = false;
            if (Input.GetKey(KeyCode.D))
            {
                Rigidbody.AddRelativeTorque(0, 0, -5.5f, ForceMode.VelocityChange);
            }
            if (Input.GetKey(KeyCode.A))
            {
                Rigidbody.AddRelativeTorque(0, 0, 5.5f, ForceMode.VelocityChange);
            }

        }

        
    }
    private void OnCollisionStay(Collision collision)
    {
        


        for (int i = 0; i < collision.contactCount; i++)
        {
            float angle = Vector3.Angle(collision.contacts[i].normal, Vector3.up);
            if (angle < 45f)
            {
                Grounded = true;
                Rigidbody.freezeRotation = true;
                _flyFrames = 0;
            }
        }

        

           
    }
    private void OnCollisionExit(Collision collision)
    {
        Grounded = false;
    }
}
