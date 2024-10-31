using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{

    public GameObject Instructions;

   void OnTriggerEnter(Collider collider) {
    if (collider.gameObject.name =="player" && GameVariables.keyCount>0) {
        GameVariables.keyCount--;
        Destroy(gameObject);
        Instructions.SetActive(false);
    }
   }
}
