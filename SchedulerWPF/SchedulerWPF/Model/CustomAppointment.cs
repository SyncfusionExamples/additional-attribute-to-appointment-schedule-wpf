using Syncfusion.UI.Xaml.Scheduler;
using System.ComponentModel;

namespace WpfScheduler
{
	public class CustomAppointment : ScheduleAppointment, INotifyPropertyChanged
	{
		private string appointment_ID;
		public string AppointmentID
		{
			get { return appointment_ID; }
			set
			{
				appointment_ID = value;
				OnPropertyChanged("AppointmentID");
			}
		}
		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string propertyName)
		{
			var eventHandler = this.PropertyChanged;
			if (eventHandler != null)
				eventHandler(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}




