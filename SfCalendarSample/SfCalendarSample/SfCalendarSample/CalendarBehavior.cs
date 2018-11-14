using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SfCalendarSample
{
    class CalendarBehavior:Behavior<ContentPage>
    {
        SfCalendar calendar;
        ViewModel viewModel;
        public CalendarBehavior()
        {
            viewModel = new ViewModel();
           
        }

        protected override void OnAttachedTo(BindableObject bindable)
        {
            bindable.BindingContext = viewModel;
            var page = bindable as Page;
            calendar = page.FindByName<SfCalendar>("calendar");
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(BindableObject bindable)
        {
            base.OnDetachingFrom(bindable);
        }

    }
}
