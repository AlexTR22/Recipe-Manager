    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace Recipe_Manager.Model.EntityLayer
{
    internal class User : BasePropertyChanged
    {
        private int? _id;
        public int? Id
        {
            get { return _id; }
            set { _id = value; NotifyPropertyChanged(nameof(Id)); }
        }

        private string? _name;
        public string? Name
        {
            get { return _name; }
            set { _name = value; NotifyPropertyChanged(nameof(Name)); }
        }

        private string? _email;
        public string? Email
        {
            get { return _email; }
            set { _email = value; NotifyPropertyChanged(nameof(Email)); }
        } 
    

    }
}
