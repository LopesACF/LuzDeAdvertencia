Console.WriteLine("--- Simulador de Luz de Advertência ---");
Console.WriteLine("[A]tivado, [D]esativado");


Console.WriteLine("O sensor T de temperatura está ativado? ");
string temperatura = Console.ReadLine()!.Substring(0,1).ToUpper();

if (temperatura == "D"){
    Console.WriteLine("A luz de advertência estará DESATIVADA.");
    return;
}

Console.WriteLine("o sensor P de pressão está ativado? ");
string pressao = Console.ReadLine()!.Substring(0,1).ToUpper();

Console.WriteLine("o sensor R de rotação está ativado? ");
string rotacao = Console.ReadLine()!.Substring(0,1).ToUpper();


if (temperatura == "A" && pressao == "A" && rotacao == "A"){
    Console.WriteLine("A luz de advertência estará ATIVADA.");
}
else if (temperatura == "A" && pressao == "A" && rotacao == "D"){
    Console.WriteLine("A luz de advertência estará ATIVADA.");
}
else if (temperatura == "A" && pressao == "D" && rotacao == "A"){
    Console.WriteLine("A luz de advertência estará ATIVADA.");
}
