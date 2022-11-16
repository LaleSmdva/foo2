// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Ayin adini daxil edin: ");

//string month = Console.ReadLine();



//int result = month switch
//{
//    "January" => 31,
//    "February" => 28,
//    "March" => 31,
//    "April" => 30,
//    "May" => 31,
//    "June" => 30,
//    "July" => 31,
//    "August" => 31,
//    "September" => 31,
//    "October" => 31,
//    "November" => 30,
//    "December" => 31,
//    _ => 0
//};

//Console.WriteLine(result);


//int result = month switch
//{
//    "January" or "March" "May" or "July" or "August" or  "October" or   "December" => 31,

//    "April" or "June" or "September" or "November" => 30,

//    _ => 28

//};
//Console.WriteLine(result);



//using System.Diagnostics.Metrics;

//int countLetter = 0;

//Console.WriteLine("Enter some text: ");
//string text =Console.ReadLine();

//Console.WriteLine("Enter a letter: ");
//string letter = Console.ReadLine();

//if (letter=="")
//{
//	Console.WriteLine("enter a letter");
//}
//else
//{
//    for(int i = 0; i < text.Length; i++)
//{

//        if (text[i] == letter[0])
//        {
//            countLetter++;
//        }
//    }
//    Console.WriteLine("There are " + countLetter + " from this letter");
//}

//Console.WriteLine("Enter some text: ");
//string text = Console.ReadLine();

//Console.WriteLine("Enter a subtext: ");
//string subText = Console.ReadLine();

//for (int i = 0; i < text.Length; i++)
//{
//	for (int j = 0; j < subText.Length;j++)
//	{
//		if(text[i] == subText[j])
//		{
//			Console.WriteLine(i);
//        }
//	}
//}

//Console.WriteLine("Arrayin uzunlugunu daxil edin: ");
//int n = int.Parse(Console.ReadLine());
//if(n<=0)
//{
//    Console.WriteLine("Musbet eded daxil edin");
//}
//else
//{
//int sum = 0;
//int[] arrayel = new int[n];
//Console.WriteLine("Arrayin elementlerini daxil edin: ");
//for (int i = 0; i < arrayel.Length; i++)
//{
//    arrayel[i] = int.Parse(Console.ReadLine());
//    if (arrayel[i] % 2 == 0)
//    {
//        sum += arrayel[i];
//    }
//}
//for (int i = 0; i < arrayel.Length; i++)
//{
//    Console.WriteLine(arrayel[i]);
//}

//Console.WriteLine("\n"+sum);

//}

//double result(double x, double y)
//{
//    return x/y;
//}
//Console.WriteLine(result(30,7));


//TEK ARRAY ELEMENTLERI*****

//using System.Diagnostics.Metrics;

//int counter = 0;
//int Total(params int[] arr)
//{

//    Console.WriteLine("Enter array elements");
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] % 2 != 0)
//        {
//            counter++;
//        }
//    }
//    return counter;
//}

//Console.WriteLine(Total(2, 23, 5, 8));
//Console.WriteLine("The number of odds: " + counter);

//REVERSE TEXT****

//string text = "salam";
//string reverseText="";
//string Reverse( string text)
//{
//	for (int i = text.Length - 1; i >= 0; i--)
//	{
//		reverseText += text[i];
//	}
//	return reverseText;
//}
//Console.WriteLine("Reverse is: "+Reverse("lala"));



