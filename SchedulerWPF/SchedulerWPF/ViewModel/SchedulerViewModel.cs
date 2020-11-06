using System;
using System.Collections.ObjectModel;
using System.Windows.Media;

namespace WpfScheduler
{
	public class SchedulerViewModel
	{
		public ObservableCollection<CustomAppointment> AppointmentCollection
		{
			get;
			set;
		}
		CustomAppointment scheduleAppointment;
		public SchedulerViewModel()
		{
			scheduleAppointment = new CustomAppointment();
			scheduleAppointment.Subject = "Meeting";
			scheduleAppointment.AppointmentID = "579";
			scheduleAppointment.AppointmentBackground = Brushes.Green;
			scheduleAppointment.StartTime = DateTime.Now.Date.AddHours(10);
			scheduleAppointment.EndTime = DateTime.Now.Date.AddHours(12);
			AppointmentCollection = new ObservableCollection<CustomAppointment>();
			AppointmentCollection.Add(scheduleAppointment);
		}
	}
}


