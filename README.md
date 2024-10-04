EPQ1 Coding.

22/07/2024 
Working on UI 

Calculator from dofe work
public static string bidmas(string equation) 

{ 

     return "0"; 

} 

public static float methodise(string arg1, string arg2, string method, float Total) 

{ 

     //Console.WriteLine(arg1 + " " + arg2 + " " + method); 

     Console.WriteLine(arg1, arg2); 

     float argumentDifference = 0; 

     if (arg2 == "") {arg2 = "0"; argumentDifference = Total; } 

     if (arg1 == "") {arg1 = "0"; argumentDifference = Total; } 

     float Radical(float intarg1, float intarg2) 

     { 

        return (float)Math.Pow(Convert.ToDouble(intarg2), Convert.ToDouble(1 / intarg1)); 

     } 

  

     float Exponent(float intarg1, float intarg2) 

     { 

         float exponentTotal = intarg1; 

         if (intarg2 == 0) { return 1; } 

         for (int i = 1; i < intarg2; i++) 

         { 

             exponentTotal = exponentTotal * intarg1; 

         } 

         return exponentTotal - argumentDifference; 

     } 

  

     float Multiply(float intarg1, float intarg2) 

     { 

         return intarg1 * intarg2 - argumentDifference; 

     } 

  

     float Divide(float intarg1, float intarg2) 

     { 

         return intarg1 / intarg2 - argumentDifference; 

     } 

  

     float Add(float intarg1, float intarg2) 

     { 

         return intarg1 + intarg2; 

     } 

  

     float Subtract(float intarg1, float intarg2) 

     { 

         return intarg1 - intarg2; 

     } 

      

     switch (method) 

     { 

         case "√": 

             if (arg2 == "0") { arg2 = Convert.ToString(Total); } 

             if (arg1 == "0") { arg1 = Convert.ToString(Total); } 

             return Radical(Convert.ToSingle(arg1), Convert.ToSingle(arg2)); 

         case "^": 

             if (arg2 == "0") { arg2 = Convert.ToString(Total); } 

             if (arg1 == "0") { arg1 = Convert.ToString(Total); } 

             return Exponent(Convert.ToSingle(arg1), Convert.ToSingle(arg2)); 

         case "*": 

             if (arg2 == "0") {arg2 = Convert.ToString(Total);} 

             if (arg1 == "0") {arg1 = Convert.ToString(Total);} 

             return Multiply(Convert.ToSingle(arg1), Convert.ToSingle(arg2)); 

         case "/": 

             if (arg2 == "0") { arg2 = arg1;  arg1 = Convert.ToString(Total);} 

             if (arg1 == "0") { arg1 = arg2;  arg2 = Convert.ToString(Total);} 

             return Divide(Convert.ToSingle(arg1), Convert.ToSingle(arg2)); 

         case "+": 

             return Add(Convert.ToSingle(arg1), Convert.ToSingle(arg2)); 

         case "-": 

             return Subtract(Convert.ToSingle(arg1), Convert.ToSingle(arg2)); 

     } 

  

     return 0; 

} 

public static string calculate(string Equation) 

{ 

     float Total = 0; 

     Boolean Formulating = true; 

     int Count = 0; 

     int MCount = 0; 

     string CurrentNumber = ""; 

     List<string> Components = new List<string>(); 

     List<string> Methods = new List<string>(); 

     Components.Insert(0, ""); 

     Methods.Insert(0, ""); 

  

     for (int i = 0; i < Equation.Length; i++) 

     { 

         if (Formulating) 

         { 

             if (char.IsDigit(Equation.ToCharArray()[i]) || Equation.ToCharArray()[i] == Convert.ToChar(".") || Equation.ToCharArray()[i] == Convert.ToChar("E")) 

             { 

                 CurrentNumber += Convert.ToString(Equation.ToCharArray()[i]); 

             } 

             else 

             { 

                 Components.Insert(Count, CurrentNumber); 

                 Count++; 

                 Formulating = false; 

                 Methods.Insert((MCount + 1), ""); 

                 Methods.Insert(MCount, Convert.ToString(Equation.ToCharArray()[i])); 

                 MCount+= 2; 

                 CurrentNumber = ""; 

             } 

         } 

         else 

         { 

             if (char.IsDigit(Equation.ToCharArray()[i]) || Equation.ToCharArray()[i] == Convert.ToChar(".") || Equation.ToCharArray()[i] == Convert.ToChar("E")) 

             { 

                 Formulating = true; 

                 CurrentNumber = Convert.ToString(Equation.ToCharArray()[i]); 

             } 

         } 

     } 

     if (CurrentNumber != "") 

     { 

         Components.Insert(Count, CurrentNumber); 

     } 

  

     for (int i = 0; i <= Components.Count(); i++) 

     { 

         if (i % 2 == 0) 

         { 

             if (Components.Count > (i + 1) && Methods.Count > i) 

             { 

                 //Console.WriteLine(Components[i]); 

                 if (i == 0 || Components[i + 1] == "" || Components[i] == "") { 

                     Total += methodise(Components[i], Components[i + 1], Methods[i], Total); 

                 } 

                 else 

                 { 

                     switch (Methods[i - 2]) 

                     { 

                         case "*": 

                             Total *= methodise(Components[i], Components[i + 1], Methods[i], Total); 

                             break; 

                         case "/": 

                             Total /= methodise(Components[i], Components[i + 1], Methods[i], Total); 

                             break; 

                         case "+": 

                             Total += methodise(Components[i], Components[i + 1], Methods[i], Total); 

                             break; 

                         case "-": 

                             Total -= methodise(Components[i], Components[i + 1], Methods[i], Total); 

                             break; 

                     } 

                 } 

             } 

         } 

     } 

  

     return Convert.ToString(Total); 

} 

  

public List<string> Components = new List<string>(); 
