using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Exercices_02_2.Script
{

    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        public event Action<int> OnItemCollected;

        private int score = 0;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void CollectItem()
        {
            score++;
            OnItemCollected?.Invoke(score);
        }
    }
}
