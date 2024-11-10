/*
* Name: John Chirayil
* CGE401 - Assignment 6
* File: ShootWithRaycasts2.cs
* Desc: Sets the controller for rifle (Prop Hunt Game)
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWithRaycasts2 : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera cam;
    public ParticleSystem muzzleFlash;
    public float hitForce = 10f;
    public AudioSource laserShot;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        muzzleFlash.Play();

        laserShot.Play();

        RaycastHit hitInfo;

        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, range))
        {
            Debug.Log(hitInfo.transform.gameObject.name);

            // Get the target off the hit object
            Prop prop = hitInfo.transform.gameObject.GetComponent<Prop>();

            // If a target script was found, make the target take damage
            if (prop != null)
            {
                prop.TakeDamage(damage);

                if (hitInfo.rigidbody != null)
                {
                    hitInfo.rigidbody.AddForce(cam.transform.TransformDirection(Vector3.forward) * hitForce, ForceMode.Impulse);
                }
            }
        }
    }
}
