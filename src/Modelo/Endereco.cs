namespace ProjetoEducar.Modelo
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        
        public Endereco()
        {
        }

        public void SetDados(string logradouro, string numero, string cep, string cidade, string estado)
        {
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.CEP = cep;
            this.Cidade = cidade;
            this.Estado = estado;


        }

    }
}
