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

namespace SevenMouths.Models
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(CositeUser))]
    public partial class User: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public int UserId
        {
            get { return _userId; }
            set
            {
                if (_userId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'UserId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _userId = value;
                    OnPropertyChanged("UserId");
                }
            }
        }
        private int _userId;
    
        [DataMember]
        public Nullable<int> UserNum
        {
            get { return _userNum; }
            set
            {
                if (_userNum != value)
                {
                    _userNum = value;
                    OnPropertyChanged("UserNum");
                }
            }
        }
        private Nullable<int> _userNum;
    
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
        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged("Password");
                }
            }
        }
        private string _password;
    
        [DataMember]
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    OnPropertyChanged("Description");
                }
            }
        }
        private string _description;
    
        [DataMember]
        public string MainPictureUrl
        {
            get { return _mainPictureUrl; }
            set
            {
                if (_mainPictureUrl != value)
                {
                    _mainPictureUrl = value;
                    OnPropertyChanged("MainPictureUrl");
                }
            }
        }
        private string _mainPictureUrl;
    
        [DataMember]
        public string Email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged("Email");
                }
            }
        }
        private string _email;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public TrackableCollection<CositeUser> cositeusers
        {
            get
            {
                if (_cositeusers == null)
                {
                    _cositeusers = new TrackableCollection<CositeUser>();
                    _cositeusers.CollectionChanged += Fixupcositeusers;
                }
                return _cositeusers;
            }
            set
            {
                if (!ReferenceEquals(_cositeusers, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_cositeusers != null)
                    {
                        _cositeusers.CollectionChanged -= Fixupcositeusers;
                    }
                    _cositeusers = value;
                    if (_cositeusers != null)
                    {
                        _cositeusers.CollectionChanged += Fixupcositeusers;
                    }
                    OnNavigationPropertyChanged("cositeusers");
                }
            }
        }
        private TrackableCollection<CositeUser> _cositeusers;

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
            cositeusers.Clear();
        }

        #endregion
        #region Association Fixup
    
        private void Fixupcositeusers(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (CositeUser item in e.NewItems)
                {
                    item.user = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("cositeusers", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CositeUser item in e.OldItems)
                {
                    if (ReferenceEquals(item.user, this))
                    {
                        item.user = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("cositeusers", item);
                    }
                }
            }
        }

        #endregion
    }
}