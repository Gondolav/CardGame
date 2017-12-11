using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager_Board : MonoBehaviour {

    UIManager uiMgr;
    GameStateController gsc;
    Component[] buttons;

	// Use this for initialization
	void Start () {
        uiMgr = GameObject.FindWithTag("UIManager").GetComponent<UIManager>();
        gsc = GameObject.FindWithTag("GameController").GetComponent<GameStateController>();
        buttons = gameObject.GetComponentsInChildren<Button>();

        foreach (Button btn in buttons) {
            switch (btn.name) {
                case "EndTurn": btn.onClick.AddListener(onBtnEndTurnClick); break;
            }
        }
    }

    private void onBtnEndTurnClick() {
        gsc.EndTurn();
    }

	// Update is called once per frame
	void Update () {
		
	}
}
