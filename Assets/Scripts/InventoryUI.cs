using System;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts
{
    public class InventoryUI : MonoBehaviour
    {
        public GameObject inventoryItemPrefab;
        public GameObject itemsContainer;
        public Image activeInventoryItem;
        private InventoryItemUI _idleInventoryItem;
        public bool isActiveItemMoving;
        public Camera gameCamera;
        public LayerMask activeObjectLayer;

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
                var ray = gameCamera.ScreenPointToRay(Input.mousePosition); 
                if (Physics.Raycast(ray, out var raycastHit, 50, activeObjectLayer, QueryTriggerInteraction.Collide))
                {
                    if (raycastHit.collider.gameObject.GetComponent<IActiveObject>()
                        .Active(_idleInventoryItem.inventoryItem))
                    {
                        activeInventoryItem.gameObject.SetActive(false);
                        Destroy(_idleInventoryItem.gameObject);
                        isActiveItemMoving = false;
                        return;
                    }
                }
                activeInventoryItem.gameObject.SetActive(false);
                _idleInventoryItem.gameObject.SetActive(true);
                isActiveItemMoving = false;
            }
        }

        public void MoveItem(InventoryItemUI item)
        {
            isActiveItemMoving = true;
            _idleInventoryItem = item;
            _idleInventoryItem.gameObject.SetActive(false);
            activeInventoryItem.gameObject.SetActive(true);
            activeInventoryItem.sprite = item.itemImage.sprite;
        }

        public void AddItem(InventoryItem itemImage)
        {
            var item = Instantiate(inventoryItemPrefab, itemsContainer.transform).GetComponent<InventoryItemUI>();
            item.itemImage.sprite = itemImage.itemImage;
            item.inventoryItem = itemImage;

        }
    }
}