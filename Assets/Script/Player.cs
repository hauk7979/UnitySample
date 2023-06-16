using System;
using UnityEngine;

namespace Script
{
    public class Player : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        private const float JumpSpeed = 12.0f;

        public bool isLanding = false;
        
        // Start is called before the first frame update
        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            isLanding = false;
        }

        // Update is called once per frame
        private void Update()
        {
            if (isLanding && Input.GetMouseButtonDown(0))
            {
                isLanding = false;
                _rigidbody.velocity = Vector3.up * JumpSpeed;
            }
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag($"Floor"))
            {
                isLanding = true;
            }
        }
    }
}
