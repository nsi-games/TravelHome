using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GoHome
{
    public class GameManager : MonoBehaviour
    {
        #region Singleton
        public static GameManager Instance = null;
        private void Awake()
        {
            Instance = this;
        }
        private void OnDestroy()
        {
            Instance = null;
        }
        #endregion

        public int currentLevel = 0;
        public int score = 0;
        public bool isGameRunning = true;
        public Transform levelContainer;
        [Header("UI")]
        public Text scoreText;
        private Level[] levels;

        private void Start()
        {
            levels = levelContainer.GetComponentsInChildren<Level>();
            SetLevel(currentLevel);
        }

        private void SetLevel(int levelIndex)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                GameObject level = levels[i].gameObject;
                level.SetActive(false);
                if (i == levelIndex)
                {
                    level.SetActive(true);
                }
            }
        }

        public void GameOver()
        {
            isGameRunning = false;
        }

        public void AddScore(int scoreToAdd)
        {
            score += scoreToAdd;
            scoreText.text = "Score: " + score.ToString();
        }

        public void NextLevel()
        {
            currentLevel++;
            if (currentLevel >= levels.Length)
            {
                GameOver();
            }
            else
            {
                SetLevel(currentLevel);
            }
        }
    }
}
