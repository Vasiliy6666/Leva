using UnityEngine;

namespace Scripts
{
    public class TestingUI : MonoBehaviour
    {
        public InventoryItem testingItem;

        [ContextMenu("Add Item")]
        public void TestAddItem()
        {
            InventoryUI.instance.AddItem(testingItem);
        }
    }
}