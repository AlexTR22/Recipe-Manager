using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Manager.Model.EntityLayer
{
    internal class Recipe : BasePropertyChanged 
    {
        private int? _id;
        public int? Id 
        { 
            get { return _id;} 
            set { _id = value; NotifyPropertyChanged(nameof(Id)); }
        }

        private string? _authorName;
        public string? AuthorName
        {
            get { return _authorName; }
            set { _authorName = value; NotifyPropertyChanged(nameof(AuthorName));}
        }

        private string? _description;
        public string? Description
        { 
            get { return _description; } 
            set { _description = value; NotifyPropertyChanged(nameof(Description)); }
        }

        private ObservableCollection<RecipeIngredients>? _ingredients;
        public ObservableCollection<RecipeIngredients>? Ingredients
        {
            get { return _ingredients; }
            set { _ingredients = value; NotifyPropertyChanged(nameof(Ingredients));}
        }

    }
}
