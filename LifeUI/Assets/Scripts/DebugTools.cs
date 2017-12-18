using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTools : MonoBehaviour
{
    #region Public Members

    #endregion

    #region Public void

    #endregion

    #region System
    private void OnDrawGizmos()
    {
        Debug.Log("gizmos");
        IsPainted();
    }

    void Update ()
    {
        	
    }

    #endregion

    #region Tools Debug and Utility
    private void IsPainted()
    {
        foreach(Transform t in m_list_transform){
            if (t.tag == "tag_isEnnemy" && m_debug_color_ennemy)
            {
                Debug.Log("Ennemy");
                Gizmos.color = Color.red;
                Gizmos.DrawCube(t.position, new Vector3(0.2f, 0.2f, 0.2f));
                // Gizmos.DrawMesh(m_transform.GetComponent<Mesh>(), m_transform.position,m_transform.rotation);
            }
            if (t.tag == "tag_isPlayer" && m_debug_color_player)
            {
                Gizmos.color = Color.blue;
                Gizmos.DrawCube(t.position, new Vector3(0.2f, 0.2f, 0.2f));
            }
        }
        
    }
    #endregion

    #region Private and Protected Members
    private List<Transform> m_list_transform;
    [Header("Debug tools")]
    [SerializeField]
    private bool m_debug_color_ennemy = false;
    [SerializeField]
    private bool m_debug_color_player = false;
    #endregion
}
