using System;
using static Enumerations;

public class Enumerations
{
	 public enum AccountStatus {
	   None =0,
	   Active =1,
	   Suspended =2,
	   Closed =3
	}

	internal static void Print()
	{
		AccountStatus status = AccountStatus.Active;
		Console.WriteLine(status);

		//Cast an integer 2 to AccountStatus and print 
		int a = 2;
		AccountStatus val = (AccountStatus)a;
		Console.WriteLine(val.ToString());
		//Cast an integer 99 to AccountStatus and print 
		int b = 99;
		AccountStatus res = (AccountStatus)b;
        Console.WriteLine(res.ToString());

    }

    internal static bool IsValidAccountStatus(AccountStatus status)
	{
        if (Enum.IsDefined(typeof(AccountStatus), status))
        {
			return true;

        }
        else
        {
			return false;

        }


    }

    internal static void Conditions(AccountStatus status)
	{
		if(status == AccountStatus.Suspended) // or status == Suspended
		{
			Console.WriteLine("Access Denied");
		}
		else
		{
			Console.WriteLine("Access Accepted");
		}
		if (Enum.IsDefined(typeof(AccountStatus), 99))
		{
			Console.WriteLine("Enum exists");

		}
		else
		{
            Console.WriteLine("Enum doesn't exist");

        }

	}

}
