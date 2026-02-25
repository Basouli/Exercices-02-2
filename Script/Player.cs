using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using UnityEngine;

namespace Exercices_02_2.Script
{

    [RequireComponent(typeof(Rigidbody))]
    public class Player : MonoBehaviour
    {
        public float speed = 5f;
        private Rigidbody rb;

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(h, 0, v);
            rb.MovePosition(transform.position + movement * speed * Time.deltaTime);
        }

        private void OnTriggerEnter(Collider other)
        {
            CollectibleItem item = other.GetComponent<CollectibleItem>();
            if (item != null)
            {
                item.Collect();
            }
        }
    }
}
