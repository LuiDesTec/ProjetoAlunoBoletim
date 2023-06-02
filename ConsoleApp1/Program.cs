// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*SP – R$67.836,43
RJ – R$36.678,66
MG – R$29.229,88
ES – R$27.165,48
Outros – R$19.849,53*/


    double sp = 67836.43;
    double rj = 36678.66;
    double mg = 29229.88;
    double es = 27165.48;
    double outros = 19849.53;

    double valorTotal = sp + rj + mg + es + outros;

    double percentualSP = (sp / valorTotal) * 100;
    double percentualRJ = (rj / valorTotal) * 100;
    double percentualMG = (mg / valorTotal) * 100;
    double percentualES = (es / valorTotal) * 100;
    double percentualOutros = (outros / valorTotal) * 100;

    Console.WriteLine("Percentual de representação por estado:");
    Console.WriteLine("SP: {0}%.", percentualSP);
    Console.WriteLine("RJ: {0}%.", percentualRJ);
    Console.WriteLine("MG: {0}%.", percentualMG);
    Console.WriteLine("ES: {0}%.", percentualES);
    Console.WriteLine("Outros: {0}%.", percentualOutros);

