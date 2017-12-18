using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B : MonoBehaviour
{

    public Life _life;
    public float _speed;
    public AudioSource _music;
    
    #region Public Members

    #endregion

    #region Public void

    #endregion

    #region System

    void Start ()
    {
        _life._onLifeChange.AddListener(ChangeMySpeed);
        _life._onLifeChange.AddListener(DisplayLife);
        _life._onLifeChange.AddListener(SetVolumeWithLife);

    }

    private void SetVolumeWithLife(int lifePourcent)
    {
        _music.volume = lifePourcent;
        //_life.IsDeath();
    }

    private void ChangeMySpeed(int life)
    {
        _speed = life * 90;
    }

    private void DisplayLife(int life) {

        Debug.Log("Life:" + life);
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
