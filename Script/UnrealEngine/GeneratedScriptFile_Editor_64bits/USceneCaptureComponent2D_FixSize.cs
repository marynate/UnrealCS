#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Used to capture a 'snapshot' of the scene from a single plane and feed it to a render target.</summary>
	public partial class USceneCaptureComponent2D
	{
		static readonly int ProjectionType__Offset;
		public ECameraProjectionMode ProjectionType
		{
			get{ CheckIsValid();return (ECameraProjectionMode)Marshal.PtrToStructure(_this.Get()+ProjectionType__Offset, typeof(ECameraProjectionMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ProjectionType__Offset, false);}
			
		}
		
		static readonly int FOVAngle__Offset;
		/// <summary>Camera field of view (in degrees).</summary>
		public float FOVAngle
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FOVAngle__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FOVAngle__Offset, false);}
			
		}
		
		static readonly int OrthoWidth__Offset;
		/// <summary>The desired width (in world units) of the orthographic view (ignored in Perspective mode)</summary>
		public float OrthoWidth
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+OrthoWidth__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OrthoWidth__Offset, false);}
			
		}
		
		static readonly int TextureTarget__Offset;
		/// <summary>Output render target of the scene capture that can be read in materals.</summary>
		public UTextureRenderTarget2D TextureTarget
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + TextureTarget__Offset); if (v == IntPtr.Zero)return null; UTextureRenderTarget2D retValue = new UTextureRenderTarget2D(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + TextureTarget__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + TextureTarget__Offset, value._this.Get()); }
			
		}
		
		static readonly int CaptureSource__Offset;
		public ESceneCaptureSource CaptureSource
		{
			get{ CheckIsValid();return (ESceneCaptureSource)Marshal.PtrToStructure(_this.Get()+CaptureSource__Offset, typeof(ESceneCaptureSource));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CaptureSource__Offset, false);}
			
		}
		
		static readonly int CompositeMode__Offset;
		/// <summary>When enabled, the scene capture will composite into the render target instead of overwriting its contents.</summary>
		public ESceneCaptureCompositeMode CompositeMode
		{
			get{ CheckIsValid();return (ESceneCaptureCompositeMode)Marshal.PtrToStructure(_this.Get()+CompositeMode__Offset, typeof(ESceneCaptureCompositeMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CompositeMode__Offset, false);}
			
		}
		
		static readonly int PostProcessSettings__Offset;
		public FPostProcessSettings PostProcessSettings
		{
			get{ CheckIsValid();return (FPostProcessSettings)Marshal.PtrToStructure(_this.Get()+PostProcessSettings__Offset, typeof(FPostProcessSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PostProcessSettings__Offset, false);}
			
		}
		
		static readonly int PostProcessBlendWeight__Offset;
		/// <summary>Range (0.0, 1.0) where 0 indicates no effect, 1 indicates full effect.</summary>
		public float PostProcessBlendWeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PostProcessBlendWeight__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PostProcessBlendWeight__Offset, false);}
			
		}
		
		static USceneCaptureComponent2D()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SceneCaptureComponent2D");
			ProjectionType__Offset=GetPropertyOffset(NativeClassPtr,"ProjectionType");
			FOVAngle__Offset=GetPropertyOffset(NativeClassPtr,"FOVAngle");
			OrthoWidth__Offset=GetPropertyOffset(NativeClassPtr,"OrthoWidth");
			TextureTarget__Offset=GetPropertyOffset(NativeClassPtr,"TextureTarget");
			CaptureSource__Offset=GetPropertyOffset(NativeClassPtr,"CaptureSource");
			CompositeMode__Offset=GetPropertyOffset(NativeClassPtr,"CompositeMode");
			PostProcessSettings__Offset=GetPropertyOffset(NativeClassPtr,"PostProcessSettings");
			PostProcessBlendWeight__Offset=GetPropertyOffset(NativeClassPtr,"PostProcessBlendWeight");
			
		}
		
	}
	
}
#endif
#endif
