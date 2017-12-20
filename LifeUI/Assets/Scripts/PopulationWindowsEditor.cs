using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

public class PopulationWindowsEditor : EditorWindow
{
    #region Private and Protected Members

    #endregion
    #region Public Members

    #endregion
    public PopulationManager _PopMan;

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
        //_PopMan = new List<Population>(FindObjectsOfType<PopulationManager>());
        //_PopMan._onValidate.AddListener(UpdateList);
        foreach (Population p in _PopMan.m_list_population)
        {
            //editorobject
            EditorGUILayout.ObjectField(p._name, p, typeof(Population), true);
      
        }
        
    }
    private void UpdateList() {
        _PopMan = FindObjectOfType<PopulationManager>();

    }

  
    #endregion

    #region Tools Debug and Utility

    #endregion


}
