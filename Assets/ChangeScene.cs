using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    #region Public Members

    #endregion

    #region Public void

    #endregion

    #region System

    void Start ()
    {
        
        // Singleton singleton = FindObjectOfType<Singleton>();
        Singleton singleton = Singleton.instance;

        singleton.test++;
        

        SceneManager.LoadScene("Scene2");
    }

    void Update ()
    {
        	
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    #endregion
}
