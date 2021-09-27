using System;
using System.Collections.Generic;
using DIO.Series.interfaces;

namespace DIO.Carros
{
    public class SerieRepositorio : IRepositorio<Carros>
    {
        private List<Carros> listaSerie = new List<Carros>();
        public void Atualiza(int id, Carros objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Carros objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Carros> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Carros RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}