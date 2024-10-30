using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class JumpPad : MonoBehaviour
{
    public float jumpForce = 10f; // 점프대 힘 크기

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            // 위쪽 방향으로 순간적인 힘을 가함
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}

