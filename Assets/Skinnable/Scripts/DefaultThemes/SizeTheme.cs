
using Skinnable;

public class SizeTheme : BaseStyle<int> {
    public int size;
    public override void ApplyStyle (ref System.Object targetObject) {
        if(ShouldApply(nameof(size)) ) targetObject = size;
    }
}