using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoveryCtrl : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameData.hp = GameData.hpMax;
            Destroy(gameObject);
        }
    }
}
