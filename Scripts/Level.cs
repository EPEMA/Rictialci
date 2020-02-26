using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    private ScoreManager theScoreManager;

        void Start()
        {
            theScoreManager = FindObjectOfType<ScoreManager> ();
            theScoreManager.scoreCount = 0;
        }
}
