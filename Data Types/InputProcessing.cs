using System;
using System.Globalization;

public class InputProcessing{

	
	enum UserId
	{
		Anu =0,
		Dhanu =1,
		Kasthu =2,
		Gundoos =3

	}

	public void Conversion()
	{
		Console.WriteLine("Enter a number");
		var val = Console.ReadLine();

		if (string.IsNullOrWhiteSpace(val))
		{
			LogFailure("Input is null or empty");
			return;

		}
		//INT Validation
		if(int.TryParse(val, out int x))
		{
			Console.WriteLine($" Integer : {x}");
		}
		else{
			LogFailure("Input value is not integer");
			return;

		}
		//DOUBLE VALIDATION
		if(double.TryParse(val, NumberStyles.Any, CultureInfo.InvariantCulture, out double y)
)
        {
			Console.WriteLine($" Double : {y}");
		}
        else
        {
            LogFailure("Input value is not Double");
			return;

        }
        //ENUM VALIDATION
        if (int.TryParse(val, out int enumValue) && Enum.IsDefined(typeof(UserId), enumValue)) // Enum.TryParse<UserId>("Dhanu", out var user);

        {
            Console.WriteLine((UserId) enumValue);

		}
		else{
            LogFailure("Input value is not a valid enum type");
			return;

        }


    }

	public void LogFailure(string message)
	{
		Console.WriteLine(message);
	}


}
