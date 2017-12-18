using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PopulationWindowsEditor : EditorWindow
{
    #region Private and Protected Members

    #endregion
    #region Public Members

    #endregion
    PopulationManager _PopMan;
    #region Public void
    
    #endregion

    #region System
    [MenuItem("Toolbox/Population info")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(PopulationWindowsEditor));
        

    }
    void OnGUI()
    {

        _PopMan= EditorGUILayout.ObjectField("PopulationManager :",_PopMan,typeof(PopulationManager),true)as PopulationManager;

        //EditorGUILayout.ObjectField();
        foreach (Population p in _PopMan.m_list_population)
        {
            EditorGUILayout.ObjectField(p._name, p, typeof(Population), true);
        }
        
    }
    #endregion

    #region Tools Debug and Utility

    #endregion


}
