namespace Padroes;

public class Estrutura : Template {

    protected override string EstruturarIntroducao()
    {
        return "Estrutura introdução Lorem ipsum";
    }

    protected override string EstruturarCorpo()
    {
        return "i’ll have two number 9s, a number 9 large, a number 6 with extra dip, a number 7, two number 45s, one with cheese, and a large soda.";
    }
}