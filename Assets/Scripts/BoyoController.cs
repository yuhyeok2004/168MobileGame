﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyoController : MonoBehaviour {

    void Awake() {
        GameManager.instance.SetBoyoController(this);
    }

    void Start() {
        
    }

    void Update() {

        // Testing block spawning and recursive image adjustment, take it out later ok

        //if (GameManager.instance.playerType == PlayerType.Blocker) {
        //    if (Input.GetMouseButton(0)) {
        //        Vector3 mousePos = Input.mousePosition;
        //        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        //        mousePos.z = 0;
        //        mousePos = new Vector3(Mathf.Floor(mousePos.x), Mathf.Floor(mousePos.y), mousePos.z);
        //        if (!GetBlockInPos(mousePos)) {
        //            GameObject block = GetFromPool();
        //            block.transform.position = mousePos;
        //            block.GetComponent<Block>().bitmask = -1; // Force an update in AdjustBitmasks
        //            AdjustBitmasks(block);
        //        }
        //    }
        //}
    }
}