using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EbulletScript : MonoBehaviour
{
    [SerializeField]
    private float _bulletSpeed = 10f;

    private void Start()
    {
        
    }


    private void Update()
    {
        transform.Translate(Vector3.down*_bulletSpeed*Time.deltaTime);
        Destroy(this.gameObject,3f);
        
    }// Update 
}//Class
