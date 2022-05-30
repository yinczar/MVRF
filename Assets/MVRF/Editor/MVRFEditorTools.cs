using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Valve.VR.InteractionSystem;
using UnityEditor.Experimental.SceneManagement;

public class MVRFEditorTools : MonoBehaviour
{



    /// <summary>    ///  创建VRF 模板    /// </summary>
    [MenuItem("GameObject/MVRF/CreateVRF", priority = 11)]
    private static void CreateVRF()
    {
        PrefabUtility.InstantiatePrefab(Resources.Load("Player") as GameObject);
        PrefabUtility.InstantiatePrefab(Resources.Load("Teleporting") as GameObject);

    }


    /// <summary>    ///   设为传送区域    /// </summary>
    [MenuItem("GameObject/MVRF/SetAsTeleportArea", priority = 11)]
    private static void SetAsTeleportArea()
    {
        GameObject[] gos = Selection.gameObjects;
        for (int i = 0; i < Selection.gameObjects.Length; i++)
        {
            if (Selection.gameObjects[i].GetComponent<MeshRenderer>() && !Selection.gameObjects[i].GetComponent<TeleportArea>())
            {
                TeleportArea teleportArea = Selection.gameObjects[i].AddComponent<TeleportArea>();
                teleportArea.markerActive = true;
                teleportArea.locked = false;
            }
        }
        Selection.activeObject = null;
    }






    #region ValidateFunc
    [MenuItem("GameObject/MVRF/SetAsTeleportArea", true)]
    private static bool SetAsTeleportArea_Validate()
    {
        if (Selection.gameObjects.Length == 0)
            return false;

        for (int i = 0; i < Selection.gameObjects.Length; i++)
        {
            if (Selection.gameObjects[i].GetComponent<TeleportArea>() || !Selection.gameObjects[i].GetComponent<MeshRenderer>())
            {
                return false;
            }
        }

        return true;
    }



    #endregion


}
