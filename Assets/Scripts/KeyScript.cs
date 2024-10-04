using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameVariables {
    public static int keyCount;
}

public class KeyScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider collider) {
        if (collider.gameObject.name == "player") {
            GameVariables.keyCount+=2;
            Destroy(gameObject);
        }
    }
    
}
