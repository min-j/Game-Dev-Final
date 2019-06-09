using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float rotationalDamp = .5f;
    [SerializeField] float movementSpeed = 10f;

    private void Update()
    {
        Turn();
        Move();    
    }

    void Move() {
        transform.position += transform.forward * Time.deltaTime * movementSpeed;
    }

    void Turn() {
        Vector3 pos = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(pos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationalDamp);
    }
}
