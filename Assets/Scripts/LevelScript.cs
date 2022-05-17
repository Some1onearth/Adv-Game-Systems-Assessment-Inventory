using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScript : MonoBehaviour
{
    public int experience;
    // property - which can get and set things
    public int Level
    {
        get { return experience / 750; }
    }
}
