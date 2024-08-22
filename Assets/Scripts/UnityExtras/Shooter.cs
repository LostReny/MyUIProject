using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject ammoPrefab;
    public List<GameObject> ammoList;

    public GameObject weaponPrefab;

    public int speed = 2;
    public int ammo = 10;

    public int ShootVelocity
    {
        get { return speed * ammo; }
    }

    public void CreateAmmo()
    {
        var a = Instantiate(ammoPrefab);
        a.transform.position = Vector3.zero;
    }

    public  void CreateRandomAmmo()
    {
        if (ammoList.Count > 0)
        {
            var randomAmmo = ammoList.GetRandom();
            
            Instantiate(randomAmmo, Vector3.zero, Quaternion.identity);
        }
    }
}

public static class ExtensionMethods
{
    public static T GetRandom<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }
}