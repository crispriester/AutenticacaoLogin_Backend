using Negocio.Dto;

namespace Negocio.Dto
{
    public class MensagemRetornoDto
    {
        public string Mensagem { get; set; }

        public MensagemRetornoDto(string mensagem)
        {
            Mensagem = mensagem;
        }
    }
}