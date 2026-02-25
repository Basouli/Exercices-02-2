using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

namespace Exercices_02_2.Script
{

    public class ScoreUI : MonoBehaviour
    {
        public Text scoreText;

        private void OnEnable()
        {
            GameManager.Instance.OnItemCollected += UpdateScore;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnItemCollected -= UpdateScore;
        }

        private void UpdateScore(int score)
        {
            scoreText.text = "Score: " + score;
        }
    }
}
