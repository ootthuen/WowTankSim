using System;
using System.Windows.Input;
using WOWSharp.Community;
using WOWSharp.Community.Wow;

namespace TankSimulator
{
    public class RelayCommand : ICommand
    {
        public RelayCommand(PaladinViewModel paladinViewModel)
        {
            this.PaladinViewModel = paladinViewModel;
        }

        private PaladinViewModel PaladinViewModel { get; set; }

        public void Execute(object parameter)
        {
            WowClient client = new WowClient(Region.EU);
            Character character = client.GetCharacter(PaladinViewModel.Realm, PaladinViewModel.Name, CharacterFields.Stats);
            CharacterStats characterStats = character.Stats;
            PaladinViewModel.Stamina = characterStats.Stamina;
            PaladinViewModel.Strength = characterStats.Strength;
            PaladinViewModel.MasteryRating = characterStats.MasteryRating;
            PaladinViewModel.HasteRating = characterStats.HasteRating;
            PaladinViewModel.HitRating = characterStats.HitRating;
            PaladinViewModel.ParryRating = characterStats.ParryRating;
            PaladinViewModel.DodgeRating = characterStats.DodgeRating;
            PaladinViewModel.ExpertiseRating = characterStats.ExpertiseRating;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}