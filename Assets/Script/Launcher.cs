using System;
using UnityEngine;

namespace Script
{
    public class Launcher : MonoBehaviour
    {
        public GameObject ballPrefab;
        
        // Start is called before the first frame update
        private void Start()
        {
        
        }

        // Update is called once per frame
        private void Update()
        {
            if (Input.GetMouseButtonDown(1))
            {
                Instantiate(ballPrefab, transform.position, Quaternion.identity);
            }
        }
    }
}
