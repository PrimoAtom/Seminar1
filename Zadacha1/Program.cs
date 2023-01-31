		Console.WriteLine("Введите по очереди два отличающихся числа");
		if(int.TryParse(Console.ReadLine(), out var firstNumber))
		{
			Console.WriteLine($"Ваше первое число {firstNumber}");
		}
		else
		{
			Console.WriteLine("Ввод не является целым числом");
		}
		if(int.TryParse(Console.ReadLine(), out var secondNumber))
		{
			Console.WriteLine($"Ваше второе число {secondNumber}");
		}
		else
		{
			Console.WriteLine("Ввод не является целым числом");
		}

		if (firstNumber > secondNumber) 
		{
			Console.WriteLine($"Большее число {firstNumber}, меньшее число {secondNumber}");
		}
		else if (secondNumber > firstNumber)
		{
			Console.WriteLine($"Большее число {secondNumber}, меньшее число {firstNumber}");
		}
		else 
		{
			Console.WriteLine("Введены некорректные или равные значения, попробуйте еще разок");
		}