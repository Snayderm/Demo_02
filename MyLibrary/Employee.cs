﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
	public abstract class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public int GetInt()
		{
			return 5;
		}q
		public abstract decimal CalculateMonthlyPayment();
	}

	public class Secretary : Employee
	{
		public override decimal CalculateMonthlyPayment() => 15000;
	}

	public class Manager : Employee
	{
		public override decimal CalculateMonthlyPayment()
		{
			return 30000;
		}
	}						 
}