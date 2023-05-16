using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject _PauseMenu;
    public void PauseButton()
    {
        _PauseMenu.SetActive(true);
        Time.timeScale = 0;
        
        
    }//PauseButton
    public void ResumeButton()
    {
        _PauseMenu.SetActive(false);
        Time.timeScale = 1;
    }//ResumeButton
    public void ExitButton()
    {
        Application.Quit();
        print("Exit");
    }// ExitButton

}//lass
