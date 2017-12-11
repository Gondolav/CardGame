using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler {

	public void OnDrop(PointerEventData eventData) {
		Card c = eventData.pointerDrag.GetComponent<Card> ();
		if (c != null) {
			c.parentToReturnTo = this.transform;
		}
	}
}
