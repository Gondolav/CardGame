using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Card : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler{

	public Transform parentToReturnTo = null;

	private string cardName;
	private string descriptionText;

	public Card() {

	}

	public Card(string name, string description) {
		cardName = name;
		descriptionText = description;
	}

	public void OnBeginDrag(PointerEventData eventData) {
		Debug.Log ("Begin Drag");

		GetComponent<CanvasGroup> ().blocksRaycasts = false;
		parentToReturnTo = this.transform.parent;
		this.transform.SetParent(parentToReturnTo.parent);
	}

	public void OnDrag(PointerEventData eventData) {
		Debug.Log ("Dragging");
		this.transform.position = eventData.position;
	}

	public void OnEndDrag(PointerEventData eventData) {
		Debug.Log ("End Drag");
		this.transform.SetParent (parentToReturnTo);
		GetComponent<CanvasGroup> ().blocksRaycasts = true;
	}
}