﻿using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class TarefaDAO
    {
        private readonly Context _context;

        public TarefaDAO(Context context)
        {
            _context = context;
        }

        public void CadastrarNovaTarefa(Tarefa t)
        {
            _context.Tarefas.Add(t);
            _context.SaveChanges();
        }

        public List<Tarefa> ListarTarefas()
        {
            List<Tarefa> ListTarefas = _context.Tarefas.Include("Responsavel").ToList();
            return ListTarefas;
        }

        //metodo que localiza o campo da chave primaria e busca
        public Tarefa BuscarTarefaoPorId(int id)
        {
            Tarefa tarefa = _context.Tarefas.Include("Responsavel").FirstOrDefault(t => t.TarefaId == id);

            return tarefa;
        }

        public void EditarTarefa(Tarefa tAlterada)
        {
            var result = _context.Tarefas.SingleOrDefault(t => t.TarefaId == tAlterada.TarefaId);
            if (result != null)
            {
                result.TituloTarefa = tAlterada.TituloTarefa;
                result.DescricaoTarefa = tAlterada.DescricaoTarefa;
                result.DataEntregaTarefa = tAlterada.DataEntregaTarefa;
                result.Responsavel = tAlterada.Responsavel;
                result.StatusTarefa = tAlterada.StatusTarefa;
                _context.SaveChanges();
            }

        }

        public void ExluirTarefa(Tarefa t)
        {
            _context.Tarefas.Remove(t);
            _context.SaveChanges();
        }
    }
}
