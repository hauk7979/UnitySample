using UnityEngine;

namespace Script
{
    public class Player : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        private const float JumpSpeed = 5.0f;

        // Start is called before the first frame update
        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        private void Update()
        {
            if (Input.GetMouseButtonDown(0)) {
                _rigidbody.velocity = Vector3.up * JumpSpeed;
            }
        }
    }
}
