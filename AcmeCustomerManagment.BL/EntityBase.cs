﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCustomerManagment.BL
{
    public enum EntityStateOption { Active,Deleted}
    public abstract class EntityBase
    {
        public EntityStateOption EnityState { get; set; }
        public bool IsNew { get; private set; }
        public bool HasChanges { get; set; }
        public bool IsValid
        {
            get
            {
                return Validate();
            }
        }
        public abstract bool Validate();
        
    }
}