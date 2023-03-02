using UnityEngine;
using UnityEngine.UI;

namespace Scripts
{
    public class InventoryItemUI : MonoBehaviour
    {
        public Image itemImage;
        
        public void ClickDown()
        {
            InventoryUI.instance.MoveItem(itemImage);
        }
    }
}