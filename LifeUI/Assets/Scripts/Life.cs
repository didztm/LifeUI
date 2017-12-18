using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Life : MonoBehaviour
{
    #region Private and Protected Members
    [Header("Life parameter")]
    [Range(0, 200)]
    [SerializeField]
    private int m_life;
    [SerializeField]
    private int m_max_life;
    #endregion


    #region Public Members
    [System.Serializable]
    public class OnLifeChangeEvent : UnityEvent<int> { }
    public OnLifeChangeEvent _onLifeChange;
    [System.Serializable]
    public class OnDeadEvent : UnityEvent { }
    public OnDeadEvent _onDead = new OnDeadEvent();
    [System.Serializable]
    public class OnFullLifeEvent : UnityEvent { }
    public OnFullLifeEvent _onFullLife;
    public int Value
    {
        get
        {
            return m_life;
        }
        set
        {
            m_life = value;
            _onLifeChange.Invoke(m_life); // la valeur a changé par
            //Réajuste la vie max si vie supérieure
            if (m_life > m_max_life)
            {
                m_max_life = m_life;
            }
            if (m_life <= 0)
            {
                _onDead.Invoke();
            }
            if (m_life == m_max_life)
            {
                _onFullLife.Invoke();
            }
            
            

        }
    }
   
    #endregion

    #region Public void

    #endregion

    #region System


    public void OnValidate()
    {
        Value = m_life;
    }


    #endregion

    #region Tools Debug and Utility
    #endregion
   
}
