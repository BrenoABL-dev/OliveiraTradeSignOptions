# OliveiraTradeSignOptions
Projeto em c# no Visual Studio 2022. Desenvolvido para o Teste Prático para Desenvovledor
para o Programa Best Minds 2022/2023 - Pessoa Desenvolvedora Trainee pela Everymind

O banco de dados na nuvem da AWS foi desabilitado, conecte seu banco de dados ou me contacte caso queira testar este programa

O Usuário pode entrar com uma conta já feita, guardada em uma base de dados da AWS, ou fazer um registro novo.
Os valores entrados pelo usuário passam por uma verificação básica pelo SignInCtrl
  depois são enviados para SignInCommand, onde é enviando um pedido para o banco de dados
  Caso identificador e a senha existir no banco de dados, o usuário entra no serviço.
  
 Para registrar, o usuário deve digitar um nome, senha, confirmação da senha, CPF e Email.
 A classe SignUpCtrl verifica se os dados estão denetro de certos parametros e que a senha e a confirmação estão iguais
 É utilizado classes de exeções customizadas campos preenchidos incorretamente. Quando reconhecidas, o programa indica o erro em uma janela separada.
 Se tudo estiver certo então a classe SignUpCommand envia os dados para o banco de dados, verificando se há um usuário com o mesmo cpf.
 Se houver um cpf cadastrado então a classe retorna uma mensagem de erro, caso contrário o usuário é adicionado no banco de dados e pode efetuar sign in em seguida
 
