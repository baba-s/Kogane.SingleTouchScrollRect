using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Kogane
{
    [DisallowMultipleComponent]
    public sealed class SingleTouchScrollRect : ScrollRect
    {
        public override void OnBeginDrag( PointerEventData eventData )
        {
            if ( 0 < eventData.pointerId ) return;
            base.OnBeginDrag( eventData );
        }

        public override void OnDrag( PointerEventData eventData )
        {
            if ( 0 < eventData.pointerId ) return;
            base.OnDrag( eventData );
        }

        public override void OnEndDrag( PointerEventData eventData )
        {
            if ( 0 < eventData.pointerId ) return;
            base.OnEndDrag( eventData );
        }
    }
}