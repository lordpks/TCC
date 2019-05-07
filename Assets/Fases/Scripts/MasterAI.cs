﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterAI : MonoBehaviour
{
    // Fix a range how early u want your enemy detect the obstacle.
    private int range;
    private float speed;
    private bool isThereAnyThing = false;
    // Specify the target for the enemy.
    public GameObject target;
    private float rotationSpeed;
    private RaycastHit hit;
    public Transform Player;
    public int MoveSpeed;
    public int MinDist;
    Animator anim;
    // Use this for initialization
    void Start()
    {
        range = 80;
        speed = 10f;
        rotationSpeed = 15f;
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(transform.position, Player.position) <= MinDist)
        {
            //Debug.Log("aquiiii" + Vector3.Distance(transform.position, Player.position));
            transform.LookAt(Player);

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
            anim.SetBool("corre", true);


        }
        else
        {
            anim.SetBool("corre", false);
        }
        //Look At Somthly Towards the Target if there is nothing in front.
        if (!isThereAnyThing)
        {
            Vector3 relativePos = target.transform.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(relativePos);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime);
        }
        // Enemy translate in forward direction.
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //Checking for any Obstacle in front.
        // Two rays left and right to the object to detect the obstacle.
        Transform leftRay = transform;
        Transform rightRay = transform;
        //Use Phyics.RayCast to detect the obstacle
        if (Physics.Raycast(leftRay.position + (transform.right * 7), transform.forward, out hit, range) || Physics.Raycast(rightRay.position - (transform.right * 7), transform.forward, out hit, range))
        {
            if (hit.collider.gameObject.CompareTag("Obstaculo"))
            {
                Debug.Log("obstaci");
                isThereAnyThing = true;
                transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
            }
        }
        // Now Two More RayCast At The End of Object to detect that object has already pass the obsatacle.
        // Just making this boolean variable false it means there is nothing in front of object.
        if (Physics.Raycast(transform.position - (transform.forward * 4), transform.right, out hit, 10) ||
         Physics.Raycast(transform.position - (transform.forward * 4), -transform.right, out hit, 10))
        {
            if (hit.collider.gameObject.CompareTag("Obstaculo"))
            {
                isThereAnyThing = false;
            }
        }
        // Use to debug the Physics.RayCast.
        Debug.DrawRay(transform.position + (transform.right * 14), transform.forward * 50, Color.red);
        Debug.DrawRay(transform.position - (transform.right * 14), transform.forward * 50, Color.red);
        Debug.DrawRay(transform.position - (transform.forward * 4), -transform.right * 50, Color.yellow);
        Debug.DrawRay(transform.position - (transform.forward * 4), transform.right * 50, Color.yellow);
    }
}
