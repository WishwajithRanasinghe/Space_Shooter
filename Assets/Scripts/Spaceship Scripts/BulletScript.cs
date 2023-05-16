using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Rigidbody2D _rBody;
    [SerializeField]
    private float _fireForce = 100f;
    private GameObject _rocket;
 
    private void Start()
    {
        _rBody = GetComponent<Rigidbody2D>();
        _rocket = GameObject.FindGameObjectWithTag("Player");
        if(_rocket == null){return;}
        transform.rotation = _rocket.transform.rotation;
    }//Start


    private void Update()
    {
        _rBody.AddRelativeForce(Vector2.up*_fireForce*Time.deltaTime);
        Destroy(this.gameObject,3f);
        
    }//Update
    private void OnCollisionEnter2D(Collision2D _target)
    {
        Destroy(this.gameObject);
       
        
        if(_target.transform.tag == "Asteroid")
        {
            
            Destroy(_target.gameObject);
            Destroy(this.gameObject);
            if(_rocket == null){return;}
            _rocket.GetComponent<PlayerScore>().PScore(1);
            
        }
        if(_target.transform.tag == "BigAsteroid")
        {
            
            _target.gameObject.GetComponent<AsteroidScript>().AsteroidHelth(25);
            Destroy(this.gameObject);
            
            
        }
        if(_target.transform.tag == "Enemy")
        {
            _target.gameObject.GetComponent<EnemyMoveScriot>().EnemyHelth(25);
            Destroy(this.gameObject);
            if(_rocket == null){return;}
            _rocket.GetComponent<PlayerScore>().PScore(10);

        }
        if(_target.transform.tag == "Orc")
        {
            Destroy(this.gameObject);
            Destroy(_target.gameObject);
        }
        
    }// OnCollisionEnter2D
}// Class
