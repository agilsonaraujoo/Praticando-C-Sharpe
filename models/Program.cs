 using exemplo.Calculadora;

 int numero = 10;
 Console.WriteLine($"{numero} x 1 = {numero * 1}");

// int numero = 10;

// Console.WriteLine(numero);

// Console.WriteLine("Incrementando o 10");
// numero = numero + 1;

// Console.WriteLine(numero);



  Calculadora calc = new Calculadora();

   calc.RaizQuadrada(9);
   calc.Somar(10, 30);
   calc.Subtrair(10,50);
   calc.Multiplicar(15, 45);
   calc.Dividir(2, 2);
   calc.Potencia(3, 3);
   calc.Seno(30);
   calc.Coseno(30);
   calc.Tangente(30);

// bool choveu = true;
// bool estaTarde = true;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar!");
// }

// else
// {
//     Console.WriteLine("Vou pedalar outro dia!");
// }



// bool possuiPresencaMinima = true;
// double media = 6.9;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else {
//     Console.WriteLine("Reprovado!");
// }




// bool eMaiorDeIdade = true;
// bool  possuiAutorizacao = false;

// if (eMaiorDeIdade || possuiAutorizacao) {
//     Console.WriteLine("Entrada liberada!");
// }
// else {
//     Console.WriteLine("Entrada negada!");
// }











// Console.WriteLine("Digite uma letra:");
// string letra = Console.ReadLine();


// switch(letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//     Console.WriteLine("Vogal");
//     break;

//     default:
//     Console.WriteLine("Não é uma vogal!");

//     break;
// }










// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u"
//     ) 
// {
//     Console.WriteLine("Vogal.");
// }
// else  {
//     Console.WriteLine("Não é uma vogal.");
// }












// int quantidadeEmEstoque = 1;
// int quantidadeEmCompra = 2;
// bool possivelVenda = quantidadeEmEstoque > 0 && quantidadeEmEstoque >= quantidadeEmCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade em compra: {quantidadeEmCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeEmCompra == 0) {
//     Console.WriteLine("Valor inválido.");
// }

// else if (possivelVenda) {
//     Console.WriteLine("Venda realizada!");
// }

// else {
//     Console.WriteLine("Venda não realizada. Estoque insuficiente.");
// }


// string a = "15";

// int b = 0;

// int.TryParse(a, out b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");


// // cast - casting (converte os tipos de stings, ints, booleans, etc...)
// string a = Convert.ToString("Agilson");

// Console.WriteLine(a);

// int a = 5;
// string b = a.ToString();

// Console.WriteLine(b);

// int a = 5;
// double b = a;

// Console.WriteLine(b);

// int a = int.MaxValue;
// long b = a;

// Console.WriteLine(b);

// double a = 4 / (2 + 2);

//     Console.WriteLine(a);

















// CTRL + K +C 

// int a = 10;
// int b = 20;

// int c = a + b;

// c *= 5;

// Console.WriteLine(c);

