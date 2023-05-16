using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyBullet,_eGun;


    private void Start()
    {
        StartCoroutine(EnemyFire());
        
    }//Start

    private void Update()
    {
        
        
    }// Update 
    private IEnumerator EnemyFire()
    {
        while(true)
        {
            Instantiate<GameObject>(_enemyBullet,_eGun.transform.position,Quaternion.identity);
            yield return new WaitForSeconds(2f);

        }
    }
}// Class
