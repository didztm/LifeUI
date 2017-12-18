using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeUIForPlayer : MonoBehaviour
{

    public Life m_life;
    public Text m_displayLife;

    #region Public Members

    #endregion

    #region Public void

    #endregion

    #region System

    void Start ()
    {
        m_life._onLifeChange.AddListener(RefreshInterface);
        
    }

    private void RefreshInterface(int newLife)
    {
        m_displayLife.text = "Ma vie" + newLife;
    }

    void Update ()
    {
        	
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members
    [Header("Graphical parameter")]
    [SerializeField]
    private Sprite m_hit_spr;
    [SerializeField]
    private Sprite m_hitted_spr;
    [SerializeField]
    private Sprite m_life_spr;
    #endregion
}
