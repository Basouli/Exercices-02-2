using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Exercices_02_2.Script
{

    [RequireComponent(typeof(Collider))]
    public class CollectibleItem : MonoBehaviour
    {
        private void Reset()
        {
            // S’assurer que le collider est trigger
            GetComponent<Collider>().isTrigger = true;
        }

        public void Collect()
        {
            // Notifie le GameManager
            GameManager.Instance.CollectItem();

            // Détruit l’objet collecté
            Destroy(gameObject);
        }
    }
}
