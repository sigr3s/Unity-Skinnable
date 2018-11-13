using System;
using UnityEngine;
using UnityEngine.UI;

namespace Skinnable {
    public class ImageStyle : BaseStyle<Image> {
        public Color color;
        public Sprite defaultSprite;

        public override void ApplyStyle (ref System.Object targetObject) {
            Image img = targetObject as Image;
            if (img != null) {
                if(ShouldApply(nameof(color)) ) img.color = color;
                if(ShouldApply(nameof(defaultSprite)) ) img.sprite = defaultSprite;
            }
        }
    }
}