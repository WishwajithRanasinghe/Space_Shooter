using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spaceshipmove : MonoBehaviour
{
    private Rigidbody2D _rBody;
    [SerializeField]
    private float _moveSpeed = 10f, _rotateSpeed = 12f;
    public float _helth = 100f;

    private float _horizontalInput,_verticalInput;
    private Vector2 _input;
    [SerializeField]
    private SpriteRenderer _spRenderer;
    private Color _startColor;
    private GameObject _ui;
    public bool _signal;
    

    private void Start()
    {
        _rBody = GetComponent<Rigidbody2D>();
        _startColor = _spRenderer.color;
        _ui = GameObject.FindGameObjectWithTag("UI");

    }// Start

    private void Update()
    {
        if(_ui == null) {return;}
        if(_ui.GetComponent<TimeScript>().state != TimeScript.State.PLAY) {return;}
    
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
        SpaceshipMove();
        SpaceshipRotation();
        Vector2 _currentPosition = transform.position;
        _currentPosition.x = Mathf.Clamp(_currentPosition.x,-8f,8f);
        _currentPosition.y = Mathf.Clamp(_currentPosition.y,-4.3f,4.3f);
        transform.position = _currentPosition;
        
        if(_helth <= 0)
        {
            _helth = 0;
            Destroy(this.gameObject,0.1f);
        }
        Deactivate();
   

    }// Update
    public void SpaceshipMove()
    {
        _rBody.velocity  = new Vector2(_horizontalInput*_moveSpeed*Time.deltaTime,_verticalInput*_moveSpeed*Time.deltaTime);
       
       //transform.Translate(Vector3.up*_verticalInput*_moveSpeed*Time.deltaTime);
    }// SpaceshipMove
    public void SpaceshipRotation()
    {
        
        if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0f,0f,_rotateSpeed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0f,0f,-_rotateSpeed*Time.deltaTime);
        }
    }// SpaceshipRotation
    private void OnCollisionEnter2D(Collision2D _target)
    {
        switch(_target.transform.tag)
        {
            case "EnemyBullet":
            _helth -= 5f;
            PlayerHelth();
            _spRenderer.color = Color.red;
            break;

            case "Orc":
            Destroy(_target.gameObject,0.1f);
            PlayerHelth();
            break;

            case "Laser":
            _helth = 0f;
            _spRenderer.color = Color.red;
            Destroy(this.gameObject,0.2f);
            
            break;
            case "Finish":
            SceneManager.LoadScene(2);
            
            break;


            default:
            _spRenderer.color = Color.red;

            break;

        }

    }// OnCollisionEnter2D
    private void OnCollisionExit2D(Collision2D _target)
    {
        switch(_target.transform.tag)
        {
            case "EnemyBullet":
            _spRenderer.color = _startColor;
            
            break;

            case "Orc":

            break;

            case "Laser":
            _spRenderer.color = _startColor;
            
            
            break;

            default:
            _spRenderer.color = _startColor;
            

            break;

        }

    }// OnCollisionExit2D
    public void PlayerHelth()
    {
        _helth -= 25f;
        

    }
    private void Deactivate()
    {
        if(Input.GetKey(KeyCode.G))
        {
            _signal = true;
        }
        else
        {
            _signal = false;
        }
    }//Deactivate


}// Class
