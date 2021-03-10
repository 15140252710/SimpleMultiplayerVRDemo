using BeardedManStudios.Forge.Networking.Frame;
using BeardedManStudios.Forge.Networking.Unity;
using System;
using UnityEngine;

namespace BeardedManStudios.Forge.Networking.Generated
{
	[GeneratedInterpol("{\"inter\":[0.15,0.15,0.15,0.15,0.15,0.15,0.15,0.15,0,0]")]
	public partial class VRPlayerNetworkObject : NetworkObject
	{
		public const int IDENTITY = 9;

		private byte[] _dirtyFields = new byte[2];

		#pragma warning disable 0067
		public event FieldChangedEvent fieldAltered;
		#pragma warning restore 0067
		[ForgeGeneratedField]
		private Vector3 _playerPos;
		public event FieldEvent<Vector3> playerPosChanged;
		public InterpolateVector3 playerPosInterpolation = new InterpolateVector3() { LerpT = 0.15f, Enabled = true };
		public Vector3 playerPos
		{
			get { return _playerPos; }
			set
			{
				// Don't do anything if the value is the same
				if (_playerPos == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x1;
				_playerPos = value;
				hasDirtyFields = true;
			}
		}

		public void SetplayerPosDirty()
		{
			_dirtyFields[0] |= 0x1;
			hasDirtyFields = true;
		}

		private void RunChange_playerPos(ulong timestep)
		{
			if (playerPosChanged != null) playerPosChanged(_playerPos, timestep);
			if (fieldAltered != null) fieldAltered("playerPos", _playerPos, timestep);
		}
		[ForgeGeneratedField]
		private Quaternion _playerRot;
		public event FieldEvent<Quaternion> playerRotChanged;
		public InterpolateQuaternion playerRotInterpolation = new InterpolateQuaternion() { LerpT = 0.15f, Enabled = true };
		public Quaternion playerRot
		{
			get { return _playerRot; }
			set
			{
				// Don't do anything if the value is the same
				if (_playerRot == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x2;
				_playerRot = value;
				hasDirtyFields = true;
			}
		}

		public void SetplayerRotDirty()
		{
			_dirtyFields[0] |= 0x2;
			hasDirtyFields = true;
		}

		private void RunChange_playerRot(ulong timestep)
		{
			if (playerRotChanged != null) playerRotChanged(_playerRot, timestep);
			if (fieldAltered != null) fieldAltered("playerRot", _playerRot, timestep);
		}
		[ForgeGeneratedField]
		private Vector3 _headPos;
		public event FieldEvent<Vector3> headPosChanged;
		public InterpolateVector3 headPosInterpolation = new InterpolateVector3() { LerpT = 0.15f, Enabled = true };
		public Vector3 headPos
		{
			get { return _headPos; }
			set
			{
				// Don't do anything if the value is the same
				if (_headPos == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x4;
				_headPos = value;
				hasDirtyFields = true;
			}
		}

		public void SetheadPosDirty()
		{
			_dirtyFields[0] |= 0x4;
			hasDirtyFields = true;
		}

		private void RunChange_headPos(ulong timestep)
		{
			if (headPosChanged != null) headPosChanged(_headPos, timestep);
			if (fieldAltered != null) fieldAltered("headPos", _headPos, timestep);
		}
		[ForgeGeneratedField]
		private Quaternion _headRot;
		public event FieldEvent<Quaternion> headRotChanged;
		public InterpolateQuaternion headRotInterpolation = new InterpolateQuaternion() { LerpT = 0.15f, Enabled = true };
		public Quaternion headRot
		{
			get { return _headRot; }
			set
			{
				// Don't do anything if the value is the same
				if (_headRot == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x8;
				_headRot = value;
				hasDirtyFields = true;
			}
		}

		public void SetheadRotDirty()
		{
			_dirtyFields[0] |= 0x8;
			hasDirtyFields = true;
		}

		private void RunChange_headRot(ulong timestep)
		{
			if (headRotChanged != null) headRotChanged(_headRot, timestep);
			if (fieldAltered != null) fieldAltered("headRot", _headRot, timestep);
		}
		[ForgeGeneratedField]
		private Vector3 _lHandPos;
		public event FieldEvent<Vector3> lHandPosChanged;
		public InterpolateVector3 lHandPosInterpolation = new InterpolateVector3() { LerpT = 0.15f, Enabled = true };
		public Vector3 lHandPos
		{
			get { return _lHandPos; }
			set
			{
				// Don't do anything if the value is the same
				if (_lHandPos == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x10;
				_lHandPos = value;
				hasDirtyFields = true;
			}
		}

		public void SetlHandPosDirty()
		{
			_dirtyFields[0] |= 0x10;
			hasDirtyFields = true;
		}

		private void RunChange_lHandPos(ulong timestep)
		{
			if (lHandPosChanged != null) lHandPosChanged(_lHandPos, timestep);
			if (fieldAltered != null) fieldAltered("lHandPos", _lHandPos, timestep);
		}
		[ForgeGeneratedField]
		private Quaternion _lHandRot;
		public event FieldEvent<Quaternion> lHandRotChanged;
		public InterpolateQuaternion lHandRotInterpolation = new InterpolateQuaternion() { LerpT = 0.15f, Enabled = true };
		public Quaternion lHandRot
		{
			get { return _lHandRot; }
			set
			{
				// Don't do anything if the value is the same
				if (_lHandRot == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x20;
				_lHandRot = value;
				hasDirtyFields = true;
			}
		}

		public void SetlHandRotDirty()
		{
			_dirtyFields[0] |= 0x20;
			hasDirtyFields = true;
		}

		private void RunChange_lHandRot(ulong timestep)
		{
			if (lHandRotChanged != null) lHandRotChanged(_lHandRot, timestep);
			if (fieldAltered != null) fieldAltered("lHandRot", _lHandRot, timestep);
		}
		[ForgeGeneratedField]
		private Vector3 _rHandPos;
		public event FieldEvent<Vector3> rHandPosChanged;
		public InterpolateVector3 rHandPosInterpolation = new InterpolateVector3() { LerpT = 0.15f, Enabled = true };
		public Vector3 rHandPos
		{
			get { return _rHandPos; }
			set
			{
				// Don't do anything if the value is the same
				if (_rHandPos == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x40;
				_rHandPos = value;
				hasDirtyFields = true;
			}
		}

		public void SetrHandPosDirty()
		{
			_dirtyFields[0] |= 0x40;
			hasDirtyFields = true;
		}

		private void RunChange_rHandPos(ulong timestep)
		{
			if (rHandPosChanged != null) rHandPosChanged(_rHandPos, timestep);
			if (fieldAltered != null) fieldAltered("rHandPos", _rHandPos, timestep);
		}
		[ForgeGeneratedField]
		private Quaternion _rHandRot;
		public event FieldEvent<Quaternion> rHandRotChanged;
		public InterpolateQuaternion rHandRotInterpolation = new InterpolateQuaternion() { LerpT = 0.15f, Enabled = true };
		public Quaternion rHandRot
		{
			get { return _rHandRot; }
			set
			{
				// Don't do anything if the value is the same
				if (_rHandRot == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x80;
				_rHandRot = value;
				hasDirtyFields = true;
			}
		}

		public void SetrHandRotDirty()
		{
			_dirtyFields[0] |= 0x80;
			hasDirtyFields = true;
		}

		private void RunChange_rHandRot(ulong timestep)
		{
			if (rHandRotChanged != null) rHandRotChanged(_rHandRot, timestep);
			if (fieldAltered != null) fieldAltered("rHandRot", _rHandRot, timestep);
		}
		[ForgeGeneratedField]
		private bool _lHandActive;
		public event FieldEvent<bool> lHandActiveChanged;
		public Interpolated<bool> lHandActiveInterpolation = new Interpolated<bool>() { LerpT = 0f, Enabled = false };
		public bool lHandActive
		{
			get { return _lHandActive; }
			set
			{
				// Don't do anything if the value is the same
				if (_lHandActive == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[1] |= 0x1;
				_lHandActive = value;
				hasDirtyFields = true;
			}
		}

		public void SetlHandActiveDirty()
		{
			_dirtyFields[1] |= 0x1;
			hasDirtyFields = true;
		}

		private void RunChange_lHandActive(ulong timestep)
		{
			if (lHandActiveChanged != null) lHandActiveChanged(_lHandActive, timestep);
			if (fieldAltered != null) fieldAltered("lHandActive", _lHandActive, timestep);
		}
		[ForgeGeneratedField]
		private bool _rHandActive;
		public event FieldEvent<bool> rHandActiveChanged;
		public Interpolated<bool> rHandActiveInterpolation = new Interpolated<bool>() { LerpT = 0f, Enabled = false };
		public bool rHandActive
		{
			get { return _rHandActive; }
			set
			{
				// Don't do anything if the value is the same
				if (_rHandActive == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[1] |= 0x2;
				_rHandActive = value;
				hasDirtyFields = true;
			}
		}

		public void SetrHandActiveDirty()
		{
			_dirtyFields[1] |= 0x2;
			hasDirtyFields = true;
		}

		private void RunChange_rHandActive(ulong timestep)
		{
			if (rHandActiveChanged != null) rHandActiveChanged(_rHandActive, timestep);
			if (fieldAltered != null) fieldAltered("rHandActive", _rHandActive, timestep);
		}

		protected override void OwnershipChanged()
		{
			base.OwnershipChanged();
			SnapInterpolations();
		}
		
		public void SnapInterpolations()
		{
			playerPosInterpolation.current = playerPosInterpolation.target;
			playerRotInterpolation.current = playerRotInterpolation.target;
			headPosInterpolation.current = headPosInterpolation.target;
			headRotInterpolation.current = headRotInterpolation.target;
			lHandPosInterpolation.current = lHandPosInterpolation.target;
			lHandRotInterpolation.current = lHandRotInterpolation.target;
			rHandPosInterpolation.current = rHandPosInterpolation.target;
			rHandRotInterpolation.current = rHandRotInterpolation.target;
			lHandActiveInterpolation.current = lHandActiveInterpolation.target;
			rHandActiveInterpolation.current = rHandActiveInterpolation.target;
		}

		public override int UniqueIdentity { get { return IDENTITY; } }

		protected override BMSByte WritePayload(BMSByte data)
		{
			UnityObjectMapper.Instance.MapBytes(data, _playerPos);
			UnityObjectMapper.Instance.MapBytes(data, _playerRot);
			UnityObjectMapper.Instance.MapBytes(data, _headPos);
			UnityObjectMapper.Instance.MapBytes(data, _headRot);
			UnityObjectMapper.Instance.MapBytes(data, _lHandPos);
			UnityObjectMapper.Instance.MapBytes(data, _lHandRot);
			UnityObjectMapper.Instance.MapBytes(data, _rHandPos);
			UnityObjectMapper.Instance.MapBytes(data, _rHandRot);
			UnityObjectMapper.Instance.MapBytes(data, _lHandActive);
			UnityObjectMapper.Instance.MapBytes(data, _rHandActive);

			return data;
		}

		protected override void ReadPayload(BMSByte payload, ulong timestep)
		{
			_playerPos = UnityObjectMapper.Instance.Map<Vector3>(payload);
			playerPosInterpolation.current = _playerPos;
			playerPosInterpolation.target = _playerPos;
			RunChange_playerPos(timestep);
			_playerRot = UnityObjectMapper.Instance.Map<Quaternion>(payload);
			playerRotInterpolation.current = _playerRot;
			playerRotInterpolation.target = _playerRot;
			RunChange_playerRot(timestep);
			_headPos = UnityObjectMapper.Instance.Map<Vector3>(payload);
			headPosInterpolation.current = _headPos;
			headPosInterpolation.target = _headPos;
			RunChange_headPos(timestep);
			_headRot = UnityObjectMapper.Instance.Map<Quaternion>(payload);
			headRotInterpolation.current = _headRot;
			headRotInterpolation.target = _headRot;
			RunChange_headRot(timestep);
			_lHandPos = UnityObjectMapper.Instance.Map<Vector3>(payload);
			lHandPosInterpolation.current = _lHandPos;
			lHandPosInterpolation.target = _lHandPos;
			RunChange_lHandPos(timestep);
			_lHandRot = UnityObjectMapper.Instance.Map<Quaternion>(payload);
			lHandRotInterpolation.current = _lHandRot;
			lHandRotInterpolation.target = _lHandRot;
			RunChange_lHandRot(timestep);
			_rHandPos = UnityObjectMapper.Instance.Map<Vector3>(payload);
			rHandPosInterpolation.current = _rHandPos;
			rHandPosInterpolation.target = _rHandPos;
			RunChange_rHandPos(timestep);
			_rHandRot = UnityObjectMapper.Instance.Map<Quaternion>(payload);
			rHandRotInterpolation.current = _rHandRot;
			rHandRotInterpolation.target = _rHandRot;
			RunChange_rHandRot(timestep);
			_lHandActive = UnityObjectMapper.Instance.Map<bool>(payload);
			lHandActiveInterpolation.current = _lHandActive;
			lHandActiveInterpolation.target = _lHandActive;
			RunChange_lHandActive(timestep);
			_rHandActive = UnityObjectMapper.Instance.Map<bool>(payload);
			rHandActiveInterpolation.current = _rHandActive;
			rHandActiveInterpolation.target = _rHandActive;
			RunChange_rHandActive(timestep);
		}

		protected override BMSByte SerializeDirtyFields()
		{
			dirtyFieldsData.Clear();
			dirtyFieldsData.Append(_dirtyFields);

			if ((0x1 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _playerPos);
			if ((0x2 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _playerRot);
			if ((0x4 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _headPos);
			if ((0x8 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _headRot);
			if ((0x10 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _lHandPos);
			if ((0x20 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _lHandRot);
			if ((0x40 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _rHandPos);
			if ((0x80 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _rHandRot);
			if ((0x1 & _dirtyFields[1]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _lHandActive);
			if ((0x2 & _dirtyFields[1]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _rHandActive);

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
				if (playerPosInterpolation.Enabled)
				{
					playerPosInterpolation.target = UnityObjectMapper.Instance.Map<Vector3>(data);
					playerPosInterpolation.Timestep = timestep;
				}
				else
				{
					_playerPos = UnityObjectMapper.Instance.Map<Vector3>(data);
					RunChange_playerPos(timestep);
				}
			}
			if ((0x2 & readDirtyFlags[0]) != 0)
			{
				if (playerRotInterpolation.Enabled)
				{
					playerRotInterpolation.target = UnityObjectMapper.Instance.Map<Quaternion>(data);
					playerRotInterpolation.Timestep = timestep;
				}
				else
				{
					_playerRot = UnityObjectMapper.Instance.Map<Quaternion>(data);
					RunChange_playerRot(timestep);
				}
			}
			if ((0x4 & readDirtyFlags[0]) != 0)
			{
				if (headPosInterpolation.Enabled)
				{
					headPosInterpolation.target = UnityObjectMapper.Instance.Map<Vector3>(data);
					headPosInterpolation.Timestep = timestep;
				}
				else
				{
					_headPos = UnityObjectMapper.Instance.Map<Vector3>(data);
					RunChange_headPos(timestep);
				}
			}
			if ((0x8 & readDirtyFlags[0]) != 0)
			{
				if (headRotInterpolation.Enabled)
				{
					headRotInterpolation.target = UnityObjectMapper.Instance.Map<Quaternion>(data);
					headRotInterpolation.Timestep = timestep;
				}
				else
				{
					_headRot = UnityObjectMapper.Instance.Map<Quaternion>(data);
					RunChange_headRot(timestep);
				}
			}
			if ((0x10 & readDirtyFlags[0]) != 0)
			{
				if (lHandPosInterpolation.Enabled)
				{
					lHandPosInterpolation.target = UnityObjectMapper.Instance.Map<Vector3>(data);
					lHandPosInterpolation.Timestep = timestep;
				}
				else
				{
					_lHandPos = UnityObjectMapper.Instance.Map<Vector3>(data);
					RunChange_lHandPos(timestep);
				}
			}
			if ((0x20 & readDirtyFlags[0]) != 0)
			{
				if (lHandRotInterpolation.Enabled)
				{
					lHandRotInterpolation.target = UnityObjectMapper.Instance.Map<Quaternion>(data);
					lHandRotInterpolation.Timestep = timestep;
				}
				else
				{
					_lHandRot = UnityObjectMapper.Instance.Map<Quaternion>(data);
					RunChange_lHandRot(timestep);
				}
			}
			if ((0x40 & readDirtyFlags[0]) != 0)
			{
				if (rHandPosInterpolation.Enabled)
				{
					rHandPosInterpolation.target = UnityObjectMapper.Instance.Map<Vector3>(data);
					rHandPosInterpolation.Timestep = timestep;
				}
				else
				{
					_rHandPos = UnityObjectMapper.Instance.Map<Vector3>(data);
					RunChange_rHandPos(timestep);
				}
			}
			if ((0x80 & readDirtyFlags[0]) != 0)
			{
				if (rHandRotInterpolation.Enabled)
				{
					rHandRotInterpolation.target = UnityObjectMapper.Instance.Map<Quaternion>(data);
					rHandRotInterpolation.Timestep = timestep;
				}
				else
				{
					_rHandRot = UnityObjectMapper.Instance.Map<Quaternion>(data);
					RunChange_rHandRot(timestep);
				}
			}
			if ((0x1 & readDirtyFlags[1]) != 0)
			{
				if (lHandActiveInterpolation.Enabled)
				{
					lHandActiveInterpolation.target = UnityObjectMapper.Instance.Map<bool>(data);
					lHandActiveInterpolation.Timestep = timestep;
				}
				else
				{
					_lHandActive = UnityObjectMapper.Instance.Map<bool>(data);
					RunChange_lHandActive(timestep);
				}
			}
			if ((0x2 & readDirtyFlags[1]) != 0)
			{
				if (rHandActiveInterpolation.Enabled)
				{
					rHandActiveInterpolation.target = UnityObjectMapper.Instance.Map<bool>(data);
					rHandActiveInterpolation.Timestep = timestep;
				}
				else
				{
					_rHandActive = UnityObjectMapper.Instance.Map<bool>(data);
					RunChange_rHandActive(timestep);
				}
			}
		}

		public override void InterpolateUpdate()
		{
			if (IsOwner)
				return;

			if (playerPosInterpolation.Enabled && !playerPosInterpolation.current.UnityNear(playerPosInterpolation.target, 0.0015f))
			{
				_playerPos = (Vector3)playerPosInterpolation.Interpolate();
				//RunChange_playerPos(playerPosInterpolation.Timestep);
			}
			if (playerRotInterpolation.Enabled && !playerRotInterpolation.current.UnityNear(playerRotInterpolation.target, 0.0015f))
			{
				_playerRot = (Quaternion)playerRotInterpolation.Interpolate();
				//RunChange_playerRot(playerRotInterpolation.Timestep);
			}
			if (headPosInterpolation.Enabled && !headPosInterpolation.current.UnityNear(headPosInterpolation.target, 0.0015f))
			{
				_headPos = (Vector3)headPosInterpolation.Interpolate();
				//RunChange_headPos(headPosInterpolation.Timestep);
			}
			if (headRotInterpolation.Enabled && !headRotInterpolation.current.UnityNear(headRotInterpolation.target, 0.0015f))
			{
				_headRot = (Quaternion)headRotInterpolation.Interpolate();
				//RunChange_headRot(headRotInterpolation.Timestep);
			}
			if (lHandPosInterpolation.Enabled && !lHandPosInterpolation.current.UnityNear(lHandPosInterpolation.target, 0.0015f))
			{
				_lHandPos = (Vector3)lHandPosInterpolation.Interpolate();
				//RunChange_lHandPos(lHandPosInterpolation.Timestep);
			}
			if (lHandRotInterpolation.Enabled && !lHandRotInterpolation.current.UnityNear(lHandRotInterpolation.target, 0.0015f))
			{
				_lHandRot = (Quaternion)lHandRotInterpolation.Interpolate();
				//RunChange_lHandRot(lHandRotInterpolation.Timestep);
			}
			if (rHandPosInterpolation.Enabled && !rHandPosInterpolation.current.UnityNear(rHandPosInterpolation.target, 0.0015f))
			{
				_rHandPos = (Vector3)rHandPosInterpolation.Interpolate();
				//RunChange_rHandPos(rHandPosInterpolation.Timestep);
			}
			if (rHandRotInterpolation.Enabled && !rHandRotInterpolation.current.UnityNear(rHandRotInterpolation.target, 0.0015f))
			{
				_rHandRot = (Quaternion)rHandRotInterpolation.Interpolate();
				//RunChange_rHandRot(rHandRotInterpolation.Timestep);
			}
			if (lHandActiveInterpolation.Enabled && !lHandActiveInterpolation.current.UnityNear(lHandActiveInterpolation.target, 0.0015f))
			{
				_lHandActive = (bool)lHandActiveInterpolation.Interpolate();
				//RunChange_lHandActive(lHandActiveInterpolation.Timestep);
			}
			if (rHandActiveInterpolation.Enabled && !rHandActiveInterpolation.current.UnityNear(rHandActiveInterpolation.target, 0.0015f))
			{
				_rHandActive = (bool)rHandActiveInterpolation.Interpolate();
				//RunChange_rHandActive(rHandActiveInterpolation.Timestep);
			}
		}

		private void Initialize()
		{
			if (readDirtyFlags == null)
				readDirtyFlags = new byte[2];

		}

		public VRPlayerNetworkObject() : base() { Initialize(); }
		public VRPlayerNetworkObject(NetWorker networker, INetworkBehavior networkBehavior = null, int createCode = 0, byte[] metadata = null) : base(networker, networkBehavior, createCode, metadata) { Initialize(); }
		public VRPlayerNetworkObject(NetWorker networker, uint serverId, FrameStream frame) : base(networker, serverId, frame) { Initialize(); }

		// DO NOT TOUCH, THIS GETS GENERATED PLEASE EXTEND THIS CLASS IF YOU WISH TO HAVE CUSTOM CODE ADDITIONS
	}
}
