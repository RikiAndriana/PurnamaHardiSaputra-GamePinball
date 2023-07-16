using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherController : MonoBehaviour
{
    public KeyCode input;
    public Collider ball;
    public float force;

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider == ball)
        {
            ReadInput(ball);
        }
    }
    private void ReadInput(Collider collider)
    {
        if (Input.GetKey(input))
        {
            collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        }
    }
}
