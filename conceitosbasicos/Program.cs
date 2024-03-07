using System.Data;

Console.WriteLine("Informe seu peso: ");
int peso = int.Parse(Console.ReadLine());

Console.WriteLine("Informe sua altura: ");
float altura = float.Parse(Console.ReadLine());

float imc = peso / (altura * altura);

Console.WriteLine($"Para peso {peso} e a altura {altura} o imc calculado foi {imc:f1");

string status = string.Empty;
if (imc <= 16.9)
    status = "muito abaixo do peso";
else if (imc <= 18.4)
    status = "abaixo do peso";
