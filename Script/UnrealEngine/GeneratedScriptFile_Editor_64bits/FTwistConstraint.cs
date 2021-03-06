#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Angular roll constraint</summary>
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FTwistConstraint
	{
		/// <summary>Symmetric angle of roll along the X-axis.</summary>
		[FieldOffset(20)]
		public float TwistLimitDegrees;
		/// <summary>Indicates whether the Swing1 limit is used.</summary>
		[FieldOffset(24)]
		public EAngularConstraintMotion TwistMotion;
		/// <summary>Stiffness of the soft constraint. Only used when Soft Constraint is on.</summary>
		[FieldOffset(0)]
		public float Stiffness;
		/// <summary>Damping of the soft constraint. Only used when Soft Constraint is on.</summary>
		[FieldOffset(4)]
		public float Damping;
		/// <summary>Controls the amount of bounce when the constraint is violated. A restitution value of 1 will bounce back with the same velocity the limit was hit. A value of 0 will stop dead.</summary>
		[FieldOffset(8)]
		public float Restitution;
		/// <summary>Determines how close to the limit we have to get before turning the joint on. Larger value will be more expensive, but will do a better job not violating constraints. A smaller value will be more efficient, but easier to violate.</summary>
		[FieldOffset(12)]
		public float ContactDistance;
		/// <summary>Whether we want to use a soft constraint (spring).</summary>
		public bool bSoftConstraint
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 1, 1); } }}
			
		}
		
	}
	
}
#endif
#endif
