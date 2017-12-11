using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIManager : MonoBehaviour {

    GameObject board;

	// Use this for initialization
	void Start () {
        board = GameObject.FindWithTag("Board");
        checkEventSystem();
	}

    /**
     * checks if the current scene contains an Event System,
     * if not create one and add it
     * */
    void checkEventSystem()
    {
        var ESObj = GameObject.Find("EventSystem");
        if (ESObj == null)
        {
            ESObj = new GameObject("EventSystem");
            ESObj.AddComponent<EventSystem>();
            ESObj.AddComponent<StandaloneInputModule>();
        }
    }
}
