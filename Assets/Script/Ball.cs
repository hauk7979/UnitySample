using System;
using UnityEngine;

namespace Script
{
    public class Ball : MonoBehaviour
    {
        // Start is called before the first frame update
        private void Start()
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-10.0f, 9.0f, 0.0f);
        }

        // Update is called once per frame
        private void Update()
        {
        
        }

        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }
}
