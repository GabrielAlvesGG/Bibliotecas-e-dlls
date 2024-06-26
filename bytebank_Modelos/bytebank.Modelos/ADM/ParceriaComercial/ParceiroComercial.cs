﻿using bytebank.Modelos.ADM.SistemaInterno;

namespace bytebank.Modelos.ADM.Utilitario
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
         private AutenticacaoUtil Autenticador { get; set; }
        public bool Autenticar(string senha)
        {
            return this.Autenticador.ValidarSenha(this.Senha, senha);
        }
    }
}
