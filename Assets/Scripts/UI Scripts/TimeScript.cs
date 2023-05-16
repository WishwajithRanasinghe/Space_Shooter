using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    [SerializeField]
    private Text _timeText,_sTimeText;
    [SerializeField]
    private GameObject _gameOverPanel,_redSpaceship,_greenSpceship,_easyMode,_hardMode;
    [SerializeField]
    private float _time = 60;
    [SerializeField]
    private Transform _shipPos,_enemyPos;

    public float _startTime = 3;
    public enum State {START,PLAY};
    public State state = State.PLAY;
    public int _startShip,_modeSelecter;
    

    private void Start()
    {
        if(_startShip == 0)
        {
            Instantiate<GameObject>(_redSpaceship,_shipPos.position,Quaternion.identity);
        }
        if(_startShip == 1)
        {
            Instantiate<GameObject>(_greenSpceship,_shipPos.position,Quaternion.identity);
        }
        if(_modeSelecter == 0)
        {
            Instantiate<GameObject>(_easyMode,_enemyPos.position,Quaternion.identity);
        }
        if(_modeSelecter == 1)
        {
            Instantiate<GameObject>(_hardMode,_enemyPos.position,Quaternion.identity);
        }

        
        state =State.START;
        StartCoroutine(Timer());
    }//Start
    private void Update()
    {
        
        if(_time <= 0)
        {
            _time = 0;
            _gameOverPanel.SetActive(true);
        }
        
        _timeText.text = "Time = " + _time.ToString();
        if(_startTime > 0)
        {
            _sTimeText.text = _startTime.ToString();

        }
        if(_startTime <= 0)
        {
            
            _sTimeText.text = "GO!";
            Destroy(_sTimeText,1f);
            state = State.PLAY;

        }
       
        
        
    }//Class
    private IEnumerator Timer()
    {
        while(_startTime > -1)
        {
            _startTime --;
            yield return new WaitForSeconds(1f);
        }
        
        while(true)
        {
            _time --;
            yield return new WaitForSeconds(1f);
        }
    
    }
}//Update
