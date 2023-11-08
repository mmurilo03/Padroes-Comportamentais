namespace Padroes;

public abstract class Template {

    private string Descritor = "Fuleco";


    public void Imprimir(){
        Console.WriteLine("IFPB");
        Console.WriteLine($"Autor: {GetDescritor()}");
        Console.WriteLine(EstruturarIntroducao());
        Console.WriteLine(EstruturarCorpo());
    }

    public void SetDescritor(string descritor){
        Descritor = descritor;
    }

    public string GetDescritor(){
        return Descritor;
    }

    protected abstract string EstruturarIntroducao();
    protected abstract string EstruturarCorpo();
}