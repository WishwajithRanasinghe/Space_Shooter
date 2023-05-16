using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    [SerializeField]
    private float _helth =100f;
    private GameObject _rocket;
    [SerializeField]
    private GameObject _coin;

    private void Start()
    {
         _rocket = GameObject.FindGameObjectWithTag("Player");

    }//Start

    private void Update()
    {
        if(_helth == 0)
        {
            _helth = 0;
            Destroy(this.gameObject);
            _rocket.GetComponent<PlayerScore>().PScore(5);
            Instantiate<GameObject>(_coin,transform.position,Quaternion.identity);
        }
        
    }// Update
    public void AsteroidHelth(int _demageAmount)
    {
        _helth -= _demageAmount;

    }
    
}//Class
