using SaveAddress.DataBase.TabelaModelos;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaveAddress.DataBase
{
    public class DataBaseClass
    {
        SQLiteConnection SQLiteConnection { get; }
        public DataBaseClass(SQLiteConnection SQLiteConnection)
        {
            this.SQLiteConnection = SQLiteConnection;
            SQLiteConnection.CreateTable<Localizacao>();
        }
        public void Inserir(Localizacao localizacao)
        {
            try
            {
                int result = SQLiteConnection.Insert(localizacao);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Localizacao> Listar()
        {
            List<Localizacao> lista = new List<Localizacao>();
            try
            {
                lista = SQLiteConnection.Table<Localizacao>().ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }
        public void Alterar(Localizacao localizacao)
        {
            try
            {
                if (localizacao.Id == 0) throw new Exception("ID não encontrado");
                int result=SQLiteConnection.Update(localizacao);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Apagar(Localizacao localizacao)
        {
            try
            {
                int result = SQLiteConnection.Table<Localizacao>().Delete(r=>r.Id==localizacao.Id);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Localizacao> Procurar(string nome)
        {
            List<Localizacao> localizacaos = new List<Localizacao>();
            try
            {
                var resp = from p in SQLiteConnection.Table<Localizacao>() where p.Nome.ToLower().Contains(nome.ToLower()) select p;
                localizacaos= resp.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return localizacaos;
        }
        public Localizacao Ver(int id)
        {
            Localizacao local=new Localizacao();
            try
            {
                local = SQLiteConnection.Table<Localizacao>().First(n => n.Id == id);
            }
            catch (Exception)
            {

                throw;
            }
            return (local);
        }
    }
}
