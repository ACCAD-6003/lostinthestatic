using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tr_setvar : MonoBehaviour
{
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            GameObject.FindWithTag("Player").GetComponent<CombinedCharacterController>().airJumps = 5;
            Destroy(gameObject);
        }
    }
}
