namespace advanced {
  interface Pessoa {
    int id { get; }
    string nome { get; }
    string telefone { get; }
    string documento { get; }
    string email { get; }

    bool Cadastro();
  }
}
