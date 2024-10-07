using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Manager.Model.EntityLayer
{
    internal class RecipeIngredients : BasePropertyChanged
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
            set { _name = value; NotifyPropertyChanged(nameof(Name));}
        }

        private string? _type;
        public string? Type
        {
            get { return _type; }
            set { _type = value; NotifyPropertyChanged(nameof(Type)); }
        }

        private int? _ammount;
        public int? Amount
        {
            get { return _ammount; }
            set { _ammount = value; NotifyPropertyChanged(nameof(Amount)); }
        }

        private int? _grammage;
        public int? Grammage
        {
            get { return _grammage; }
            set { _grammage = value; NotifyPropertyChanged(nameof(Grammage)); }
        }
        


    }
}
