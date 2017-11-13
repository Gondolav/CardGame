using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drop : MonoBehaviour, IDropHandler {

	public void OnDrop(PointerEventData eventData) {
		Debug.Log (eventData.pointerDrag.name + "was dropped on " + gameObject.name);

		Card c = eventData.pointerDrag.GetComponent<Card> ();
		if (c != null) {
			c.parentToReturnTo = this.transform;
		}
	}
}
