// See https://aka.ms/new-console-template for more information




Console.BackgroundColor = ConsoleColor.Cyan;
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("Bom dia Qual o seu nome ?");

String nome = Console.ReadLine();

Console.WriteLine("Seu nome é " + nome);

Console.WriteLine("");

Console.WriteLine("Gostaria de calcular algumas coisas ?");

Console.WriteLine("Digite Sim para confirmar | Não para cancelar");




String r = Console.ReadLine();

if(r=="Sim" || r=="sim"){
    Console.WriteLine("Lets Go");


    Thread.Sleep(3000); //delay

    Console.WriteLine("Então me Informe por gentileza que Operação você gostaria de fazer:");

    Thread.Sleep(1000);
    Console.Write(" Para somar use o       .......  + |");
    Console.WriteLine(" Para subtrair use o    .......  - |");
    Console.Write(" Para multiplicar use o .......  x |");
    Console.Write(" Para dividir use o     .......  / |");
    




}else{

    Console.WriteLine("Poxa que pena");

}












