using System;
using UnityEngine;
using UnityEngine.UI;

namespace Skinnable {
    public class TextStyle : BaseStyle<Text> {

        public int fontSize;
        public Color fontColor;
        public Font font;

        public override void ApplyStyle (ref System.Object targetObject) {
            Text text = targetObject as Text;
            if (text != null) {
                if(ShouldApply(nameof(font)) )  text.font = font;
                if(ShouldApply(nameof(fontColor)) )  text.color = fontColor;
                if(ShouldApply(nameof(fontSize)) )  text.fontSize = fontSize;
            }
        }
    }
}