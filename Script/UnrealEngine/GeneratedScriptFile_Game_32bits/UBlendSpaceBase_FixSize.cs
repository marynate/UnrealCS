#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UBlendSpaceBase
	{
		static readonly int BlendParameters__Offset;
		public FBlendParameter BlendParameters
		{
			get{ CheckIsValid();return (FBlendParameter)Marshal.PtrToStructure(_this.Get()+BlendParameters__Offset, typeof(FBlendParameter));}
			
		}
		
		static readonly int InterpolationParam__Offset;
		public FInterpolationParameter InterpolationParam
		{
			get{ CheckIsValid();return (FInterpolationParameter)Marshal.PtrToStructure(_this.Get()+InterpolationParam__Offset, typeof(FInterpolationParameter));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InterpolationParam__Offset, false);}
			
		}
		
		static readonly int TargetWeightInterpolationSpeedPerSec__Offset;
		public float TargetWeightInterpolationSpeedPerSec
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TargetWeightInterpolationSpeedPerSec__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TargetWeightInterpolationSpeedPerSec__Offset, false);}
			
		}
		
		static readonly int NotifyTriggerMode__Offset;
		public ENotifyTriggerMode NotifyTriggerMode
		{
			get{ CheckIsValid();return (ENotifyTriggerMode)Marshal.PtrToStructure(_this.Get()+NotifyTriggerMode__Offset, typeof(ENotifyTriggerMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NotifyTriggerMode__Offset, false);}
			
		}
		
		static readonly int bRotationBlendInMeshSpace__Offset;
		public bool bRotationBlendInMeshSpace
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRotationBlendInMeshSpace__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int NumOfDimension__Offset;
		public int NumOfDimension
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NumOfDimension__Offset, typeof(int));}
			
		}
		
		static readonly int AnimLength__Offset;
		public float AnimLength
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AnimLength__Offset, typeof(float));}
			
		}
		
		static readonly int PerBoneBlend__Offset;
		public TStructArray<FPerBoneInterpolation> PerBoneBlend
		{
			get{ CheckIsValid();return new TStructArray<FPerBoneInterpolation>((FScriptArray)Marshal.PtrToStructure(_this.Get()+PerBoneBlend__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+PerBoneBlend__Offset, false);}
			
		}
		
		static readonly int SampleData__Offset;
		public TStructArray<FBlendSample> SampleData
		{
			get{ CheckIsValid();return new TStructArray<FBlendSample>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SampleData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SampleData__Offset, false);}
			
		}
		
		static readonly int GridSamples__Offset;
		public TStructArray<FEditorElement> GridSamples
		{
			get{ CheckIsValid();return new TStructArray<FEditorElement>((FScriptArray)Marshal.PtrToStructure(_this.Get()+GridSamples__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+GridSamples__Offset, false);}
			
		}
		
		static UBlendSpaceBase()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("BlendSpaceBase");
			BlendParameters__Offset=GetPropertyOffset(NativeClassPtr,"BlendParameters");
			InterpolationParam__Offset=GetPropertyOffset(NativeClassPtr,"InterpolationParam");
			TargetWeightInterpolationSpeedPerSec__Offset=GetPropertyOffset(NativeClassPtr,"TargetWeightInterpolationSpeedPerSec");
			NotifyTriggerMode__Offset=GetPropertyOffset(NativeClassPtr,"NotifyTriggerMode");
			bRotationBlendInMeshSpace__Offset=GetPropertyOffset(NativeClassPtr,"bRotationBlendInMeshSpace");
			NumOfDimension__Offset=GetPropertyOffset(NativeClassPtr,"NumOfDimension");
			AnimLength__Offset=GetPropertyOffset(NativeClassPtr,"AnimLength");
			PerBoneBlend__Offset=GetPropertyOffset(NativeClassPtr,"PerBoneBlend");
			SampleData__Offset=GetPropertyOffset(NativeClassPtr,"SampleData");
			GridSamples__Offset=GetPropertyOffset(NativeClassPtr,"GridSamples");
			
		}
		
	}
	
}
#endif
#endif
