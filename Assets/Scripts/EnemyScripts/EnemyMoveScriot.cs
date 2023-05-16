using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveScriot : MonoBehaviour
{
    [SerializeField]
    private float _eRocketSpeed = 100f,_eHelth = 50f,_distance;
    private Vector2 _startPos;
    [SerializeField]
    private AudioClip _alertClip;
    private AudioSource _audioSource;

    private void Start()
    {
        _startPos = transform.position;
        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
       
        transform.Translate(Vector3.up*_eRocketSpeed*Time.deltaTime);
        //Destroy(this.gameObject,5f);
        if(_eHelth == 0)
        {
            _eHelth =0;
            Destroy(this.gameObject);

        }
        _distance = Vector2.Distance(_startPos,transform.position);
        if(_distance >= 15)
        {
            //transform.position = _startPos;
        }
        if(_distance >= 2.3f)
        {
            if(_distance >= 2.4f){return;}
            _audioSource.PlayOneShot(_alertClip);

        }
      

    }//Update
    public void EnemyHelth(int _damage)
    {
        _eHelth -= _damage;

    }// EnemyHelth
    public void EnemyRespawn()
    {
        transform.position = _startPos;

    }

}//Class
