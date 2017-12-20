using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

[CustomEditor(typeof(PopulationManager))]
public class PopulationsEditor : Editor
{
    #region Private and Protected Members

    #endregion
    #region Public Members

    #endregion
    public PopulationManager myTarget;
    #region Public void

    #endregion

    #region System
    public override void OnInspectorGUI()
    {
        
        Debug.Log("hellooooooooo!");

        myTarget = (PopulationManager)base.target;

        string _populationsName = "";

        if (myTarget.m_list_population != null)
        {
            foreach (Population p in  myTarget.m_list_population)
            {
                _populationsName += p._name;
            }
            
        }
        GUILayout.Label(_populationsName);
       // Debug.Log(_populationsName);
        DrawDefaultInspector();

    }


    public static string ShowName() {

        return null  ;
    }
    #endregion

    #region Tools Debug and Utility

    #endregion


}
