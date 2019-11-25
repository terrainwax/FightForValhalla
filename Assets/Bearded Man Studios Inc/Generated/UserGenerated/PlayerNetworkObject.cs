using BeardedManStudios.Forge.Networking.Frame;
using BeardedManStudios.Forge.Networking.Unity;
using System;
using UnityEngine;

namespace BeardedManStudios.Forge.Networking.Generated
{
	[GeneratedInterpol("{\"inter\":[0.15,0,0,0,0,0,0,0]")]
	public partial class PlayerNetworkObject : NetworkObject
	{
		public const int IDENTITY = 5;

		private byte[] _dirtyFields = new byte[1];

		#pragma warning disable 0067
		public event FieldChangedEvent fieldAltered;
		#pragma warning restore 0067
		[ForgeGeneratedField]
		private Vector3 _position;
		public event FieldEvent<Vector3> positionChanged;
		public InterpolateVector3 positionInterpolation = new InterpolateVector3() { LerpT = 0.15f, Enabled = true };
		public Vector3 position
		{
			get { return _position; }
			set
			{
				// Don't do anything if the value is the same
				if (_position == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x1;
				_position = value;
				hasDirtyFields = true;
			}
		}

		public void SetpositionDirty()
		{
			_dirtyFields[0] |= 0x1;
			hasDirtyFields = true;
		}

		private void RunChange_position(ulong timestep)
		{
			if (positionChanged != null) positionChanged(_position, timestep);
			if (fieldAltered != null) fieldAltered("position", _position, timestep);
		}
		[ForgeGeneratedField]
		private Quaternion _rotation;
		public event FieldEvent<Quaternion> rotationChanged;
		public InterpolateQuaternion rotationInterpolation = new InterpolateQuaternion() { LerpT = 0f, Enabled = false };
		public Quaternion rotation
		{
			get { return _rotation; }
			set
			{
				// Don't do anything if the value is the same
				if (_rotation == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x2;
				_rotation = value;
				hasDirtyFields = true;
			}
		}

		public void SetrotationDirty()
		{
			_dirtyFields[0] |= 0x2;
			hasDirtyFields = true;
		}

		private void RunChange_rotation(ulong timestep)
		{
			if (rotationChanged != null) rotationChanged(_rotation, timestep);
			if (fieldAltered != null) fieldAltered("rotation", _rotation, timestep);
		}
		[ForgeGeneratedField]
		private float _Forward;
		public event FieldEvent<float> ForwardChanged;
		public InterpolateFloat ForwardInterpolation = new InterpolateFloat() { LerpT = 0f, Enabled = false };
		public float Forward
		{
			get { return _Forward; }
			set
			{
				// Don't do anything if the value is the same
				if (_Forward == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x4;
				_Forward = value;
				hasDirtyFields = true;
			}
		}

		public void SetForwardDirty()
		{
			_dirtyFields[0] |= 0x4;
			hasDirtyFields = true;
		}

		private void RunChange_Forward(ulong timestep)
		{
			if (ForwardChanged != null) ForwardChanged(_Forward, timestep);
			if (fieldAltered != null) fieldAltered("Forward", _Forward, timestep);
		}
		[ForgeGeneratedField]
		private float _Strafing;
		public event FieldEvent<float> StrafingChanged;
		public InterpolateFloat StrafingInterpolation = new InterpolateFloat() { LerpT = 0f, Enabled = false };
		public float Strafing
		{
			get { return _Strafing; }
			set
			{
				// Don't do anything if the value is the same
				if (_Strafing == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x8;
				_Strafing = value;
				hasDirtyFields = true;
			}
		}

		public void SetStrafingDirty()
		{
			_dirtyFields[0] |= 0x8;
			hasDirtyFields = true;
		}

		private void RunChange_Strafing(ulong timestep)
		{
			if (StrafingChanged != null) StrafingChanged(_Strafing, timestep);
			if (fieldAltered != null) fieldAltered("Strafing", _Strafing, timestep);
		}
		[ForgeGeneratedField]
		private bool _Attacking;
		public event FieldEvent<bool> AttackingChanged;
		public Interpolated<bool> AttackingInterpolation = new Interpolated<bool>() { LerpT = 0f, Enabled = false };
		public bool Attacking
		{
			get { return _Attacking; }
			set
			{
				// Don't do anything if the value is the same
				if (_Attacking == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x10;
				_Attacking = value;
				hasDirtyFields = true;
			}
		}

		public void SetAttackingDirty()
		{
			_dirtyFields[0] |= 0x10;
			hasDirtyFields = true;
		}

		private void RunChange_Attacking(ulong timestep)
		{
			if (AttackingChanged != null) AttackingChanged(_Attacking, timestep);
			if (fieldAltered != null) fieldAltered("Attacking", _Attacking, timestep);
		}
		[ForgeGeneratedField]
		private bool _Jumping;
		public event FieldEvent<bool> JumpingChanged;
		public Interpolated<bool> JumpingInterpolation = new Interpolated<bool>() { LerpT = 0f, Enabled = false };
		public bool Jumping
		{
			get { return _Jumping; }
			set
			{
				// Don't do anything if the value is the same
				if (_Jumping == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x20;
				_Jumping = value;
				hasDirtyFields = true;
			}
		}

		public void SetJumpingDirty()
		{
			_dirtyFields[0] |= 0x20;
			hasDirtyFields = true;
		}

		private void RunChange_Jumping(ulong timestep)
		{
			if (JumpingChanged != null) JumpingChanged(_Jumping, timestep);
			if (fieldAltered != null) fieldAltered("Jumping", _Jumping, timestep);
		}
		[ForgeGeneratedField]
		private bool _Sprinting;
		public event FieldEvent<bool> SprintingChanged;
		public Interpolated<bool> SprintingInterpolation = new Interpolated<bool>() { LerpT = 0f, Enabled = false };
		public bool Sprinting
		{
			get { return _Sprinting; }
			set
			{
				// Don't do anything if the value is the same
				if (_Sprinting == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x40;
				_Sprinting = value;
				hasDirtyFields = true;
			}
		}

		public void SetSprintingDirty()
		{
			_dirtyFields[0] |= 0x40;
			hasDirtyFields = true;
		}

		private void RunChange_Sprinting(ulong timestep)
		{
			if (SprintingChanged != null) SprintingChanged(_Sprinting, timestep);
			if (fieldAltered != null) fieldAltered("Sprinting", _Sprinting, timestep);
		}
		[ForgeGeneratedField]
		private bool _Grounded;
		public event FieldEvent<bool> GroundedChanged;
		public Interpolated<bool> GroundedInterpolation = new Interpolated<bool>() { LerpT = 0f, Enabled = false };
		public bool Grounded
		{
			get { return _Grounded; }
			set
			{
				// Don't do anything if the value is the same
				if (_Grounded == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x80;
				_Grounded = value;
				hasDirtyFields = true;
			}
		}

		public void SetGroundedDirty()
		{
			_dirtyFields[0] |= 0x80;
			hasDirtyFields = true;
		}

		private void RunChange_Grounded(ulong timestep)
		{
			if (GroundedChanged != null) GroundedChanged(_Grounded, timestep);
			if (fieldAltered != null) fieldAltered("Grounded", _Grounded, timestep);
		}

		protected override void OwnershipChanged()
		{
			base.OwnershipChanged();
			SnapInterpolations();
		}
		
		public void SnapInterpolations()
		{
			positionInterpolation.current = positionInterpolation.target;
			rotationInterpolation.current = rotationInterpolation.target;
			ForwardInterpolation.current = ForwardInterpolation.target;
			StrafingInterpolation.current = StrafingInterpolation.target;
			AttackingInterpolation.current = AttackingInterpolation.target;
			JumpingInterpolation.current = JumpingInterpolation.target;
			SprintingInterpolation.current = SprintingInterpolation.target;
			GroundedInterpolation.current = GroundedInterpolation.target;
		}

		public override int UniqueIdentity { get { return IDENTITY; } }

		protected override BMSByte WritePayload(BMSByte data)
		{
			UnityObjectMapper.Instance.MapBytes(data, _position);
			UnityObjectMapper.Instance.MapBytes(data, _rotation);
			UnityObjectMapper.Instance.MapBytes(data, _Forward);
			UnityObjectMapper.Instance.MapBytes(data, _Strafing);
			UnityObjectMapper.Instance.MapBytes(data, _Attacking);
			UnityObjectMapper.Instance.MapBytes(data, _Jumping);
			UnityObjectMapper.Instance.MapBytes(data, _Sprinting);
			UnityObjectMapper.Instance.MapBytes(data, _Grounded);

			return data;
		}

		protected override void ReadPayload(BMSByte payload, ulong timestep)
		{
			_position = UnityObjectMapper.Instance.Map<Vector3>(payload);
			positionInterpolation.current = _position;
			positionInterpolation.target = _position;
			RunChange_position(timestep);
			_rotation = UnityObjectMapper.Instance.Map<Quaternion>(payload);
			rotationInterpolation.current = _rotation;
			rotationInterpolation.target = _rotation;
			RunChange_rotation(timestep);
			_Forward = UnityObjectMapper.Instance.Map<float>(payload);
			ForwardInterpolation.current = _Forward;
			ForwardInterpolation.target = _Forward;
			RunChange_Forward(timestep);
			_Strafing = UnityObjectMapper.Instance.Map<float>(payload);
			StrafingInterpolation.current = _Strafing;
			StrafingInterpolation.target = _Strafing;
			RunChange_Strafing(timestep);
			_Attacking = UnityObjectMapper.Instance.Map<bool>(payload);
			AttackingInterpolation.current = _Attacking;
			AttackingInterpolation.target = _Attacking;
			RunChange_Attacking(timestep);
			_Jumping = UnityObjectMapper.Instance.Map<bool>(payload);
			JumpingInterpolation.current = _Jumping;
			JumpingInterpolation.target = _Jumping;
			RunChange_Jumping(timestep);
			_Sprinting = UnityObjectMapper.Instance.Map<bool>(payload);
			SprintingInterpolation.current = _Sprinting;
			SprintingInterpolation.target = _Sprinting;
			RunChange_Sprinting(timestep);
			_Grounded = UnityObjectMapper.Instance.Map<bool>(payload);
			GroundedInterpolation.current = _Grounded;
			GroundedInterpolation.target = _Grounded;
			RunChange_Grounded(timestep);
		}

		protected override BMSByte SerializeDirtyFields()
		{
			dirtyFieldsData.Clear();
			dirtyFieldsData.Append(_dirtyFields);

			if ((0x1 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _position);
			if ((0x2 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _rotation);
			if ((0x4 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _Forward);
			if ((0x8 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _Strafing);
			if ((0x10 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _Attacking);
			if ((0x20 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _Jumping);
			if ((0x40 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _Sprinting);
			if ((0x80 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _Grounded);

			// Reset all the dirty fields
			for (int i = 0; i < _dirtyFields.Length; i++)
				_dirtyFields[i] = 0;

			return dirtyFieldsData;
		}

		protected override void ReadDirtyFields(BMSByte data, ulong timestep)
		{
			if (readDirtyFlags == null)
				Initialize();

			Buffer.BlockCopy(data.byteArr, data.StartIndex(), readDirtyFlags, 0, readDirtyFlags.Length);
			data.MoveStartIndex(readDirtyFlags.Length);

			if ((0x1 & readDirtyFlags[0]) != 0)
			{
				if (positionInterpolation.Enabled)
				{
					positionInterpolation.target = UnityObjectMapper.Instance.Map<Vector3>(data);
					positionInterpolation.Timestep = timestep;
				}
				else
				{
					_position = UnityObjectMapper.Instance.Map<Vector3>(data);
					RunChange_position(timestep);
				}
			}
			if ((0x2 & readDirtyFlags[0]) != 0)
			{
				if (rotationInterpolation.Enabled)
				{
					rotationInterpolation.target = UnityObjectMapper.Instance.Map<Quaternion>(data);
					rotationInterpolation.Timestep = timestep;
				}
				else
				{
					_rotation = UnityObjectMapper.Instance.Map<Quaternion>(data);
					RunChange_rotation(timestep);
				}
			}
			if ((0x4 & readDirtyFlags[0]) != 0)
			{
				if (ForwardInterpolation.Enabled)
				{
					ForwardInterpolation.target = UnityObjectMapper.Instance.Map<float>(data);
					ForwardInterpolation.Timestep = timestep;
				}
				else
				{
					_Forward = UnityObjectMapper.Instance.Map<float>(data);
					RunChange_Forward(timestep);
				}
			}
			if ((0x8 & readDirtyFlags[0]) != 0)
			{
				if (StrafingInterpolation.Enabled)
				{
					StrafingInterpolation.target = UnityObjectMapper.Instance.Map<float>(data);
					StrafingInterpolation.Timestep = timestep;
				}
				else
				{
					_Strafing = UnityObjectMapper.Instance.Map<float>(data);
					RunChange_Strafing(timestep);
				}
			}
			if ((0x10 & readDirtyFlags[0]) != 0)
			{
				if (AttackingInterpolation.Enabled)
				{
					AttackingInterpolation.target = UnityObjectMapper.Instance.Map<bool>(data);
					AttackingInterpolation.Timestep = timestep;
				}
				else
				{
					_Attacking = UnityObjectMapper.Instance.Map<bool>(data);
					RunChange_Attacking(timestep);
				}
			}
			if ((0x20 & readDirtyFlags[0]) != 0)
			{
				if (JumpingInterpolation.Enabled)
				{
					JumpingInterpolation.target = UnityObjectMapper.Instance.Map<bool>(data);
					JumpingInterpolation.Timestep = timestep;
				}
				else
				{
					_Jumping = UnityObjectMapper.Instance.Map<bool>(data);
					RunChange_Jumping(timestep);
				}
			}
			if ((0x40 & readDirtyFlags[0]) != 0)
			{
				if (SprintingInterpolation.Enabled)
				{
					SprintingInterpolation.target = UnityObjectMapper.Instance.Map<bool>(data);
					SprintingInterpolation.Timestep = timestep;
				}
				else
				{
					_Sprinting = UnityObjectMapper.Instance.Map<bool>(data);
					RunChange_Sprinting(timestep);
				}
			}
			if ((0x80 & readDirtyFlags[0]) != 0)
			{
				if (GroundedInterpolation.Enabled)
				{
					GroundedInterpolation.target = UnityObjectMapper.Instance.Map<bool>(data);
					GroundedInterpolation.Timestep = timestep;
				}
				else
				{
					_Grounded = UnityObjectMapper.Instance.Map<bool>(data);
					RunChange_Grounded(timestep);
				}
			}
		}

		public override void InterpolateUpdate()
		{
			if (IsOwner)
				return;

			if (positionInterpolation.Enabled && !positionInterpolation.current.UnityNear(positionInterpolation.target, 0.0015f))
			{
				_position = (Vector3)positionInterpolation.Interpolate();
				//RunChange_position(positionInterpolation.Timestep);
			}
			if (rotationInterpolation.Enabled && !rotationInterpolation.current.UnityNear(rotationInterpolation.target, 0.0015f))
			{
				_rotation = (Quaternion)rotationInterpolation.Interpolate();
				//RunChange_rotation(rotationInterpolation.Timestep);
			}
			if (ForwardInterpolation.Enabled && !ForwardInterpolation.current.UnityNear(ForwardInterpolation.target, 0.0015f))
			{
				_Forward = (float)ForwardInterpolation.Interpolate();
				//RunChange_Forward(ForwardInterpolation.Timestep);
			}
			if (StrafingInterpolation.Enabled && !StrafingInterpolation.current.UnityNear(StrafingInterpolation.target, 0.0015f))
			{
				_Strafing = (float)StrafingInterpolation.Interpolate();
				//RunChange_Strafing(StrafingInterpolation.Timestep);
			}
			if (AttackingInterpolation.Enabled && !AttackingInterpolation.current.UnityNear(AttackingInterpolation.target, 0.0015f))
			{
				_Attacking = (bool)AttackingInterpolation.Interpolate();
				//RunChange_Attacking(AttackingInterpolation.Timestep);
			}
			if (JumpingInterpolation.Enabled && !JumpingInterpolation.current.UnityNear(JumpingInterpolation.target, 0.0015f))
			{
				_Jumping = (bool)JumpingInterpolation.Interpolate();
				//RunChange_Jumping(JumpingInterpolation.Timestep);
			}
			if (SprintingInterpolation.Enabled && !SprintingInterpolation.current.UnityNear(SprintingInterpolation.target, 0.0015f))
			{
				_Sprinting = (bool)SprintingInterpolation.Interpolate();
				//RunChange_Sprinting(SprintingInterpolation.Timestep);
			}
			if (GroundedInterpolation.Enabled && !GroundedInterpolation.current.UnityNear(GroundedInterpolation.target, 0.0015f))
			{
				_Grounded = (bool)GroundedInterpolation.Interpolate();
				//RunChange_Grounded(GroundedInterpolation.Timestep);
			}
		}

		private void Initialize()
		{
			if (readDirtyFlags == null)
				readDirtyFlags = new byte[1];

		}

		public PlayerNetworkObject() : base() { Initialize(); }
		public PlayerNetworkObject(NetWorker networker, INetworkBehavior networkBehavior = null, int createCode = 0, byte[] metadata = null) : base(networker, networkBehavior, createCode, metadata) { Initialize(); }
		public PlayerNetworkObject(NetWorker networker, uint serverId, FrameStream frame) : base(networker, serverId, frame) { Initialize(); }

		// DO NOT TOUCH, THIS GETS GENERATED PLEASE EXTEND THIS CLASS IF YOU WISH TO HAVE CUSTOM CODE ADDITIONS
	}
}
