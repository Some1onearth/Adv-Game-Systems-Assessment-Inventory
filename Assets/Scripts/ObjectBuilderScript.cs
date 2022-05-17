using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBuilderScript : MonoBehaviour
{
    [Tooltip("Adding an Object to this slot will allow the Build Object button to appear")]
    public GameObject objToSpawn;
    public Vector3 spawnPoint;

    public void BuildObject()
    {
        Instantiate(objToSpawn, spawnPoint, Quaternion.identity);
    }
}
