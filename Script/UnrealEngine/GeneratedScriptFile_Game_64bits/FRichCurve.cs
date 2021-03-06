#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=120)]
	public partial struct FRichCurve
	{
		[FieldOffset(88)]
		public ERichCurveExtrapolation PreInfinityExtrap;
		[FieldOffset(89)]
		public ERichCurveExtrapolation PostInfinityExtrap;
		public TStructArray<FRichCurveKey> Keys
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FRichCurveKey>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+96, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+96, false);}}}
			
		}
		[FieldOffset(112)]
		public float DefaultValue;
		[FieldOffset(8)]
		public FKeyHandleMap KeyHandlesToIndices;
		
	}
	
}
#endif
#endif
