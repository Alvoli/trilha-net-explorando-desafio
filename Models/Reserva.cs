namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (Suite.Capacidade>=hospedes.Count())
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception ("O número de hóspedes é maior que a capacidade máxima.");
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int qtdHospedes = Hospedes.Count();
            return qtdHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // Cálculo: DiasReservados X Suite.ValorDiaria
            decimal valor = DiasReservados*Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados > 10)
            {
                valor = (DiasReservados*Suite.ValorDiaria)- (DiasReservados*Suite.ValorDiaria*0.1M);
            }

            return valor;
        }
    }
}