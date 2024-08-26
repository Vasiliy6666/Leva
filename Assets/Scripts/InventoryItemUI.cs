using UnityEngine;
using UnityEngine.UI;

namespace Scripts
{
    public class InventoryItemUI : MonoBehaviour
    {
        public Image itemImage;
        public InventoryItem inventoryItem;
        
        public void ClickDown()
        {
            InventoryUI.instance.MoveItem(this);
        }
    }
}