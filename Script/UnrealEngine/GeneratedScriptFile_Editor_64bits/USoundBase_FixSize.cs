#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USoundBase
	{
		static readonly int SoundClassObject__Offset;
		/// <summary>Sound class this sound belongs to</summary>
		public USoundClass SoundClassObject
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SoundClassObject__Offset); if (v == IntPtr.Zero)return null; USoundClass retValue = new USoundClass(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + SoundClassObject__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + SoundClassObject__Offset, value._this.Get()); }
			
		}
		
		static readonly int bDebug__Offset;
		/// <summary>When "stat sounds -debug" has been specified, draw this sound's attenuation shape when the sound is audible. For debugging purpose only.</summary>
		public bool bDebug
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDebug__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDebug__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bOverrideConcurrency__Offset;
		public bool bOverrideConcurrency
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideConcurrency__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideConcurrency__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bIgnoreFocus__Offset;
		public bool bIgnoreFocus
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreFocus__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIgnoreFocus__Offset, 1,0,4,4);}
			
		}
		
		static readonly int SoundConcurrencySettings__Offset;
		/// <summary>If bOverridePlayback is false, the sound concurrency settings to use for this sound.</summary>
		public USoundConcurrency SoundConcurrencySettings
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SoundConcurrencySettings__Offset); if (v == IntPtr.Zero)return null; USoundConcurrency retValue = new USoundConcurrency(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + SoundConcurrencySettings__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + SoundConcurrencySettings__Offset, value._this.Get()); }
			
		}
		
		static readonly int ConcurrencyOverrides__Offset;
		/// <summary>If bOverridePlayback is true, concurrency settings to use.</summary>
		public FSoundConcurrencySettings ConcurrencyOverrides
		{
			get{ CheckIsValid();return (FSoundConcurrencySettings)Marshal.PtrToStructure(_this.Get()+ConcurrencyOverrides__Offset, typeof(FSoundConcurrencySettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ConcurrencyOverrides__Offset, false);}
			
		}
		
		static readonly int MaxConcurrentResolutionRule__Offset;
		public EMaxConcurrentResolutionRule MaxConcurrentResolutionRule
		{
			get{ CheckIsValid();return (EMaxConcurrentResolutionRule)Marshal.PtrToStructure(_this.Get()+MaxConcurrentResolutionRule__Offset, typeof(EMaxConcurrentResolutionRule));}
			
		}
		
		static readonly int MaxConcurrentPlayCount__Offset;
		/// <summary>Maximum number of times this sound can be played concurrently.</summary>
		public int MaxConcurrentPlayCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxConcurrentPlayCount__Offset, typeof(int));}
			
		}
		
		static readonly int Duration__Offset;
		/// <summary>Duration of sound in seconds.</summary>
		public float Duration
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Duration__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Duration__Offset, false);}
			
		}
		
		static readonly int AttenuationSettings__Offset;
		/// <summary>Attenuation settings package for the sound</summary>
		public USoundAttenuation AttenuationSettings
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AttenuationSettings__Offset); if (v == IntPtr.Zero)return null; USoundAttenuation retValue = new USoundAttenuation(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + AttenuationSettings__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + AttenuationSettings__Offset, value._this.Get()); }
			
		}
		
		static readonly int Priority__Offset;
		/// <summary>Sound priority (higher value is higher priority) used for concurrency resolution. This priority value is weighted against the final volume of the sound.</summary>
		public float Priority
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Priority__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Priority__Offset, false);}
			
		}
		
		static USoundBase()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundBase");
			SoundClassObject__Offset=GetPropertyOffset(NativeClassPtr,"SoundClassObject");
			bDebug__Offset=GetPropertyOffset(NativeClassPtr,"bDebug");
			bOverrideConcurrency__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideConcurrency");
			bIgnoreFocus__Offset=GetPropertyOffset(NativeClassPtr,"bIgnoreFocus");
			SoundConcurrencySettings__Offset=GetPropertyOffset(NativeClassPtr,"SoundConcurrencySettings");
			ConcurrencyOverrides__Offset=GetPropertyOffset(NativeClassPtr,"ConcurrencyOverrides");
			MaxConcurrentResolutionRule__Offset=GetPropertyOffset(NativeClassPtr,"MaxConcurrentResolutionRule");
			MaxConcurrentPlayCount__Offset=GetPropertyOffset(NativeClassPtr,"MaxConcurrentPlayCount");
			Duration__Offset=GetPropertyOffset(NativeClassPtr,"Duration");
			AttenuationSettings__Offset=GetPropertyOffset(NativeClassPtr,"AttenuationSettings");
			Priority__Offset=GetPropertyOffset(NativeClassPtr,"Priority");
			
		}
		
	}
	
}
#endif
#endif
