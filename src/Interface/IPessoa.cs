namespace ProjetoEducar.Interface
{
    public interface IPessoa
    {
        void SetPessoa(string nome, string sexo, DateTime datanascimento);
        string GetNome();
        string GetIdade();
        string GetSexo();
    }
}
