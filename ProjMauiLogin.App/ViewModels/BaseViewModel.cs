﻿using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace ProjMauiLogin.App.ViewModels
{
	public partial class BaseViewModel : ObservableObject
	{
        [ObservableProperty]
        public bool _isBusy;

		[ObservableProperty]
		public string _title;
    }
}
