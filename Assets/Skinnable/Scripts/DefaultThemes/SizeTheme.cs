
namespace Skinnable {
    public class SizeTheme : BaseStyle<int> {
        public int size;
        public override void ApplyStyle (ref System.Object targetObject) {
            if(ShouldApply(this.nameof(s => s.size)) )
            {
                targetObject = size;
            }
        }
    }
}