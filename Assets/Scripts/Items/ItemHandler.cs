using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemHandler : MonoBehaviour
{
    public Text itemName;
    public Text itemDescription;
    public Image icon;
    public Text cost;
    public Text damage;
    void Start()
    {

    }

    public void UpdateUIDisplay(ItemData item)
    {
        itemName.text = item.itemName;
        itemDescription.text = item.itemDescription;
        icon.sprite = item.icon;
        cost.text = item.cost.ToString();
        damage.text = item.damage.ToString();

    }
}
