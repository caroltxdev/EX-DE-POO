using System.Collections.Generic;

// Professor, essa interface define um contrato básico de armazenamento.
// Qualquer classe que implementá-la será obrigada a ter esses métodos.
public interface IArmazenamento
{
    void Salvar(string arquivo, byte[] dados);   // Salva dados com base no nome do arquivo
    byte[] Carregar(string arquivo);             // Carrega os dados de um arquivo
    void Excluir(string arquivo);                // Remove o arquivo do armazenamento
    List<string> Listar();                       // Lista todos os arquivos disponíveis
}
