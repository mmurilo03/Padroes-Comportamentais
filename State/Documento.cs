namespace Padroes;

public class Documento {

    public Documento(IDocumento estadoAtual) {
        this.estadoAtual = estadoAtual;
    }

    private IDocumento estadoAtual;

    public void Aprovar() {
        estadoAtual = estadoAtual.Aprovar();
    }

    public void Reprovar() {
        estadoAtual = estadoAtual.Reprovar();
    }

    public void Estado() {
        estadoAtual.Estado();
    }
}