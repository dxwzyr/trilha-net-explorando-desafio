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

        // Cadastrar hóspedes na reserva
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Verificar se a capacidade da suíte é maior ou igual ao número de hóspedes
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes; // Atribui os hóspedes à reserva
            }
            else
            {
                // Lança uma exceção caso a capacidade seja menor que o número de hóspedes
                throw new Exception("A quantidade de hóspedes excede a capacidade da suíte.");
            }
        }

        // Cadastrar a suíte na reserva
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        // Retorna a quantidade de hóspedes
        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        // Calcula o valor total da diária
        public decimal CalcularValorDiaria()
        {
            // Calcula o valor total da diária sem o desconto
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Aplica um desconto de 10% se a reserva for maior ou igual a 10 dias
            if (DiasReservados >= 10)
            {
                valor = valor * 0.9m; // 10% de desconto
            }

            return valor;
        }
    }
}
