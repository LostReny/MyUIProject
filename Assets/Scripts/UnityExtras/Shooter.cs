using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public GameObject ammoPrefab;
    public List<GameObject> ammoList;

    public int speed = 2;
    public int ammo = 10;

    public int ShootVelocity
    {
        get{ return speed * ammo; }
    }

    public void CreateAmmo()
    {
        var a = Instantiate(ammoPrefab);
        a.transform.position = Vector3.zero;
    }

}
