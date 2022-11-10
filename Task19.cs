Console.WriteLine("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine());
int FirstDigit = n/10000;
int SecondDigit =(n / 1000) % 10;
int FourthDigit =(n / 10) % 10;
int LastDigit = n % 10;
  if ((FirstDigit == LastDigit)&&(SecondDigit == FourthDigit))
  Console.WriteLine("Это число - палиндром");
  else
  {
   Console.WriteLine("Это число - не палиндром"); 
  }

