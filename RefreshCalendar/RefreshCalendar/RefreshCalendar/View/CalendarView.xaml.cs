﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RefreshCalendar
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalendarView : ContentPage
	{
		public CalendarView ()
		{
			InitializeComponent ();
		}
	}
}