using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;


public class LoadBuildingInfo : MonoBehaviour, IPointerEnterHandler
{
    public Image image;
    public Sprite emptySprite;
    public TextMeshProUGUI bName;
    public TextMeshProUGUI bDesc;
    public TextMeshProUGUI cost;
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (eventData.pointerCurrentRaycast.gameObject != null)
        {
            image.sprite = eventData.pointerCurrentRaycast.gameObject.GetComponent<LoadBuildings>().build.buildingImage;
            bName.text = eventData.pointerCurrentRaycast.gameObject.GetComponent<LoadBuildings>().build.buildingName;
            bDesc.text = eventData.pointerCurrentRaycast.gameObject.GetComponent<LoadBuildings>().build.buildingDesc;
            cost.text = "Cost: " +eventData.pointerCurrentRaycast.gameObject.GetComponent<LoadBuildings>().cost.ToString();
        }
    }
}
