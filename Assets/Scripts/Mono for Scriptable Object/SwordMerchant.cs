using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwordMerchant : MonoBehaviour
{
    public Text swordName;
    public Text swordDescription;
    public Image icon;
    public Text cost;
    public Text damage;
    void Start()
    {
        
    }

    public void UpdateUIDisplay(SwordData sword)
    {
        swordName.text = sword.swordName;
        swordDescription.text = sword.swordDescription;
        icon.sprite = sword.icon;
        cost.text = sword.cost.ToString();
        damage.text = sword.attackDamage.ToString();

    }
}
