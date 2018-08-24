using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using XFPrismValidation.Validation;

namespace XFPrismValidation.Models
{
	public class User : ValidatableBase
	{
		private string _username;
		private string _password;

		[Required(ErrorMessageResourceType = typeof(Resources.AppResources), ErrorMessageResourceName = "ValidationRequired")]
		public string Username
		{
			get => _username;
			set => SetProperty(ref _username, value);
		}

		[Required(ErrorMessageResourceType = typeof(Resources.AppResources), ErrorMessageResourceName = "ValidationRequired")]
		public string Password
		{
			get => _password;
			set => SetProperty(ref _password, value);
		}
	}
}
