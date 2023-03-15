using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tarde
{
    public class Endereco
    {
        private int Id;
        private int Cep;
        private string Rua;
        private string Bairro;
        private string Cidade;
        private int Numero;
        public Endereco(int id, int cep, string rua, string bairro, string cidade, int numero)
        {
            Id = id;
            Cep = cep;
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            Numero = numero;
        }
        public void AtualizarEndereco(string rua, int numero, string bairro)
        {
            setBairro(bairro);
            setNumero(numero);
            setRua(rua);
        }
        public string EnderecoCompleto()
        {
            return "Rua " + Rua + ", Nº " + Numero + " Bairro: " + Bairro + " Cidade: " + Cidade;
        }
        public int getId()
        {
            return Id;
        }
        public void setId(int id)
        {
            Id = id;
        }
        public int getCep()
        {
            return Cep;
        }
        public void setCep(int cep)
        {
            Cep = cep;
        }
        public string getRua()
        {
            return Rua;
        }
        public void setRua(string rua)
        {
            Rua = rua;
        }
        public string getBairro()
        {
            return Bairro;
        }
        public void setBairro(string bairro)
        {
            Bairro = bairro;
        }
        public string getCidade()
        {
            return Cidade;
        }
        public void setCidade(string cidade)
        {
            Cidade = cidade;
        }
        public int getNumero()
        {
            return Numero;
        }
        public void setNumero(int numero)
        {
            Numero = numero;
        }
    }
}
