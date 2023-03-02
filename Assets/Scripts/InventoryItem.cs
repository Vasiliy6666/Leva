using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts
{
    [Serializable]
    [CreateAssetMenu(fileName = "InventoryItemData", menuName = "Inventory/Create new item")]
    public class InventoryItem : ScriptableObject
    {
        public Sprite itemImage;
    }
}