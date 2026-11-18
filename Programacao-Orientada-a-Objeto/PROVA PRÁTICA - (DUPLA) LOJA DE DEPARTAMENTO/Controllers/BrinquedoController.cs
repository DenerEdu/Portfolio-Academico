using System;
using System.Collections.Generic;
using P1POO.Models;

namespace P1POO.Controllers
{
    public class BrinquedoController
    {
        private List<Brinquedo> listaBrinquedos;

        public BrinquedoController()
        {
            listaBrinquedos = new List<Brinquedo>();
        }

        public void Adicionar(Brinquedo brinquedo)
        {
            if (brinquedo == null)
            {
                throw new Exception("Objeto brinquedo não pode ser nulo.");
            }
            listaBrinquedos.Add(brinquedo);
        }

        public void Remover(int index)
        {
            if (index < 0 || index >= listaBrinquedos.Count)
            {
                throw new Exception("Índice inválido para remoção.");
            }
            listaBrinquedos.RemoveAt(index);
        }

        public List<Brinquedo> ListarTodos()
        {
            return listaBrinquedos;
        }

        public Brinquedo ObterPorIndice(int index)
        {
            if (index < 0 || index >= listaBrinquedos.Count)
            {
                throw new Exception("Brinquedo não encontrado.");
            }
            return listaBrinquedos[index];
        }
    }
}
