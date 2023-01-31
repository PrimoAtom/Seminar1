		Console.WriteLine("Введите по очереди три числа");
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
        if(int.TryParse(Console.ReadLine(), out var thirdNumber))
		{
			Console.WriteLine($"Ваше третье число {thirdNumber}");
		}
		else
		{
			Console.WriteLine("Ввод не является целым числом");
		}
        int max = firstNumber;
        
		if (firstNumber > max) max = firstNumber;
		if (secondNumber > max) max = secondNumber;
        if (thirdNumber > max) max = thirdNumber;
        
		{
			Console.WriteLine($"Большее число {max}");
		}