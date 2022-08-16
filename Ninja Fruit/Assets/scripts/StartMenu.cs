using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class StartMenu : MonoBehaviour
{
    public void Startup()
    {
        gameObject.SetActive(true);
        
    }
    
    
    public void Exit()
    {
        Application.Quit();
    }
    public void Back()
    {
        gameObject.SetActive(false);

    }
}
