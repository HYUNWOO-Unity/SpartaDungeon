using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class JumpPad : MonoBehaviour
{
    public float jumpForce = 10f; // ������ �� ũ��

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            // ���� �������� �������� ���� ����
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}

