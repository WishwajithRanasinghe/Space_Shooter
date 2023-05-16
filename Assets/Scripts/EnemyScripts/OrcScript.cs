using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcScript : MonoBehaviour
{
    private GameObject _player;
    [SerializeField]
    private float _orcSpeed =10f;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        
    }//Start

    private void Update()
    {
        if(_player ==  null){return;}
        transform.position = Vector3.MoveTowards(transform.position,_player.transform.position,_orcSpeed*Time.deltaTime);
        
    }//Update
}//Class
