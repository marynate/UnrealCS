#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleLifetime
	{
		static readonly int Lifetime__Offset;
		public FRawDistributionFloat Lifetime
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+Lifetime__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Lifetime__Offset, false);}
			
		}
		
		static UParticleModuleLifetime()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleLifetime");
			Lifetime__Offset=GetPropertyOffset(NativeClassPtr,"Lifetime");
			
		}
		
	}
	
}
#endif
#endif
