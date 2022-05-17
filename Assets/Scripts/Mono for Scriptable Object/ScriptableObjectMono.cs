using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableObjectMono : MonoBehaviour
{
    public ScriptableObjectExample example;
    public int view;

    private void Start()
    {
        example.number = 3;

    }

    private void Update()
    {
        view = example.number; //shows what's happening.
    }
}
