using classe_usando_abstract;
using Documents.classe_usando_abstract;

//Professor professor = new Professor();
//professor.Apresentar("Carlos", 40);

//Aluno aluno = new Aluno();
//aluno.Apresentar("João", 16);

// Nokia nokia = new Nokia();
// nokia.Numero = "5498136-1461";
// nokia.Modelo = "Nokia Tijolão";
// nokia.IMEI = "123456";
// nokia.Memoria = 64;

// nokia.Ligar();
// nokia.ReceberLigacao();
// nokia.InstalarAplicativo("WhatsApp");
// Console.WriteLine("--------------------------------");

// Iphone iphone = new Iphone();
// iphone.Numero = "5499978-4898";
// iphone.Modelo = "iPhone 15";
// iphone.IMEI = "654321";
// iphone.Memoria = 256;

// iphone.Ligar();
// iphone.ReceberLigacao();
// iphone.InstalarAplicativo("Instagram");
// Console.WriteLine("--------------------------------");

////////////////// DESAFIO 2 ///////////////////////
/// 
// int maior = 0;
// int posicao = 0;

// for (int i = 1; i <= 100; i++)
// {
//     int numero = int.Parse(Console.ReadLine());

//     if (numero > maior)
//     {
//         maior = numero;
//         posicao = i;
//     }
// }

// Console.WriteLine(maior);
// Console.WriteLine(posicao);

////////////////// DESAFIO 3 ///////////////////////////
double A = double.Parse(Console.ReadLine());
double B = double.Parse(Console.ReadLine());
double C = double.Parse(Console.ReadLine());

double media = ((A * 2) + (B * 3) + (C * 5)) / 10;

Console.WriteLine("MEDIA = " + media);
