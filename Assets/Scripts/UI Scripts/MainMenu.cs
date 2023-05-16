using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject canvasPrefab,modePanel;

    private void Update()
    {
        
    }//Update
    public void RedSpaceship()
    {
        canvasPrefab.GetComponent<TimeScript>()._startShip = 0;
        SceneManager.LoadScene(0);

    }//RedSpaceship
    public void GreeSpaceship()
    {
        canvasPrefab.GetComponent<TimeScript>()._startShip = 1;
        SceneManager.LoadScene(0);

    }//GreeSpaceship
    public void EasyMode()
    {
        canvasPrefab.GetComponent<TimeScript>()._modeSelecter = 0;
        modePanel.SetActive(false);

    }//EasyMode
    public void HardMode()
    {
        canvasPrefab.GetComponent<TimeScript>()._modeSelecter = 1;
        modePanel.SetActive(false);

    }//HardMode
}//Class
