using System.Windows;
using Microsoft.Xaml.Behaviors;
using Syncfusion.UI.Xaml.Scheduler;

namespace WpfScheduler
{
    public class SchedulerBehavior : Behavior<SfScheduler>
    {
        SfScheduler scheduler;
        protected override void OnAttached()
        {
            base.OnAttached();
            scheduler = this.AssociatedObject;
            this.AssociatedObject.CellTapped += Schedule_CellTapped;
        }
        private void Schedule_CellTapped(object sender, CellTappedEventArgs e)
        {
            var appointment = e.Appointment as CustomAppointment;
            if (appointment != null && appointment.Subject == "Meeting")
                MessageBox.Show(" " + " " + appointment.AppointmentID.ToString(), "Selected Appointment ID ", MessageBoxButton.OK);
        }
        protected override void OnDetaching()
        {
            base.OnDetaching();
            this.AssociatedObject.CellTapped -= Schedule_CellTapped;
            this.scheduler = null;
        }
    }
}
        
    

