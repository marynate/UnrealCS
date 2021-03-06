using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Defines available strategies for handling the case where an actor is spawned in such a way that it penetrates blocking collision.</summary>
	public enum ESpawnActorCollisionHandlingMethod:byte
	{
		/// <summary>Fall back to default settings.</summary>
		Undefined=0,
		/// <summary>Actor will spawn in desired location, regardless of collisions.</summary>
		AlwaysSpawn=1,
		/// <summary>Actor will try to find a nearby non-colliding location (based on shape components), but will always spawn even if one cannot be found.</summary>
		AdjustIfPossibleButAlwaysSpawn=2,
		/// <summary>Actor will try to find a nearby non-colliding location (based on shape components), but will NOT spawn unless one is found.</summary>
		AdjustIfPossibleButDontSpawnIfColliding=3,
		/// <summary>Actor will fail to spawn.</summary>
		DontSpawnIfColliding=4,
		ESpawnActorCollisionHandlingMethod_MAX=5,
		
	}
	
}
