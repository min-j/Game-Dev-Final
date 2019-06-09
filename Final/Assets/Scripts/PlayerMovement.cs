using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float movementSpeed = 20f;

    [SerializeField]
    float turnSpeed = 60f;

    [SerializeField]
    Thruster[] thruster;

    Transform myT;

    private void Awake()
    {
        myT = transform;
    }
    void Update()
    {
        Turn();
        Thrust();
    }

    void Turn() {
        //yaw is use to turn left or right (arrow keys)
        //pitch is used to rotate up or down (r for rotate upwards and f for rotate downwards)
        //roll is used to rotate the ship (like a barral roll) (q and e). axis of rotation is the long part of the ship middle
        float yaw = turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float pitch = turnSpeed * Time.deltaTime * Input.GetAxis("Pitch");
        float roll = turnSpeed * Time.deltaTime * Input.GetAxis("Roll");

        myT.Rotate(-pitch,yaw,-roll);
    }

    void Thrust() {
        //thurst is used to move forward only hence the if statement
        //if we start to thrust, call Thuruster.Activate()
        //when we stop thrusting, call thruster.Actvale(fasle)
        if (Input.GetAxis("Vertical") > 0)
        {
            myT.position += myT.forward * movementSpeed * Time.deltaTime * Input.GetAxis("Vertical");
            foreach (Thruster t in thruster)
                t.Intensity(Input.GetAxis("Vertical"));
        }

        /*if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            foreach (Thruster t in thruster)
                t.Activate();
        else if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow))
            foreach (Thruster t in thruster)
                t.Activate(false);*/
    }
}
