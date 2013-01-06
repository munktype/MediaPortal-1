//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace Mediaportal.TV.Server.TVDatabase.Entities
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(CardGroupMap))]
    [KnownType(typeof(DisEqcMotor))]
    [KnownType(typeof(ChannelMap))]
    [KnownType(typeof(Conflict))]
    public partial class Card: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public int IdCard
        {
            get { return _idCard; }
            set
            {
                if (_idCard != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'IdCard' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _idCard = value;
                    OnPropertyChanged("IdCard");
                }
            }
        }
        private int _idCard;
    
        [DataMember]
        public string DevicePath
        {
            get { return _devicePath; }
            set
            {
                if (_devicePath != value)
                {
                    _devicePath = value;
                    OnPropertyChanged("DevicePath");
                }
            }
        }
        private string _devicePath;
    
        [DataMember]
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        private string _name;
    
        [DataMember]
        public int Priority
        {
            get { return _priority; }
            set
            {
                if (_priority != value)
                {
                    _priority = value;
                    OnPropertyChanged("Priority");
                }
            }
        }
        private int _priority;
    
        [DataMember]
        public bool GrabEPG
        {
            get { return _grabEPG; }
            set
            {
                if (_grabEPG != value)
                {
                    _grabEPG = value;
                    OnPropertyChanged("GrabEPG");
                }
            }
        }
        private bool _grabEPG;
    
        [DataMember]
        public Nullable<System.DateTime> LastEpgGrab
        {
            get { return _lastEpgGrab; }
            set
            {
                if (_lastEpgGrab != value)
                {
                    _lastEpgGrab = value;
                    OnPropertyChanged("LastEpgGrab");
                }
            }
        }
        private Nullable<System.DateTime> _lastEpgGrab;
    
        [DataMember]
        public string RecordingFolder
        {
            get { return _recordingFolder; }
            set
            {
                if (_recordingFolder != value)
                {
                    _recordingFolder = value;
                    OnPropertyChanged("RecordingFolder");
                }
            }
        }
        private string _recordingFolder;
    
        [DataMember]
        public bool Enabled
        {
            get { return _enabled; }
            set
            {
                if (_enabled != value)
                {
                    _enabled = value;
                    OnPropertyChanged("Enabled");
                }
            }
        }
        private bool _enabled;
    
        [DataMember]
        public int CamType
        {
            get { return _camType; }
            set
            {
                if (_camType != value)
                {
                    _camType = value;
                    OnPropertyChanged("CamType");
                }
            }
        }
        private int _camType;
    
        [DataMember]
        public string TimeshiftingFolder
        {
            get { return _timeshiftingFolder; }
            set
            {
                if (_timeshiftingFolder != value)
                {
                    _timeshiftingFolder = value;
                    OnPropertyChanged("TimeshiftingFolder");
                }
            }
        }
        private string _timeshiftingFolder;
    
        [DataMember]
        public int DecryptLimit
        {
            get { return _decryptLimit; }
            set
            {
                if (_decryptLimit != value)
                {
                    _decryptLimit = value;
                    OnPropertyChanged("DecryptLimit");
                }
            }
        }
        private int _decryptLimit;
    
        [DataMember]
        public bool PreloadCard
        {
            get { return _preloadCard; }
            set
            {
                if (_preloadCard != value)
                {
                    _preloadCard = value;
                    OnPropertyChanged("PreloadCard");
                }
            }
        }
        private bool _preloadCard;
    
        [DataMember]
        public int NetProvider
        {
            get { return _netProvider; }
            set
            {
                if (_netProvider != value)
                {
                    _netProvider = value;
                    OnPropertyChanged("NetProvider");
                }
            }
        }
        private int _netProvider;
    
        [DataMember]
        public int IdleMode
        {
            get { return _idleMode; }
            set
            {
                if (_idleMode != value)
                {
                    _idleMode = value;
                    OnPropertyChanged("IdleMode");
                }
            }
        }
        private int _idleMode;
    
        [DataMember]
        public int MultiChannelDecryptMode
        {
            get { return _multiChannelDecryptMode; }
            set
            {
                if (_multiChannelDecryptMode != value)
                {
                    _multiChannelDecryptMode = value;
                    OnPropertyChanged("MultiChannelDecryptMode");
                }
            }
        }
        private int _multiChannelDecryptMode;
    
        [DataMember]
        public bool AlwaysSendDiseqcCommands
        {
            get { return _alwaysSendDiseqcCommands; }
            set
            {
                if (_alwaysSendDiseqcCommands != value)
                {
                    _alwaysSendDiseqcCommands = value;
                    OnPropertyChanged("AlwaysSendDiseqcCommands");
                }
            }
        }
        private bool _alwaysSendDiseqcCommands;
    
        [DataMember]
        public int DiseqcCommandRepeatCount
        {
            get { return _diseqcCommandRepeatCount; }
            set
            {
                if (_diseqcCommandRepeatCount != value)
                {
                    _diseqcCommandRepeatCount = value;
                    OnPropertyChanged("DiseqcCommandRepeatCount");
                }
            }
        }
        private int _diseqcCommandRepeatCount;
    
        [DataMember]
        public int PidFilterMode
        {
            get { return _pidFilterMode; }
            set
            {
                if (_pidFilterMode != value)
                {
                    _pidFilterMode = value;
                    OnPropertyChanged("PidFilterMode");
                }
            }
        }
        private int _pidFilterMode;
    
        [DataMember]
        public bool UseCustomTuning
        {
            get { return _useCustomTuning; }
            set
            {
                if (_useCustomTuning != value)
                {
                    _useCustomTuning = value;
                    OnPropertyChanged("UseCustomTuning");
                }
            }
        }
        private bool _useCustomTuning;
    
        [DataMember]
        public bool UseConditionalAccess
        {
            get { return _useConditionalAccess; }
            set
            {
                if (_useConditionalAccess != value)
                {
                    _useConditionalAccess = value;
                    OnPropertyChanged("UseConditionalAccess");
                }
            }
        }
        private bool _useConditionalAccess;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public TrackableCollection<CardGroupMap> CardGroupMaps
        {
            get
            {
                if (_cardGroupMaps == null)
                {
                    _cardGroupMaps = new TrackableCollection<CardGroupMap>();
                    _cardGroupMaps.CollectionChanged += FixupCardGroupMaps;
                }
                return _cardGroupMaps;
            }
            set
            {
                if (!ReferenceEquals(_cardGroupMaps, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_cardGroupMaps != null)
                    {
                        _cardGroupMaps.CollectionChanged -= FixupCardGroupMaps;
                        // This is the principal end in an association that performs cascade deletes.
                        // Remove the cascade delete event handler for any entities in the current collection.
                        foreach (CardGroupMap item in _cardGroupMaps)
                        {
                            ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                        }
                    }
                    _cardGroupMaps = value;
                    if (_cardGroupMaps != null)
                    {
                        _cardGroupMaps.CollectionChanged += FixupCardGroupMaps;
                        // This is the principal end in an association that performs cascade deletes.
                        // Add the cascade delete event handler for any entities that are already in the new collection.
                        foreach (CardGroupMap item in _cardGroupMaps)
                        {
                            ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                        }
                    }
                    OnNavigationPropertyChanged("CardGroupMaps");
                }
            }
        }
        private TrackableCollection<CardGroupMap> _cardGroupMaps;
    
        [DataMember]
        public TrackableCollection<DisEqcMotor> DisEqcMotors
        {
            get
            {
                if (_disEqcMotors == null)
                {
                    _disEqcMotors = new TrackableCollection<DisEqcMotor>();
                    _disEqcMotors.CollectionChanged += FixupDisEqcMotors;
                }
                return _disEqcMotors;
            }
            set
            {
                if (!ReferenceEquals(_disEqcMotors, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_disEqcMotors != null)
                    {
                        _disEqcMotors.CollectionChanged -= FixupDisEqcMotors;
                        // This is the principal end in an association that performs cascade deletes.
                        // Remove the cascade delete event handler for any entities in the current collection.
                        foreach (DisEqcMotor item in _disEqcMotors)
                        {
                            ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                        }
                    }
                    _disEqcMotors = value;
                    if (_disEqcMotors != null)
                    {
                        _disEqcMotors.CollectionChanged += FixupDisEqcMotors;
                        // This is the principal end in an association that performs cascade deletes.
                        // Add the cascade delete event handler for any entities that are already in the new collection.
                        foreach (DisEqcMotor item in _disEqcMotors)
                        {
                            ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                        }
                    }
                    OnNavigationPropertyChanged("DisEqcMotors");
                }
            }
        }
        private TrackableCollection<DisEqcMotor> _disEqcMotors;
    
        [DataMember]
        public TrackableCollection<ChannelMap> ChannelMaps
        {
            get
            {
                if (_channelMaps == null)
                {
                    _channelMaps = new TrackableCollection<ChannelMap>();
                    _channelMaps.CollectionChanged += FixupChannelMaps;
                }
                return _channelMaps;
            }
            set
            {
                if (!ReferenceEquals(_channelMaps, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_channelMaps != null)
                    {
                        _channelMaps.CollectionChanged -= FixupChannelMaps;
                        // This is the principal end in an association that performs cascade deletes.
                        // Remove the cascade delete event handler for any entities in the current collection.
                        foreach (ChannelMap item in _channelMaps)
                        {
                            ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                        }
                    }
                    _channelMaps = value;
                    if (_channelMaps != null)
                    {
                        _channelMaps.CollectionChanged += FixupChannelMaps;
                        // This is the principal end in an association that performs cascade deletes.
                        // Add the cascade delete event handler for any entities that are already in the new collection.
                        foreach (ChannelMap item in _channelMaps)
                        {
                            ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                        }
                    }
                    OnNavigationPropertyChanged("ChannelMaps");
                }
            }
        }
        private TrackableCollection<ChannelMap> _channelMaps;
    
        [DataMember]
        public TrackableCollection<Conflict> Conflicts
        {
            get
            {
                if (_conflicts == null)
                {
                    _conflicts = new TrackableCollection<Conflict>();
                    _conflicts.CollectionChanged += FixupConflicts;
                }
                return _conflicts;
            }
            set
            {
                if (!ReferenceEquals(_conflicts, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_conflicts != null)
                    {
                        _conflicts.CollectionChanged -= FixupConflicts;
                        // This is the principal end in an association that performs cascade deletes.
                        // Remove the cascade delete event handler for any entities in the current collection.
                        foreach (Conflict item in _conflicts)
                        {
                            ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                        }
                    }
                    _conflicts = value;
                    if (_conflicts != null)
                    {
                        _conflicts.CollectionChanged += FixupConflicts;
                        // This is the principal end in an association that performs cascade deletes.
                        // Add the cascade delete event handler for any entities that are already in the new collection.
                        foreach (Conflict item in _conflicts)
                        {
                            ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                        }
                    }
                    OnNavigationPropertyChanged("Conflicts");
                }
            }
        }
        private TrackableCollection<Conflict> _conflicts;

        #endregion
        #region ChangeTracking
    
        protected virtual void OnPropertyChanged(String propertyName)
        {
            if (ChangeTracker.State != ObjectState.Added && ChangeTracker.State != ObjectState.Deleted)
            {
                ChangeTracker.State = ObjectState.Modified;
            }
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        protected virtual void OnNavigationPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged{ add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;
        private ObjectChangeTracker _changeTracker;
    
        [DataMember]
        public ObjectChangeTracker ChangeTracker
        {
            get
            {
                if (_changeTracker == null)
                {
                    _changeTracker = new ObjectChangeTracker();
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
                return _changeTracker;
            }
            set
            {
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging -= HandleObjectStateChanging;
                }
                _changeTracker = value;
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
            }
        }
    
        private void HandleObjectStateChanging(object sender, ObjectStateChangingEventArgs e)
        {
            if (e.NewState == ObjectState.Deleted)
            {
                ClearNavigationProperties();
            }
        }
    
        protected bool IsDeserializing { get; private set; }
    
        [OnDeserializing]
        public void OnDeserializingMethod(StreamingContext context)
        {
            IsDeserializing = true;
        }
    
        [OnDeserialized]
        public void OnDeserializedMethod(StreamingContext context)
        {
            IsDeserializing = false;
            ChangeTracker.ChangeTrackingEnabled = true;
        }
    
        protected virtual void ClearNavigationProperties()
        {
            CardGroupMaps.Clear();
            DisEqcMotors.Clear();
            ChannelMaps.Clear();
            Conflicts.Clear();
        }

        #endregion
        #region Association Fixup
    
        private void FixupCardGroupMaps(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (CardGroupMap item in e.NewItems)
                {
                    item.Card = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("CardGroupMaps", item);
                    }
                    // This is the principal end in an association that performs cascade deletes.
                    // Update the event listener to refer to the new dependent.
                    ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CardGroupMap item in e.OldItems)
                {
                    if (ReferenceEquals(item.Card, this))
                    {
                        item.Card = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("CardGroupMaps", item);
                    }
                    // This is the principal end in an association that performs cascade deletes.
                    // Remove the previous dependent from the event listener.
                    ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                }
            }
        }
    
        private void FixupDisEqcMotors(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (DisEqcMotor item in e.NewItems)
                {
                    item.Card = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("DisEqcMotors", item);
                    }
                    // This is the principal end in an association that performs cascade deletes.
                    // Update the event listener to refer to the new dependent.
                    ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (DisEqcMotor item in e.OldItems)
                {
                    if (ReferenceEquals(item.Card, this))
                    {
                        item.Card = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("DisEqcMotors", item);
                    }
                    // This is the principal end in an association that performs cascade deletes.
                    // Remove the previous dependent from the event listener.
                    ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                }
            }
        }
    
        private void FixupChannelMaps(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (ChannelMap item in e.NewItems)
                {
                    item.Card = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("ChannelMaps", item);
                    }
                    // This is the principal end in an association that performs cascade deletes.
                    // Update the event listener to refer to the new dependent.
                    ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ChannelMap item in e.OldItems)
                {
                    if (ReferenceEquals(item.Card, this))
                    {
                        item.Card = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("ChannelMaps", item);
                    }
                    // This is the principal end in an association that performs cascade deletes.
                    // Remove the previous dependent from the event listener.
                    ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                }
            }
        }
    
        private void FixupConflicts(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (Conflict item in e.NewItems)
                {
                    item.Card = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("Conflicts", item);
                    }
                    // This is the principal end in an association that performs cascade deletes.
                    // Update the event listener to refer to the new dependent.
                    ChangeTracker.ObjectStateChanging += item.HandleCascadeDelete;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Conflict item in e.OldItems)
                {
                    if (ReferenceEquals(item.Card, this))
                    {
                        item.Card = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("Conflicts", item);
                    }
                    // This is the principal end in an association that performs cascade deletes.
                    // Remove the previous dependent from the event listener.
                    ChangeTracker.ObjectStateChanging -= item.HandleCascadeDelete;
                }
            }
        }

        #endregion
    }
}
