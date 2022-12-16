using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoralMove : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed=5;
    [SerializeField] float deadzone = -30;

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        if (transform.position.x< deadzone)
        {
            Destroy(gameObject);
        }
    }
}
