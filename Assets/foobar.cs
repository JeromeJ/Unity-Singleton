using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class foobar : MonoBehaviour
{
    #region Public Members

    #endregion

    #region Public void

    #endregion

    #region System

    void Start ()
    {
        Singleton singleton = Singleton.instance;

        Debug.Log(singleton.test);

        
    }

    void Update ()
    {
        if(Time.timeSinceLevelLoad > 2f)
        {
            SceneManager.LoadScene("Scene1");
        }
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    #endregion
}
