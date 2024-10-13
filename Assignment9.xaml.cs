namespace Assignment9;

public partial class Assignment9 : ContentPage
{
	public Assignment9()
	{
		InitializeComponent();
	}

    private void Male_Clicked(object sender, EventArgs e)
    {
		if (sender is Button button)
		{
			//เปลี่ยนสีปุ่ม เมื่อถูกคลิก
			button.BackgroundColor= Colors.SeaGreen;
		}
    }

    private void Female_Clicked(object sender, EventArgs e)
    {
		if (sender is Button button)
		{
			//เปลี่ยนสีปุ่ม เมื่อถูกคลิก
			button.BackgroundColor= Colors.SeaGreen;
		}
    }
		//คำนวณ
    private void Calculate_Clicked(object sender, EventArgs e)
    {
		string HeightText = EntryHeight.Text;
		string WeightText = EntryWeight.Text;
	

		if(double.TryParse(HeightText, out double HeightInCM) && double.TryParse(WeightText, out double WeightInKg))
		{
			double HeightInM = HeightInCM/100;
			double HeightInMM =  HeightInM * HeightInM;
			double BMI = WeightInKg / HeightInMM;
			

		//แสดงผล BMI ของ User
			UserBMI.Text = $"ดัชนีมวลกาย(BMI): {BMI:F1} กก./ตร.ม." ;

		//แสดง Range ที่เหมาะสม
			Range.Text= $"ช่วง BMI ที่เหมาะสม: {18.6}-{22.9} กก./ตร.ม.";

		//แสดงช่วงน้ำหนักที่เหมาะสมกับ User
			double MinIdealWeight4User = 18.6 * HeightInMM;
			double MaxIdealWeight4User = 22.9 * HeightInMM;
			IdealWeightUser.Text = $"น้ำหนักที่เหมาะสมกับความสูง: {MinIdealWeight4User:F1}-{MaxIdealWeight4User:F1} กก." ;
		
		//แสดงดัชนี Ponderal
			double Ponderal = BMI / HeightInMM;
			PonderalUser.Text = $"ดัชนี Ponderal: {Ponderal:F1} กก./ลบ.ม."; 

		//แสดง Type ของ User
			string Type;
			if (BMI < 18.5)
			{
				Type = "น้ำหนักต่ำเกินไป";
				UserType.Text = $"หมวดหมู่ BMI: {Type}";
			}
			else if  (BMI >= 18.5 && BMI < 22.9)
			{
				Type = "น้ำหนักเหมาะสม";
				UserType.Text = $"หมวดหมู่ BMI: {Type}";
			}
			else if (BMI >= 22.9 && BMI < 24.9)
			{
				Type = "น้ำหนักเกิน";
				UserType.Text = $"หมวดหมู่ BMI: {Type}";
			}
			else if (BMI >= 24.9 && BMI < 29.9)
			{
				Type = "อ้วน";
				UserType.Text = $"หมวดหมู่ BMI: {Type}";
			}
			else
			{
				Type = "อ้วนมาก";
				UserType.Text = $"หมวดหมู่ BMI: {Type}";
			}
			
				//แสดงคำแนะนำ
					string Message;
					if (BMI < 18.5)
					{
						Message = "น้ำหนักน้อยกว่าปกติก็ไม่ค่อยดี หากคุณสูงมากแต่น้ำหนักน้อยเกินไป อาจเสี่ยงต่อการได้รับสารอาหารไม่เพียงพอหรือได้รับพลังงานไม่เพียงพอ ส่งผลให้ร่างกายอ่อนเพลียง่าย การรับประทานอาหารให้เพียงพอและออกกำลังกายแบบเวทเทรนนิ่งเพื่อเสริมสร้างกล้ามเนื้อ สามารถช่วยเพิ่มค่า BMI ให้อยู่ในเกณฑ์ปกติได้";
						AdviceUser.Text = $"คำแนะนำ: {Message}";
					}
					else if  (BMI >= 18.6 && BMI < 22.9)
					{
						Message = "น้ำหนักที่เหมาะสมสำหรับคนไทยคือค่า BMI ระหว่าง 18.5-22.9 จัดอยู่ในเกณฑ์ปกติ ห่างไกลโรคที่เกิดจากความอ้วน และมีความเสี่ยงต่อการเกิดโรคต่าง ๆ น้อยที่สุด ควรพยายามรักษาระดับค่า BMI ให้อยู่ในระดับนี้ให้นานที่สุด";
						AdviceUser.Text = $"คำแนะนำ: {Message}";
					}
					else if (BMI >= 23.0 && BMI < 24.9)
					{
						Message = "พยายามอีกนิดเพื่อลดน้ำหนักให้เข้าสู่ค่ามาตรฐาน เพราะค่า BMI ในช่วงนี้ยังถือว่าเป็นกลุ่มผู้ที่มีความอ้วนอยู่บ้าง แม้จะไม่ถือว่าอ้วน แต่หากประวัติคนในครอบครัวเคยเป็นโรคเบาหวานและความดันโลหิตสูง ก็ถือว่ายังมีความเสี่ยงมากกว่าคนปกติ";
						AdviceUser.Text = $"คำแนะนำ: {Message}";
					}
					else if (BMI >= 25.0 && BMI < 29.9)
					{
						Message = "คุณอ้วนในระดับหนึ่ง ถึงแม้จะไม่ถึงเกณฑ์ที่ถือว่าอ้วนมาก ๆ แต่ก็ยังมีความเสี่ยงต่อการเกิดโรคที่มากับความอ้วนได้เช่นกัน ทั้งโรคเบาหวาน และความดันโลหิตสูง";
						AdviceUser.Text = $"คำแนะนำ: {Message}";
					}
					else
					{
						Message = "ค่อนข้างอันตราย เพราะเข้าเกณฑ์อ้วนมาก เสี่ยงต่อการเกิดโรคร้ายแรงที่แฝงมากับความอ้วน หากค่า BMI อยู่ในระดับนี้ จะต้องระวังการรับประทานไขมัน และควรออกกำลังกายอย่างสม่ำเสมอ หากเลขยิ่งสูงกว่า 40.0 ยิ่งแสดงถึงความอ้วนที่มากขึ้น";
						AdviceUser.Text = $"คำแนะนำ: {Message}";
					}
						//BMIProgressBar
						double ProgressBar;
						if (BMI < 18.5)
						{
							ProgressBar = 0.2;
							BMIstandardBar.Progress = ProgressBar;
						}
						else if  (BMI >= 18.5 && BMI < 22.9)
						{
							ProgressBar = 0.40;
							BMIstandardBar.Progress = ProgressBar;
						}
						else if (BMI >= 22.9 && BMI < 24.9)
						
						{
							ProgressBar = 0.60;
							BMIstandardBar.Progress = ProgressBar;
						}
						else if (BMI >= 24.9 && BMI < 29.9)
						{
							ProgressBar = 0.80;
							BMIstandardBar.Progress = ProgressBar;
						}
						else
						{
							ProgressBar = 0.95;
							BMIstandardBar.Progress = ProgressBar;	
						}
						
					
		}


	}

}
	



