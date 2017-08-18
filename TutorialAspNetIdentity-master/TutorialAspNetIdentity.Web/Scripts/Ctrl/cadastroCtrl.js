angular.module("cadastro").controller("cadastroCtrl", function ($scope) {

    $scope.app = "Faça seu cadastro";
    $scope.usuarios = [
        { nome: "Pedro", telefone: "997654322", email: "aron@gmail.com", celular: "453453453", endereco: "rua aaa", cep: "19260-000", senha:"aaaaaa", confirmarSenha:"aaaaaa", cidadeEstado:"Mirante do Paranapanema/SP", rg:"34.567.678-X", cpf:"345.567.789-12", celular:"99756-4532", dataNasc:"2000-12-23", profissao:"engenheiro" },
       
    ];

    $scope.addUsuario = function (usuario) {
        $scope.usuarios.push(angular.copy(usuario));
        delete $scope.usuario;
        $scope.cadastroForm.$setPristine();
        if(usuario.senha == usuario.confirmarSenha)
        {
            alert("ok");
        }

    };
    $scope.apagarUsuario = function (usuarios) {
        $scope.usuarios = usuarios.filter(function (usuario) {
            if (!usuario.selecionado) return usuario;
        });
    };
    $scope.classe = "selecionado";

    $scope.isUsuarioSelecionado = function (usuarios) {
        return usuarios.some(function (usuario) {
            return usuario.selecionado;
        });
    };
});
