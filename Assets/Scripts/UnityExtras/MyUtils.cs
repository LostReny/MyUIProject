namespace MyUtilities
{
    using System.Collections.Generic;
    using TMPro.Examples;

    using UnityEngine;
    using Random = UnityEngine.Random;

    public static class MyUtils
    {

        #if UNITY_EDITOR
        [UnityEditor.MenuItem("Add/New Weapon")]

        public static void NewWeapon()
        {
             // Encontre uma instância do Shooter na cena
            Shooter shooter = GameObject.FindObjectOfType<Shooter>();
            
            if (shooter != null && shooter.weaponPrefab != null)
            {
                Debug.Log("Adding new weapon");
                Object.Instantiate(shooter.weaponPrefab, Vector3.zero, Quaternion.identity);
            }

        }

        [UnityEditor.MenuItem("Add/Reload %g")]
        public static void Reload()
        {
            Debug.Log("Reload");
        }
        #endif

        // metodo de extensão 
        // pegando um valor randomico
        public static T GetRandom<T>(this List<T> list)
        {
            return list[Random.Range(0, list.Count)];
        }
    }
}