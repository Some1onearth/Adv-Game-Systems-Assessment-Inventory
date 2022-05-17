using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public SwordData swordData;
    public GameEvent OnSwordSelected;
    private void Start()
    {
        gameObject.name = swordData.swordName;
        OnSwordSelected = GetComponent<GameEventListener>().gameEvent;
    }
    private void OnMouseDown()
    {
        OnSwordSelected.Raise();
    }
}
