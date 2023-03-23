int Fibonacci = 0, fb1 = 0, fb2 = 1;

Console.Write("Insira um número inteiro para verificar se ele pertence ou não à sequência de Fibonacci: ");
int num = int.Parse(Console.ReadLine());

while(Fibonacci != num && Fibonacci < num){
    Fibonacci = fb1 + fb2;
    fb1 = fb2;
    fb2 = Fibonacci;
}

if(Fibonacci == num){
    Console.WriteLine("O número informado pertence à sequência de Fibonacci!");
}else{
    Console.WriteLine("O número informado não pertence à sequência de Fibonacci.");
}