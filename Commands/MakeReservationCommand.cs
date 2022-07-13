using MVVM.Exceptions;
using MVVM.Models;
using MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM.Commands
{
    public class MakeReservationCommand : CommandBase
    {
        private readonly Hotel _hotel;
        private readonly MakeReservationViewModel _makeReservationViewModel;

        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, Hotel hotel)
        {
            _makeReservationViewModel = makeReservationViewModel;
            _hotel = hotel;
            _makeReservationViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }


        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_makeReservationViewModel.Username) 
                &&_makeReservationViewModel.FloorNumber > 0
                && base.CanExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            Reservation reservation = new Reservation(
                new RoomID(_makeReservationViewModel.FloorNumber,_makeReservationViewModel.RoomNumber),
                _makeReservationViewModel.Username, 
                _makeReservationViewModel.StartDate,
                _makeReservationViewModel.EndDate);

            try
            {
                _hotel.MakeReservation(reservation);

                MessageBox.Show("Successufuly reserved room", "Successe", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (ReservationConflictException)
            {

                MessageBox.Show("This room is already taken.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
          
        }
        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(MakeReservationViewModel.Username) || 
                e.PropertyName == nameof(MakeReservationViewModel.FloorNumber))
            {
                OnCanExecutedChanged();
            }
        }


    }
}
