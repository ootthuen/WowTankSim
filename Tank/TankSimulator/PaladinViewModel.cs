using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace TankSimulator
{
    public class PaladinViewModel : INotifyPropertyChanged
    {
        public PaladinModel Paladin { get; set; }

        public PaladinViewModel()
        {
            Paladin = new PaladinModel
                          {
                              Name = "Oot",
                              Realm = "Aszune",
                          };
        }

        public int Strength
        {
            get
            {
                return Paladin.Strength;
            }
            set 
            {
                if (Paladin.Strength != value)
                {
                    Paladin.Strength = value;
                    OnPropertyChanged("Strength");
                }
            }
        }

        public int AddStrength
        {
            get
            {
                return Paladin.AddStrength;
            }
            set
            {
                if (Paladin.AddStrength != value)
                {
                    Paladin.AddStrength = value;
                    OnPropertyChanged("AddStrength");
                }
            }
        }

        public int Stamina
        {
            get
            {
                return Paladin.Stamina;
            }
            set
            {
                if (Paladin.Stamina != value)
                {
                    Paladin.Stamina = value;
                    OnPropertyChanged("Stamina");
                }
            }
        }

        public int AddStamina
        {
            get
            {
                return Paladin.AddStamina;
            }
            set
            {
                if (Paladin.AddStamina != value)
                {
                    Paladin.AddStamina = value;
                    OnPropertyChanged("AddStamina");
                }
            }
        }

        public int MasteryRating
        {
            get
            {
                return Paladin.MasteryRating;
            }
            set
            {
                if (Paladin.MasteryRating != value)
                {
                    Paladin.MasteryRating = value;
                    OnPropertyChanged("MasteryRating");
                }
            }
        }

        public int AddMasteryRating
        {
            get
            {
                return Paladin.AddMasteryRating;
            }
            set
            {
                if (Paladin.AddMasteryRating != value)
                {
                    Paladin.AddMasteryRating = value;
                    OnPropertyChanged("AddMasteryRating");
                }
            }
        }

        public int DodgeRating
        {
            get
            {
                return Paladin.DodgeRating;
            }
            set
            {
                if (Paladin.DodgeRating != value)
                {
                    Paladin.DodgeRating = value;
                    OnPropertyChanged("DodgeRating");
                }
            }
        }

        public int ParryRating
        {
            get
            {
                return Paladin.ParryRating;
            }
            set
            {
                if (Paladin.ParryRating != value)
                {
                    Paladin.ParryRating = value;
                    OnPropertyChanged("ParryRating");
                }
            }
        }

        public int HasteRating
        {
            get
            {
                return Paladin.HasteRating;
            }
            set
            {
                if (Paladin.HasteRating != value)
                {
                    Paladin.HasteRating = value;
                    OnPropertyChanged("HasteRating");
                }
            }
        }

        public int ExpertiseRating
        {
            get
            {
                return Paladin.ExpertiseRating;
            }
            set
            {
                if (Paladin.ExpertiseRating != value)
                {
                    Paladin.ExpertiseRating = value;
                    OnPropertyChanged("ExpertiseRating");
                }
            }
        }

        public int HitRating
        {
            get
            {
                return Paladin.HitRating;
            }
            set
            {
                if (Paladin.HitRating != value)
                {
                    Paladin.HitRating = value;
                    OnPropertyChanged("HitRating");
                }
            }
        }

        public string Name
        {
            get
            {
                return Paladin.Name;
            }
            set
            {
                if (Paladin.Name != value)
                {
                    Paladin.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public string Realm
        {
            get
            {
                return Paladin.Realm;
            }
            set
            {
                if (Paladin.Realm != value)
                {
                    Paladin.Realm = value;
                    OnPropertyChanged("Realm");
                }
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ICommand Command
        {
            get { return new RelayCommand(this); }
        }
    }
}
