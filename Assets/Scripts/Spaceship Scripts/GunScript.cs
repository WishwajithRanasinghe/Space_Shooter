using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    [SerializeField]
    private GameObject _laderPrefab;
    [SerializeField]
    private Transform _gunPos;
    private GameObject _ui;
    private void Start()
    {
        _ui = GameObject.FindGameObjectWithTag("UI");

    }//Start

    private void Update()
    {
        if(_ui == null) {return;}
        if(_ui.GetComponent<TimeScript>().state != TimeScript.State.PLAY) {return;}
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate<GameObject>(_laderPrefab,_gunPos.position,Quaternion.identity);
          
        }
        
    }//Update 
}//Class
