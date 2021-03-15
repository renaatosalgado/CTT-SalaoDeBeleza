using Microsoft.EntityFrameworkCore;
using Minha1Conexao.Data.Repository.Base;
using SalaoT2.Dominio;
using SalaoT2.Dominio.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaoT2.Data.Repositorio
{
    public class AgendamentoRepositorio : BaseRepositorio<Agendamento>
    {
        #region sobrescrita
        public new void Incluir(Agendamento agendamento) {

            if (NaoPermiteAgendar(agendamento))
            {
                new Exception("Esse horário não está livre.");
            }
            else {
                contexto.Agendamento.Add(agendamento);
                contexto.SaveChanges();
            }
        }

        public new void Alterar(Agendamento agendamento)
        {
            if (NaoPermiteAgendar(agendamento))
            {
                new Exception("Esse horário não está livre.");
            }
            else
            {
                contexto.Agendamento.Update(agendamento);
                contexto.SaveChanges();
            }
        }

        #endregion sobrescrita


        private bool NaoPermiteAgendar(Agendamento agendamento)
        {
            var servicoParaAgendar = contexto.ServicoSolicitado.FirstOrDefault(ss => ss.Id == agendamento.ServicoSolicitadoId);
            var servico = contexto.Servico.FirstOrDefault(s => s.Id == servicoParaAgendar.ServicoId);

            // Detached se não da erro no update
            contexto.Entry(servicoParaAgendar).State = EntityState.Detached;
            contexto.Entry(servico).State = EntityState.Detached;

            DateTime dtAgendamento = agendamento.DataAgendamento;

            DateTime dataTerminoParaAgendar = dtAgendamento.AddMinutes(servico.MinutosParaExecucao);
            return (contexto.Agendamento.Any(a => a.DataAgendamento >= dtAgendamento &&
                    a.ServicoSolicitado.FuncionarioId == servicoParaAgendar.FuncionarioId &&
                    (a.Status != StatusAgenda.CanceladoPeloSalao || a.Status != StatusAgenda.CanceladoPeloCliente)) &&
                contexto.Agendamento.Any(a => a.DataAgendamento <= dataTerminoParaAgendar &&
                    (a.Status != StatusAgenda.CanceladoPeloSalao || a.Status != StatusAgenda.CanceladoPeloCliente)));
        }
    }
}
