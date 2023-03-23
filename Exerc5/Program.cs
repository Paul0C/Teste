// See https://aka.ms/new-console-template for more information
Console.Write("Insira a palavra para que invertamos os caracteres dela: ");
string palavra = Console.ReadLine();
palavra.ToArray();
string inverso = "";
for (int i = palavra.Length - 1; i >= 0; i--){
    inverso += palavra[i].ToString();
}

Console.WriteLine(inverso);
