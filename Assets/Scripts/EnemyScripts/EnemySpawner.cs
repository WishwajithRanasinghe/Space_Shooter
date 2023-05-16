using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _eRocketPrefab,_orcPrefab,_laserPrefab,_timeBomb;
    private GameObject _ui;
    float _startTime;

    private void Start()
    {
        _ui = GameObject.FindGameObjectWithTag("UI");
        _startTime = _ui.GetComponent<TimeScript>()._startTime;
        StartCoroutine(EnemySpawnerTimer());
        StartCoroutine(OrcSpawnTimer());
        StartCoroutine(TimeBomb());
        
        
    }//Start
    

    private IEnumerator EnemySpawnerTimer()
    {
        yield return new WaitForSeconds(_startTime);
        while(true)
        {
            float _randomPosX = Random.Range(-8f,8f);
            float _randomID = Random.Range(0.5f,4f);
            Instantiate<GameObject>(_eRocketPrefab,new Vector3(_randomPosX,8f,0f),Quaternion.Euler(0f,0f,180f));
            yield return new WaitForSeconds(_randomID);
            
        }
    }//EnemySpawnerTimer
    private IEnumerator OrcSpawnTimer()
    {
        yield return new WaitForSeconds(_startTime);
        while(true)
        {
            Instantiate<GameObject>(_orcPrefab,Vector3.zero,Quaternion.identity);
            Instantiate<GameObject>(_laserPrefab,Vector3.zero,Quaternion.Euler(0f,0f,90f));
            yield return new WaitForSeconds (5f);
            
        }
    }//OrcSpawnTimer 
    private IEnumerator TimeBomb()
    {
        yield return new WaitForSeconds(_startTime);
        while (true)
        {
            
            float _randomID = Random.Range(2f,5f);
            yield return new WaitForSeconds(_randomID);
            float _randomPosX = Random.Range(-8f,8f);
            float _randomPosY = Random.Range(-4.3f,4.3f);
            Instantiate<GameObject>(_timeBomb,new Vector3(_randomPosX,_randomPosY,0f),Quaternion.identity);
            
        }
    } //TimeBomb 
    


}//Class
