#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleVelocityInheritParent
	{
		static readonly int Scale__Offset;
		/// <summary>
		/// The scale to apply tot he parent velocity prior to adding it to the particle velocity during spawn.
		/// Value is retrieved using the EmitterTime of the emitter.
		/// </summary>
		public FRawDistributionVector Scale
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+Scale__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Scale__Offset, false);}
			
		}
		
		static UParticleModuleVelocityInheritParent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleVelocityInheritParent");
			Scale__Offset=GetPropertyOffset(NativeClassPtr,"Scale");
			
		}
		
	}
	
}
#endif
#endif
