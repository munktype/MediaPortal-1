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
    [KnownType(typeof(ProgramCategory))]
    public partial class TvGuideCategory: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public int IdTvGuideCategory
        {
            get { return _idTvGuideCategory; }
            set
            {
                if (_idTvGuideCategory != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'IdTvGuideCategory' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _idTvGuideCategory = value;
                    OnPropertyChanged("IdTvGuideCategory");
                }
            }
        }
        private int _idTvGuideCategory;
    
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
        public bool IsMovie
        {
            get { return _isMovie; }
            set
            {
                if (_isMovie != value)
                {
                    _isMovie = value;
                    OnPropertyChanged("IsMovie");
                }
            }
        }
        private bool _isMovie;
    
        [DataMember]
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                if (_isEnabled != value)
                {
                    _isEnabled = value;
                    OnPropertyChanged("IsEnabled");
                }
            }
        }
        private bool _isEnabled;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public TrackableCollection<ProgramCategory> ProgramCategories
        {
            get
            {
                if (_programCategories == null)
                {
                    _programCategories = new TrackableCollection<ProgramCategory>();
                    _programCategories.CollectionChanged += FixupProgramCategories;
                }
                return _programCategories;
            }
            set
            {
                if (!ReferenceEquals(_programCategories, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_programCategories != null)
                    {
                        _programCategories.CollectionChanged -= FixupProgramCategories;
                    }
                    _programCategories = value;
                    if (_programCategories != null)
                    {
                        _programCategories.CollectionChanged += FixupProgramCategories;
                    }
                    OnNavigationPropertyChanged("ProgramCategories");
                }
            }
        }
        private TrackableCollection<ProgramCategory> _programCategories;

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
            ProgramCategories.Clear();
        }

        #endregion
        #region Association Fixup
    
        private void FixupProgramCategories(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (ProgramCategory item in e.NewItems)
                {
                    item.TvGuideCategory = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("ProgramCategories", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ProgramCategory item in e.OldItems)
                {
                    if (ReferenceEquals(item.TvGuideCategory, this))
                    {
                        item.TvGuideCategory = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("ProgramCategories", item);
                    }
                }
            }
        }

        #endregion
    }
}
