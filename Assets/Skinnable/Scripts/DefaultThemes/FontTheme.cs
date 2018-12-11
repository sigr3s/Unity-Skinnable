using UnityEngine;

namespace Skinnable {
    public class FontTheme : BaseStyle<Font> {
        public Font font;

        public override void ApplyStyle(ref object targetObject)
        {
            if(ShouldApply(this.nameof(f => f.font)) )
            {
                targetObject = font;
            }
        }
    }
}