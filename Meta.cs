using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Proto {
    public class Meta:ModMeta {
        public override void ConstructOptionsScreen(RectTransform parent, bool inGame) {
            var desc = WindowManager.SpawnLabel();
            desc.text = "modDesc".Loc();

            WindowManager.AddElementToElement(desc.gameObject, parent.gameObject, new Rect(0, 0, 400, 128f), Rect.zero);
        }

        public override string Name => "Prototype Code  Mod";
    }
}