using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawn : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D _target)
    {
        if(_target.transform.tag == "Enemy")
        {
            _target.gameObject.GetComponent<EnemyMoveScriot>().EnemyRespawn();
        }
    }//OnCollisionEnter2D
}
