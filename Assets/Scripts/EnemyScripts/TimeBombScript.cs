using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBombScript : MonoBehaviour
{
    [SerializeField]
    private float _explosionRange = 2f;
    [SerializeField]
    private float _exploaionTime;
    [SerializeField]
    private LayerMask _destroyLayer;
    private SpriteRenderer _spRenderer;



    private void Start()
    {
        StartCoroutine(ExploasionTime());
        _spRenderer = GetComponent<SpriteRenderer>();
    }//Start
    private void Update()
    {
        Collider2D DestroyObject = Physics2D.OverlapCircle(transform.position,_explosionRange,_destroyLayer);
        if( DestroyObject != null)
        {
            if(DestroyObject.GetComponent<Spaceshipmove>() != null)
            {
                if(DestroyObject.GetComponent<Spaceshipmove>()._signal == true)
                {
                    _spRenderer.color = Color.green;
                }
            }
        }


    }//Update
    private IEnumerator ExploasionTime()
    {
        yield return new WaitForSeconds(_exploaionTime);
        
        Destroy(this.gameObject,0.2f);
        Explosion();

       
    }//ExploasionTime
    private void Explosion()
    {
        Collider2D DestroyObject = Physics2D.OverlapCircle(transform.position,_explosionRange,_destroyLayer);
        if( DestroyObject != null)
        {
            if(_spRenderer.color == Color.green) {return;}
            
            if(DestroyObject.GetComponent<Spaceshipmove>() != null)
            {
                DestroyObject.GetComponent<Spaceshipmove>()._helth -= 25f;
            }
        }
      
    }//Explosion
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position,_explosionRange);
    }//OnDrawGizmosSelected
}//Class
