using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public float _score;

    private void Update()
    {

        
    }// Update
    public void PScore(int score)
    {
        _score += score;

    }//PScore
}//Class
