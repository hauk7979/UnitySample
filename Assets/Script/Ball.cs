using System;
using UnityEngine;

namespace Script
{
    public class Ball : MonoBehaviour
    {
        // Start is called before the first frame update
        private void Start()
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-8.0f, 8.0f, 0.0f);
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
