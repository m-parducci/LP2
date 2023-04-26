using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    abstract class Empregado
    {
        private int matricula;
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;
        private char homeOffice;

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }

        }

        public string NomeEmpregado
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }

        public DateTime DataEntradaEmpresa
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }
        public char HomeOffice
        {
            get { return HomeOffice; }
            set { homeOffice = value; }
        }
        // métodos são ações, comportamentos
        public string VerificaHome() //método
        {
            if (homeOffice == 'S')
                return "Empregado trabalha em home offica";
            else
                return "Empregado não trabalha em home office";
        }

        //virtual -> pode ser sobreescrito

        public virtual int TempoTrabalho()
        {
            //representa um intervalo de tempo
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);
            return (span.Days);
        }

        //deve ser implementado nas classes filhas (subclasses)

        public abstract double SalarioBruto(); // não precisa implementar

    }
}
