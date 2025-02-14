﻿#region Using Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion

namespace AirlineReservationSystem.Models
{
    #region Admin class properties
    public class Admin
    {
        
        int _adminId;
        [Key]
        public int AdminId
        {
            get { return _adminId; }
            set { _adminId = value; }
        }

        string? _firstName;
        public string? FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        string? _lastName;
        public string? LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        string? _emailId;
        public string? EmailId
        {
            get { return _emailId; }
            set { _emailId = value; }
        }

        string? _username;
        public string? Username
        {
            get { return _username; }
            set { _username = value; }
        }

        string? _password;
        public string? Password
        {
            get { return _password; }
            set { _password = value; }
        }

        string? _role;
        public string? Role
        {
            get { return _role; }
            set { _role = value; }
        }
    }
    #endregion
}
