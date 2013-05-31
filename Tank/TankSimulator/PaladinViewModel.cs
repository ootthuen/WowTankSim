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

        public int AddStrength1
        {
            get
            {
                return Paladin.AddStrength1;
            }
            set
            {
                if (Paladin.AddStrength1 != value)
                {
                    Paladin.AddStrength1 = value;
                    OnPropertyChanged("AddStrength1");
                }
            }
        }

        public int AddStrength2
        {
            get
            {
                return Paladin.AddStrength2;
            }
            set
            {
                if (Paladin.AddStrength2 != value)
                {
                    Paladin.AddStrength2 = value;
                    OnPropertyChanged("AddStrength2");
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

        public int AddStamina1
        {
            get { return Paladin.AddStamina1; }
            set
            {
                if (Paladin.AddStamina1 != value)
                {
                    Paladin.AddStamina1 = value;
                    OnPropertyChanged("AddStamina1");
                }
            }
        }

        public int AddStamina
        {
            get
            {
                return Paladin.AddStamina2;
            }
            set
            {
                if (Paladin.AddStamina2 != value)
                {
                    Paladin.AddStamina2 = value;
                    OnPropertyChanged("AddStamina2");
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

        public int AddMasteryRating1
        {
            get
            {
                return Paladin.AddMasteryRating1;
            }
            set
            {
                if (Paladin.AddMasteryRating1 != value)
                {
                    Paladin.AddMasteryRating1 = value;
                    OnPropertyChanged("AddMasteryRating1");
                }
            }
        }

        public int AddMasteryRating2
        {
            get
            {
                return Paladin.AddMasteryRating2;
            }
            set
            {
                if (Paladin.AddMasteryRating2 != value)
                {
                    Paladin.AddMasteryRating2 = value;
                    OnPropertyChanged("AddMasteryRating2");
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

        public int AddDodgeRating1
        {
            get
            {
                return Paladin.AddDodgeRating1;
            }
            set
            {
                if (Paladin.AddDodgeRating1 != value)
                {
                    Paladin.AddDodgeRating1 = value;
                    OnPropertyChanged("AddDodgeRating1");
                }
            }
        }

        public int AddDodgeRating2
        {
            get
            {
                return Paladin.AddDodgeRating2;
            }
            set
            {
                if (Paladin.AddDodgeRating2 != value)
                {
                    Paladin.AddDodgeRating2 = value;
                    OnPropertyChanged("AddDodgeRating2");
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

        public int AddParryRating1
        {
            get
            {
                return Paladin.AddParryRating1;
            }
            set
            {
                if (Paladin.AddParryRating1 != value)
                {
                    Paladin.AddParryRating1 = value;
                    OnPropertyChanged("AddParryRating1");
                }
            }
        }

        public int AddParryRating2
        {
            get
            {
                return Paladin.AddParryRating2;
            }
            set
            {
                if (Paladin.AddParryRating2 != value)
                {
                    Paladin.AddParryRating2 = value;
                    OnPropertyChanged("AddParryRating2");
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

        public int AddHasteRating1
        {
            get
            {
                return Paladin.AddHasteRating1;
            }
            set
            {
                if (Paladin.AddHasteRating1 != value)
                {
                    Paladin.AddHasteRating1 = value;
                    OnPropertyChanged("AddHasteRating1");
                }
            }
        }

        public int AddHasteRating2
        {
            get
            {
                return Paladin.AddHasteRating2;
            }
            set
            {
                if (Paladin.AddHasteRating2 != value)
                {
                    Paladin.AddHasteRating2 = value;
                    OnPropertyChanged("AddHasteRating2");
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

        public int AddExpertiseRating1
        {
            get
            {
                return Paladin.AddExpertiseRating1;
            }
            set
            {
                if (Paladin.AddExpertiseRating1 != value)
                {
                    Paladin.AddExpertiseRating1 = value;
                    OnPropertyChanged("AddExpertiseRating1");
                }
            }
        }

        public int AddExpertiseRating2
        {
            get
            {
                return Paladin.AddExpertiseRating2;
            }
            set
            {
                if (Paladin.AddExpertiseRating2 != value)
                {
                    Paladin.AddExpertiseRating2 = value;
                    OnPropertyChanged("AddExpertiseRating2");
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

        public int AddHitRating1
        {
            get
            {
                return Paladin.AddHitRating1;
            }
            set
            {
                if (Paladin.AddHitRating1 != value)
                {
                    Paladin.AddHitRating1 = value;
                    OnPropertyChanged("AddHitRating1");
                }
            }
        }

        public int AddHitRating2
        {
            get
            {
                return Paladin.AddHitRating2;
            }
            set
            {
                if (Paladin.AddHitRating2 != value)
                {
                    Paladin.AddHitRating2 = value;
                    OnPropertyChanged("AddHitRating2");
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
