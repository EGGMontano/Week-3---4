using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject objectToSpawn;
    void Start()
    {
        Instantiate(objectToSpawn);
    }
}
