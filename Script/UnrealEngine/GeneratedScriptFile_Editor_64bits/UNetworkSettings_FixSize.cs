#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Network settings.</summary>
	public partial class UNetworkSettings
	{
		static readonly int bVerifyPeer__Offset;
		/// <summary>If true, libcurl authenticates the peer's certificate. Disable to allow self-signed certificates.</summary>
		public bool bVerifyPeer
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bVerifyPeer__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bVerifyPeer__Offset, 1,0,1,1);}
			
		}
		
		static UNetworkSettings()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NetworkSettings");
			bVerifyPeer__Offset=GetPropertyOffset(NativeClassPtr,"bVerifyPeer");
			
		}
		
	}
	
}
#endif
#endif
