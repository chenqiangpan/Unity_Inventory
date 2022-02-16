using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Food Object", menuName = "Inventory System/Item/Equipment")]

public class EquipmentObject : ItemObject
{
    // Start is called before the first frame update
  
    public float atkBonus;
    public float defBonus;
    public void Awake() {
        type = ItemType.Equipment;
    }
}
