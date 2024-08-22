using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Shooter))]
public class ShooterEditor : Editor
{
    public override void OnInspectorGUI()
    {
       // base.OnInspectorGUI();
        EditorGUILayout.HelpBox("Calcule a velocidade de tiros", MessageType.Info);

        Shooter myTarget = (Shooter)target;
        myTarget.ammoPrefab = (GameObject) EditorGUILayout.ObjectField(myTarget.ammoPrefab, typeof(GameObject), true);

        myTarget.weaponPrefab = (GameObject) EditorGUILayout.ObjectField(myTarget.weaponPrefab, typeof(GameObject), true);

        EditorGUILayout.LabelField("Ammo List", EditorStyles.boldLabel);

        if (myTarget.ammoList == null)
        {
            myTarget.ammoList = new List<GameObject>();
        }

        for (int i = 0; i < myTarget.ammoList.Count; i++)
        {
            myTarget.ammoList[i] = (GameObject)EditorGUILayout.ObjectField("Ammo " + i, myTarget.ammoList[i], typeof(GameObject), true);
        }

        if (GUILayout.Button("Add Ammo"))
        {
            myTarget.ammoList.Add(null);
        }

        if (GUILayout.Button("Remove Last Ammo"))
        {
            if (myTarget.ammoList.Count > 0)
            {
                myTarget.ammoList.RemoveAt(myTarget.ammoList.Count - 1);
            }
        }

        myTarget.speed = EditorGUILayout.IntField("Velocidade muni��o", myTarget.speed);
        myTarget.ammo = EditorGUILayout.IntField("Muni��o", myTarget.ammo);

        EditorGUILayout.LabelField("Velocidade tiro", myTarget.ShootVelocity.ToString());


        GUI.color = Color.yellow;
        if (GUILayout.Button("CreateAmmo"))
        {
            myTarget.CreateRandomAmmo();
        }

        GUI.color = Color.white;
        if (myTarget.speed > 5) 
        {
            EditorGUILayout.HelpBox("Arma sobrecarregada", MessageType.Error);
        }
    }
}
