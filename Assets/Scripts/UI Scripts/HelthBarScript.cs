using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelthBarScript : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _helthBar;
    private GameObject _player;
    private float _playerHelth;


    private void Start()
    {
       
        
        
    }//Start


    private void Update()
    {
        _player =  GameObject.FindGameObjectWithTag("Player");
        
        
     
        if(_player == null){return;}
        _playerHelth = _player.GetComponent<Spaceshipmove>()._helth;

        if(_playerHelth <= 75)
        {
            _helthBar[3].SetActive(false);

        }
        if(_playerHelth <= 50)
        {
            _helthBar[2].SetActive(false);

        }
        if(_playerHelth <= 25)
        {
            _helthBar[1].SetActive(false);

        }
        if(_playerHelth == 0)
        {
            _helthBar[0].SetActive(false);
        }
        
        
    }// Update
}//Class
