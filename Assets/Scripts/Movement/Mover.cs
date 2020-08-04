using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace RPG.Movement
{

    public class Mover : MonoBehaviour
    {

        [SerializeField] Transform target;

        int rayLength = 100;

        NavMeshAgent navMeshAgent;


        void Start()
        {
            navMeshAgent = GetComponent<NavMeshAgent>();
        }


        void Update()
        {
            UpdateAnimator();
        }

        public void MoveTo(Vector3 destination)
        {
            navMeshAgent.destination = destination;
        }

        private void UpdateAnimator()
        {
            Vector3 velocity = navMeshAgent.velocity;
            Vector3 localVelocity = transform.InverseTransformDirection(velocity);
            float speed = localVelocity.z;
            GetComponent<Animator>().SetFloat("forwardSpeed", speed);
            print("velocity = " + velocity.ToString() + " : localVelocity = " + localVelocity.ToString() + " : speed = " + speed); //TODO Delete
        }
    }

}