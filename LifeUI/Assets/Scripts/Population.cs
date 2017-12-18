using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Population : MonoBehaviour
{
    #region Public Members
    public string _name;
    #endregion

    #region Public void

    #endregion

    #region System
    private void Reset()
    {
        _life = gameObject.AddComponent<Life>();
        
    }
    void Start ()
    {
        
        m_transform = transform;
        _life._onDead.AddListener(DeadTalk);
        _life._onFullLife.AddListener(FullLifeTalk);

    }

    private void FullLifeTalk()
    {
        Debug.Log("Je suis remplis de vie");
    }

    private void DeadTalk()
    {
        Debug.Log("Je suis  mort");
    }

    void Update ()
    {
        	
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members
    private Transform m_transform;
    
    [SerializeField]
    private Life _life;


    #endregion

}
