using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerUi : MonoBehaviour
{
    [SerializeField]
    private Text _playerScore,_playerHelth,_finalScore;
    private GameObject _player;
    [SerializeField]
    private GameObject _gameOverPanel;


    private void Start()
    {
        
        
    }//Start


    private void Update()
    {
        _player = GameObject.FindGameObjectWithTag("Player");

        if(_player == null) {return;}
        if(_player.GetComponent<Spaceshipmove>()._helth <= 0)
        {
            _gameOverPanel.SetActive(true);
            _finalScore.text = "Score = " + _player.GetComponent<PlayerScore>()._score.ToString();
        }
        _playerScore.text = "Score = " + _player.GetComponent<PlayerScore>()._score.ToString();
        _playerHelth.text = "Helth = " + _player.GetComponent<Spaceshipmove>()._helth.ToString();
        
        
    }//Update
    public void Restart()
    {
        SceneManager.LoadScene(0);
        

    }//Restart
    public void Exit()
    {
        print("Exit!");
        Application.Quit();

    }//Exit
}//Class
