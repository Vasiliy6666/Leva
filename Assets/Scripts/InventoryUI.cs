using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts
{
    public class InventoryUI : MonoBehaviour
    {
        public GameObject inventoryItemPrefab;
        public GameObject itemsContainer;
        public Image activeInventoryItem;
        private GameObject _idleInventoryItem;
        public bool isActiveItemMoving;

        public static InventoryUI instance;

        private void Start()
        {
            instance = this;
        }

        private void Update()
        {
            if(!isActiveItemMoving) return;
            activeInventoryItem.transform.position = Input.mousePosition;
            
            if (Input.GetMouseButtonUp(0))
            {
                activeInventoryItem.gameObject.SetActive(false);
                _idleInventoryItem.SetActive(true);
                isActiveItemMoving = false;
            }
        }

        public void MoveItem(Image item)
        {
            isActiveItemMoving = true;
            _idleInventoryItem = item.gameObject;
            _idleInventoryItem.SetActive(false);
            activeInventoryItem.gameObject.SetActive(true);
            activeInventoryItem.sprite = item.sprite;
        }

        public void AddItem(InventoryItem itemImage)
        {
            Instantiate(inventoryItemPrefab, itemsContainer.transform).GetComponent<Image>().sprite 
                = itemImage.itemImage;
        }
    }
}