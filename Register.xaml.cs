namespace Register;

public partial class Register : ContentPage
{
	public Register()
	{
		InitializeComponent();
	}

	//Date of Birth
	private void  DatePicker_DateSelected(object sender, DateChangedEventArgs e)
	{
		//SelectDateLabel.Text= e.NewDate.ToString("dd/MM/yyyy");
		//SelectDateLabel.Text= "Select date : "+ e.NewDate.ToString("dd/MM/yyyy");
		SelectDateLabel.Text= $"Select date : {e.NewDate:dd/MM/yyyy}";
	}

	//Agree of Terms
    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
		SwitchValue.Text = e.Value ? "Yes" : "No";
    }

	//Slider Experience
    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		experience.Text=$"{e.NewValue:F0} years";
    }

	//Stepper Dependents
    private void StepperControl_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		StepperValueLabel.Text = $"{e.NewValue:F0}";
    }

	//DisplayAlert
    private void Button_Clicked(object sender, EventArgs e)

    {
		string Name = EntryName.Text;
		string Email = EntryEmail.Text;
		DateTime DateofBirth = DatePicker.Date; 
		string Gender = M.IsChecked ? "Male" : "Female";
		string Agree = SwitchValue.Text;
		string Experience = experience.Text;
		string Dependents = StepperValueLabel.Text;
		
		string massage = $"Name: {Name}\nEmail: {Email}\n" +
			$"Date of Birth: {DateofBirth:dd/MM/yyyy}\nGender: {Gender}\n" +
			$"Agree to Terms: {Agree}\n" + $"Experience: {Experience}\nDependents: {Dependents}";
		
		DisplayAlert("Registration",massage,"OK");
    }

	
}