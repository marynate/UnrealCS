#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A Level is a collection of Actors (lights, volumes, mesh instances etc.).
	/// Multiple Levels can be loaded and unloaded into the World to create a streaming experience.
	/// @see https://docs.unrealengine.com/latest/INT/Engine/Levels
	/// @see UActor
	/// </summary>
	public partial class ULevel
	{
		static readonly int OwningWorld__Offset;
		/// <summary>
		/// The World that has this level in its Levels array.
		/// This is not the same as GetOuter(), because GetOuter() for a streaming level is a vestigial world that is not used.
		/// It should not be accessed during BeginDestroy(), just like any other UObject references, since GC may occur in any order.
		/// </summary>
		public UWorld OwningWorld
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + OwningWorld__Offset); if (v == IntPtr.Zero)return null; UWorld retValue = new UWorld(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Model__Offset;
		/// <summary>BSP UModel.</summary>
		public UModel Model
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Model__Offset); if (v == IntPtr.Zero)return null; UModel retValue = new UModel(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ModelComponents__Offset;
		/// <summary>BSP Model components used for rendering.</summary>
		public TObjectArray<UModelComponent>  ModelComponents
		{
					get{ CheckIsValid();return new TObjectArray<UModelComponent>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ModelComponents__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ModelComponents__Offset, false);}
			
		}
		
		static readonly int LevelScriptBlueprint__Offset;
		/// <summary>Reference to the blueprint for level scripting</summary>
		public ULevelScriptBlueprint LevelScriptBlueprint
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LevelScriptBlueprint__Offset); if (v == IntPtr.Zero)return null; ULevelScriptBlueprint retValue = new ULevelScriptBlueprint(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int LevelScriptActor__Offset;
		/// <summary>The level scripting actor, created by instantiating the class from LevelScriptBlueprint.  This handles all level scripting</summary>
		public ALevelScriptActor LevelScriptActor
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LevelScriptActor__Offset); if (v == IntPtr.Zero)return null; ALevelScriptActor retValue = new ALevelScriptActor(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int NavListStart__Offset;
		/// <summary>
		/// Start and end of the navigation list for this level, used for quickly fixing up
		/// when streaming this level in/out. @TODO DEPRECATED - DELETE
		/// </summary>
		public ANavigationObjectBase NavListStart
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + NavListStart__Offset); if (v == IntPtr.Zero)return null; ANavigationObjectBase retValue = new ANavigationObjectBase(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int NavListEnd__Offset;
		public ANavigationObjectBase NavListEnd
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + NavListEnd__Offset); if (v == IntPtr.Zero)return null; ANavigationObjectBase retValue = new ANavigationObjectBase(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int NavDataChunks__Offset;
		/// <summary>Navigation related data that can be stored per level</summary>
		public TObjectArray<UNavigationDataChunk>  NavDataChunks
		{
					get{ CheckIsValid();return new TObjectArray<UNavigationDataChunk>((FScriptArray)Marshal.PtrToStructure(_this.Get()+NavDataChunks__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+NavDataChunks__Offset, false);}
			
		}
		
		static readonly int LightmapTotalSize__Offset;
		/// <summary>Total number of KB used for lightmap textures in the level.</summary>
		public float LightmapTotalSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LightmapTotalSize__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightmapTotalSize__Offset, false);}
			
		}
		
		static readonly int ShadowmapTotalSize__Offset;
		/// <summary>Total number of KB used for shadowmap textures in the level.</summary>
		public float ShadowmapTotalSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ShadowmapTotalSize__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ShadowmapTotalSize__Offset, false);}
			
		}
		
		static readonly int StaticNavigableGeometry__Offset;
		/// <summary>
		/// threes of triangle vertices - AABB filtering friendly. Stored if there's a runtime need to rebuild navigation that accepts BSPs
		///     as well - it's a lot easier this way than retrieve this data at runtime
		/// </summary>
		public TStructArray<FVector> StaticNavigableGeometry
		{
			get{ CheckIsValid();return new TStructArray<FVector>((FScriptArray)Marshal.PtrToStructure(_this.Get()+StaticNavigableGeometry__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+StaticNavigableGeometry__Offset, false);}
			
		}
		
		static readonly int StreamingTextureGuids__Offset;
		/// <summary>The Guid of each texture refered by FStreamingTextureBuildInfo::TextureLevelIndex</summary>
		public TStructArray<FGuid> StreamingTextureGuids
		{
			get{ CheckIsValid();return new TStructArray<FGuid>((FScriptArray)Marshal.PtrToStructure(_this.Get()+StreamingTextureGuids__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+StreamingTextureGuids__Offset, false);}
			
		}
		
		static readonly int bTextureStreamingRotationChanged__Offset;
		/// <summary>Whether a level transform rotation was applied since the texture streaming builds. Invalidates the precomputed streaming bounds.</summary>
		public bool bTextureStreamingRotationChanged
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTextureStreamingRotationChanged__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bIsVisible__Offset;
		/// <summary>Whether the level is currently visible/ associated with the world</summary>
		public bool bIsVisible
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsVisible__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bLocked__Offset;
		/// <summary>
		/// Whether this level is locked; that is, its actors are read-only
		///     Used by WorldBrowser to lock a level when corresponding ULevelStreaming does not exist
		/// </summary>
		public bool bLocked
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLocked__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int LevelSimplification__Offset;
		/// <summary>Level simplification settings for each LOD</summary>
		public FLevelSimplificationDetails LevelSimplification
		{
			get{ CheckIsValid();return (FLevelSimplificationDetails)Marshal.PtrToStructure(_this.Get()+LevelSimplification__Offset, typeof(FLevelSimplificationDetails));}
			
		}
		
		static readonly int LevelColor__Offset;
		/// <summary>
		/// The level color used for visualization. (Show -> Advanced -> Level Coloration)
		/// Used only in world composition mode
		/// </summary>
		public FLinearColor LevelColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+LevelColor__Offset, typeof(FLinearColor));}
			
		}
		
		static readonly int WorldSettings__Offset;
		public AWorldSettings WorldSettings
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + WorldSettings__Offset); if (v == IntPtr.Zero)return null; AWorldSettings retValue = new AWorldSettings(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AssetUserData__Offset;
		/// <summary>Array of user data stored with the asset</summary>
		public TObjectArray<UAssetUserData>  AssetUserData
		{
					get{ CheckIsValid();return new TObjectArray<UAssetUserData>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AssetUserData__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AssetUserData__Offset, false);}
			
		}
		
		static ULevel()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Level");
			OwningWorld__Offset=GetPropertyOffset(NativeClassPtr,"OwningWorld");
			Model__Offset=GetPropertyOffset(NativeClassPtr,"Model");
			ModelComponents__Offset=GetPropertyOffset(NativeClassPtr,"ModelComponents");
			LevelScriptBlueprint__Offset=GetPropertyOffset(NativeClassPtr,"LevelScriptBlueprint");
			LevelScriptActor__Offset=GetPropertyOffset(NativeClassPtr,"LevelScriptActor");
			NavListStart__Offset=GetPropertyOffset(NativeClassPtr,"NavListStart");
			NavListEnd__Offset=GetPropertyOffset(NativeClassPtr,"NavListEnd");
			NavDataChunks__Offset=GetPropertyOffset(NativeClassPtr,"NavDataChunks");
			LightmapTotalSize__Offset=GetPropertyOffset(NativeClassPtr,"LightmapTotalSize");
			ShadowmapTotalSize__Offset=GetPropertyOffset(NativeClassPtr,"ShadowmapTotalSize");
			StaticNavigableGeometry__Offset=GetPropertyOffset(NativeClassPtr,"StaticNavigableGeometry");
			StreamingTextureGuids__Offset=GetPropertyOffset(NativeClassPtr,"StreamingTextureGuids");
			bTextureStreamingRotationChanged__Offset=GetPropertyOffset(NativeClassPtr,"bTextureStreamingRotationChanged");
			bIsVisible__Offset=GetPropertyOffset(NativeClassPtr,"bIsVisible");
			bLocked__Offset=GetPropertyOffset(NativeClassPtr,"bLocked");
			LevelSimplification__Offset=GetPropertyOffset(NativeClassPtr,"LevelSimplification");
			LevelColor__Offset=GetPropertyOffset(NativeClassPtr,"LevelColor");
			WorldSettings__Offset=GetPropertyOffset(NativeClassPtr,"WorldSettings");
			AssetUserData__Offset=GetPropertyOffset(NativeClassPtr,"AssetUserData");
			
		}
		
	}
	
}
#endif
#endif
