using UnityEngine;
using UnityEngine.UI;

namespace Skinnable {

    public class ColorTheme : BaseStyle<Color> {
        public Color color = Color.white;
        public override void ApplyStyle (ref System.Object targetObject) {
            if(ShouldApply(this.nameof(b => b.color)) )
            {
                targetObject = color;
            }
        }

    }
}