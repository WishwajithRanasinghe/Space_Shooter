using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    [SerializeField]
    private GameObject _portal;
    [SerializeField]
    private float _portalLifeTime = 5f;
    private GameObject _player;

    private void Start()
    {
        
    }//Start


    private void Update()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        if(_player == null) {return;}

        if(_player.GetComponent<PlayerScore>()._score >= 50)
        {
            _portal.SetActive(true);
            _portalLifeTime -= Time.deltaTime;
            if(_portalLifeTime <= 0)
            {
                _portalLifeTime = 0;
                _portal.SetActive(false);
            }
        }
        
    }//Update
}//Class
