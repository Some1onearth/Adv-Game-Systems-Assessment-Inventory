using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Item/Weapon/Sword", fileName ="New Sword")]
public class SwordData : ScriptableObject
{
    public string swordName;
    public string swordDescription;
    public Sprite icon;
    public int cost;
    public int attackDamage;


}
