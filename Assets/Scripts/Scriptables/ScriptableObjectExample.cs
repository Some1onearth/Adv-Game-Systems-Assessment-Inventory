using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this creates an option in the rightclick, usually at the top of it.
[CreateAssetMenu(menuName ="Scriptable Objects/Example 1", fileName ="New Example Object", order =0)]
public class ScriptableObjectExample : ScriptableObject
{
    public int number;
}
