using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XFPrismValidation.Models;

namespace XFPrismValidation.ViewModels
{
	public class MainPageViewModel : ViewModelBase
	{
		public MainPageViewModel(INavigationService navigationService, IPageDialogService dialogService)
			: base(navigationService)
		{
			Title = "Main Page";

			_dialogService = dialogService;

			LoginCommand = new DelegateCommand(Login);
		}

		public User Model
		{
			get => _model;
			set => SetProperty(ref _model, value);
		}

		public DelegateCommand LoginCommand { get; set; }


		#region Private Variables

		private User _model = new User();

		private IPageDialogService _dialogService;

		#endregion


		#region Private Methods

		private async void Login()
		{
			if (_model.ValidateProperties())
			{
				await _dialogService.DisplayAlertAsync("Alert", "The Model is Valid", "OK");
			}
		}

		#endregion
	}
}
