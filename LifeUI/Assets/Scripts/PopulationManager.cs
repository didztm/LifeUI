using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PopulationManager : MonoBehaviour
{
    #region Private and Protected Members
    [SerializeField]
    public List<Population> m_list_population;

    #endregion
    #region Public Members

    #endregion
    [System.Serializable]
    public class OnResetEvent : UnityEvent  { }
    public OnResetEvent _onValidate = new OnResetEvent();
    #region Public void

    #endregion

    #region System
    private void OnEnable()
    {
        
       
    }
    private void Reset()
    {

        m_list_population = new List<Population>(FindObjectsOfType<Population>());

    }
    private void OnValidate()
    {
        m_list_population = new List<Population>(FindObjectsOfType<Population>());
        _onValidate.Invoke();
    }

    

    void Start ()
    {

        
        
    }

    void Update ()
    {
        	
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    
}
