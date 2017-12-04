using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Card : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler{

	private readonly string Description;

	private readonly Image Image;

	private int cost;
	public int Cost { get; set; }

	private bool hasBeenPlayed;
	public bool HasBeenPlayed { get; set; }
	
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
		this.transform.position = eventData.position;
	}

	public void OnEndDrag(PointerEventData eventData) {
		Debug.Log ("End Drag");
		this.transform.SetParent (parentToReturnTo);
		GetComponent<CanvasGroup> ().blocksRaycasts = true;
	}
}
