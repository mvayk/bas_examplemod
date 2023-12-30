using System;
using System.Collections;
using System.Collections.Generic;
using ThunderRoad;
using UnityEngine;

namespace bas_examplemod;

public class Main : ThunderScript {
    public override void ScriptLoaded(ModManager.ModData modData) {
      base.ScriptLoaded(modData);
      EventManager.onLevelLoad += new EventManager.LevelLoadEvent(this.EventManager_onLevelLoad);
      Debug.Log("B&S Example Mod Has Loaded");
    }

    private void EventManager_onLevelLoad(LevelData levelData, EventTime eventTime) {
      Debug.Log("Level Loaded");
    }
}
