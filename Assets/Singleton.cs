using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    #region Public Members

    #endregion

    #region Public void

    #endregion

    #region System

    public int test;

    void Awake ()
    {
        if (inst == null)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static Singleton instance
    {
        get
        {
            // Check if I have already a reference
            if (inst == null)
            {
                // Check if another singleton hasn't been created yet
                inst = FindObjectOfType<Singleton>();

                // No singleton found? Create one!
                if (inst == null)
                {
                    inst = new Singleton();
                }
            }

            return inst;
        }
    }
    public static Singleton inst;

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    #endregion
}
